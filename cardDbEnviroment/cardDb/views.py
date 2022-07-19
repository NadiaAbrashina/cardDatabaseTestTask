from ast import ExceptHandler, arguments
from asyncio.windows_events import NULL
from dataclasses import Field
from datetime import datetime
import imp
from unicodedata import decimal
from django.shortcuts import render
from cardDb.models import Card, Operation, CardOperationLogString
from django.http import HttpResponse, HttpRequest, HttpResponseBadRequest, HttpResponseServerError
from django.utils import timezone
from django.views.decorators.csrf import csrf_exempt
from django.core import serializers
import json
from django.core.exceptions import FieldError
from decimal import Decimal
from .errors import BadDataError, OperationProhibitedError
import random
import string
import datetime
from .util import createCardJson, cardSearchQuery
from django.db.utils import IntegrityError
from .errorHandlers import ErrorHandlers

# Create your views here.
def getCards(request):
    if request.method == 'GET':
        try:
            cardOutput = serializers.serialize('json', Card.objects.all())
            return HttpResponse(cardOutput)
        except :
            return ErrorHandlers.UnknownErrorHandler()


@csrf_exempt
def cardSearchBy(request):
    """
    JSON
    searchBySeries
    searchById
    searchByDateStartFrom
    searchByDateStartTo
    searchByDateEndFrom
    searchByDateEndTo
    searchByStatus
    searchByCountFrom
    searchByCountTo
    cardSeries
    cardId
    dateStartFrom
    dateStartTo
    dateEndFrom
    dateEndTo
    status
    countFrom
    countTo
    """
    if request.method == 'POST':
        try:
            requestData = json.loads(request.body.decode('utf-8'))
            print(requestData)
            query = cardSearchQuery(requestData)
            cardsData = Card.objects.filter(**query)
            cardOutput = serializers.serialize('json', cardsData)
            return HttpResponse(cardOutput)
        except json.JSONDecodeError as JSONErrorData:
            return ErrorHandlers.JSONErrorHandler(JSONErrorData)
        except TypeError as TypeErrorData:
            return ErrorHandlers.DataTypeErrorHandler(TypeErrorData)
        except FieldError as FieldErrorData:
            return ErrorHandlers.FieldErrorHandler(FieldErrorData)
        except :
            return ErrorHandlers.UnknownError()


"""
JSON
card
operationType
moneyAmount
"""
@csrf_exempt
def cardCountChange(request):
    if request.method == "POST":
        try:
            requestData = json.loads(request.body.decode('utf-8'))
            cardIdInput = requestData["card"]
            operationTypeInput = requestData["operationType"]
            moneyAmountInput = Decimal(requestData["moneyAmount"])
            if (abs(moneyAmountInput.as_tuple().exponent) > 2) or (moneyAmountInput > 1000000000):
                raise BadDataError("Wrong money count provided: " + str(moneyAmountInput))
            cardSelected = Card.objects.get(id = cardIdInput)
            if (cardSelected.status != 0):
                raise OperationProhibitedError("Opperations with non-active cards are not allowed; card status " + str(cardSelected.status))
            if operationTypeInput == 0:
                cardSelected.count = cardSelected.count + moneyAmountInput
            elif operationTypeInput == 1:
                cardSelected.count = cardSelected.count - moneyAmountInput
            else :
                raise BadDataError("Invalid operation type; type provided "+str(operationTypeInput))
            cardSelected.save()
            return HttpResponse(status=200)
        except json.JSONDecodeError as JSONErrorData:
            return ErrorHandlers.JSONErrorHandler(JSONErrorData)
        except TypeError as TypeErrorData:
            return ErrorHandlers.DataTypeErrorHandler(TypeErrorData)
        except FieldError as FieldErrorData:
            return ErrorHandlers.FieldErrorHandler(FieldErrorData)
        except BadDataError as BadDataErrorData:
            return ErrorHandlers.BadDataErrorHandler(BadDataErrorData)
        except KeyError as KeyErrorData:
            return ErrorHandlers.KeyErrorHandler(KeyErrorData)
        except OperationProhibitedError as OperationProhibitedErrorData:
            return ErrorHandlers.OperationProhibitedErrorHandler(OperationProhibitedErrorData)
        except Card.DoesNotExist as CardNotFoundData:
            return ErrorHandlers.CardNotFoundHandler(CardNotFoundData)
        except :
            return ErrorHandlers.UnknownErrorHandler()


"""
JSON
card
operationType
moneyAmount
purpouce
"""
@csrf_exempt
def cardOperationWrite(request):
    if request.method == 'POST':
        try:
            print(request.body)
            requestData = json.loads(request.body.decode('utf-8'))
            cardIdInput = requestData["card"]
            operationTypeInput = requestData["operationType"]
            moneyAmountInput = Decimal(requestData["moneyAmount"])
            if (abs(moneyAmountInput.as_tuple().exponent) > 2) or (moneyAmountInput > 1000000000):
                raise BadDataError("Wrong money count provided: " + str(moneyAmountInput))
            purpouseInput = requestData["purpouce"]
            dateInput = timezone.now()
            cardSelected = Card.objects.get(id = cardIdInput)
            if operationTypeInput not in [0,1]:
                raise BadDataError("Invalid operation type; type provided "+str(operationTypeInput))
            operation = Operation(card=cardSelected, operationType=operationTypeInput, moneyAmount=moneyAmountInput, purpouce=purpouseInput, date=dateInput)
            operation.save()
            return HttpResponse(status=201)
        except json.JSONDecodeError as JSONErrorData:
            return ErrorHandlers.JSONErrorHandler(JSONErrorData)
        except TypeError as TypeErrorData:
            return ErrorHandlers.DataTypeErrorHandler(TypeErrorData)
        except FieldError as FieldErrorData:
            return ErrorHandlers.FieldErrorHandler(FieldErrorData)
        except BadDataError as BadDataErrorData:
            return ErrorHandlers.BadDataErrorHandler(BadDataErrorData)
        except KeyError as KeyErrorData:
            return ErrorHandlers.KeyErrorHandler(KeyErrorData)
        except Card.DoesNotExist as CardNotFoundData:
            return ErrorHandlers.CardNotFoundHandler(CardNotFoundData)
        except :
            return ErrorHandlers.UnknownErrorHandler()

"""
JSON
card
"""
@csrf_exempt
def cardOperationsSelect(request):
    if request.method == "POST":
        try:
            print(str(request.body))
            requestData = json.loads(request.body.decode('utf-8'))
            cardIdInput = requestData["card"]
            cardSelected = Card.objects.get(id = cardIdInput)
            operationsData = Operation.objects.filter(card = cardSelected)
            operationsOutput = serializers.serialize('json', operationsData)
            return HttpResponse(operationsOutput)
        except json.JSONDecodeError as JSONErrorData:
            return ErrorHandlers.JSONErrorHandler(JSONErrorData)
        except TypeError as TypeErrorData:
            return ErrorHandlers.DataTypeErrorHandler(TypeErrorData)
        except KeyError as KeyErrorData:
            return ErrorHandlers.KeyErrorHandler(KeyErrorData)
        except Card.DoesNotExist as CardNotFoundData:
            return ErrorHandlers.CardNotFoundHandler(CardNotFoundData)
        except :
            return ErrorHandlers.UnknownErrorHandler()


"""
JSON
card
status
"""
@csrf_exempt
def cardStatusChange(request):
    if request.method == "PATCH":
        try:
            requestData = json.loads(request.body.decode('utf-8'))
            cardIdInput = requestData["card"]
            newStatus = requestData["status"]
            if newStatus not in [0,1,2]:
                raise BadDataError("Invalid card status. Status provided: " + str(newStatus))
            cardSelected = Card.objects.get(id = cardIdInput)
            cardSelected.status = newStatus
            cardSelected.save()
            return HttpResponse(status=200)
        except json.JSONDecodeError as JSONErrorData:
            return ErrorHandlers.JSONErrorHandler(JSONErrorData)
        except TypeError as TypeErrorData:
            return ErrorHandlers.DataTypeErrorHandler(TypeErrorData)
        except KeyError as KeyErrorData:
            return ErrorHandlers.KeyErrorHandler(KeyErrorData)
        except Card.DoesNotExist as CardNotFoundData:
            return ErrorHandlers.CardNotFoundHandler(CardNotFoundData)
        except BadDataError as BadDataErrorData:
            return ErrorHandlers.BadDataErrorHandler(BadDataErrorData)
        except :
            return ErrorHandlers.UnknownErrorHandler()


"""
JSON
cardSeries
cardId
count
operation
"""
@csrf_exempt
def logwrite(request):
    if request.method == "POST":
        try:
            requestData = json.loads(request.body.decode('utf-8'))
            cardSeries = requestData["cardSeries"]
            cardId = requestData["cardId"]
            count = requestData["count"]
            operationTypeInput = requestData["operation"]
            if operationTypeInput not in [0,1,2]:
                raise BadDataError("Invalid card operation on card. Operation provided: " + str(operationTypeInput))
            logString = CardOperationLogString(operationType=operationTypeInput, cardSeries=cardSeries, cardId=cardId, cardCount=count, date=timezone.now())
            logString.save()
            return HttpResponse(status=201)
        except json.JSONDecodeError as JSONErrorData:
            return ErrorHandlers.JSONErrorHandler(JSONErrorData)
        except TypeError as TypeErrorData:
            return ErrorHandlers.DataTypeErrorHandler(TypeErrorData)
        except KeyError as KeyErrorData:
            return ErrorHandlers.KeyErrorHandler(KeyErrorData)
        except Card.DoesNotExist as CardNotFoundData:
            return ErrorHandlers.CardNotFoundHandler(CardNotFoundData)
        except BadDataError as BadDataErrorData:
            return ErrorHandlers.BadDataErrorHandler(BadDataErrorData)
        except :
            return ErrorHandlers.UnknownErrorHandler()


"""
JSON
card
"""
@csrf_exempt
def cardRemove(request):
    if (request.method == "DELETE"):
        try:
            requestData = json.loads(request.body.decode('utf-8'))
            cardIdInput = requestData["card"]
            cardSelected = Card.objects.get(id = cardIdInput)
            cardSelected.delete()
            return HttpResponse(status = 204)
        except json.JSONDecodeError as JSONErrorData:
            return ErrorHandlers.JSONErrorHandler(JSONErrorData)
        except TypeError as TypeErrorData:
            return ErrorHandlers.DataTypeErrorHandler(TypeErrorData)
        except KeyError as KeyErrorData:
            return ErrorHandlers.KeyErrorHandler(KeyErrorData)
        except Card.DoesNotExist as CardNotFoundData:
            return ErrorHandlers.CardNotFoundHandler(CardNotFoundData)
        except :
            return ErrorHandlers.UnknownErrorHandler()


"""
JSON
cardsSeries
cardsNumber
daysActive
"""
@csrf_exempt
def cardsGenerate(request):
    if request.method == "POST":
        try:
            requestData = json.loads(request.body.decode('utf-8'))
            cardsSeriesInput = requestData["cardsSeries"]
            cardsNumber = requestData["cardsNumber"]
            daysActive = requestData["daysActive"]
            cardsCreated = []
            for i in range(cardsNumber):
                cardIdInput = ''.join((random.choice(string.digits) for x in range(16)))
                cvvInput = ''.join((random.choice(string.digits) for x in range(3)))
                startDateInput = timezone.now()
                endDateInput = startDateInput + datetime.timedelta(days=daysActive)
                countInput = Decimal("0.00")
                statusInput = 0
                newCard = Card(cardSeries=cardsSeriesInput, \
                cardId=cardIdInput, \
                startDate=startDateInput, \
                endDate=endDateInput, \
                cvv=cvvInput, \
                count=countInput, \
                status=statusInput)
                cardsCreated.append(newCard)
            cardsOutput = serializers.serialize('json', cardsCreated)
            return HttpResponse(cardsOutput)
        except json.JSONDecodeError as JSONErrorData:
            return ErrorHandlers.JSONErrorHandler(JSONErrorData)
        except TypeError as TypeErrorData:
            return ErrorHandlers.DataTypeErrorHandler(TypeErrorData)
        except KeyError as KeyErrorData:
            return ErrorHandlers.KeyErrorHandler(KeyErrorData)
        except :
            return ErrorHandlers.UnknownErrorHandler()

"""
JSON
Representation of Card model object or Card fields
"""
@csrf_exempt
def cardAdd(request):
    if request.method == "POST":
        try:
            requestData = json.loads(request.body.decode('utf-8'))
            card = NULL
            if "fields" in requestData.keys():
                card = createCardJson(requestData["fields"])
            else:
                card = createCardJson(requestData)
            card.save()
            return HttpResponse(status = 201)
        except json.JSONDecodeError as JSONErrorData:
            return ErrorHandlers.JSONErrorHandler(JSONErrorData)
        except TypeError as TypeErrorData:
            return ErrorHandlers.DataTypeErrorHandler(TypeErrorData)
        except KeyError as KeyErrorData:
            return ErrorHandlers.KeyErrorHandler(KeyErrorData)
        except IntegrityError as IntegrityErrorData:
            return ErrorHandlers.IntegrityErrorHandler(IntegrityErrorData)
        except BadDataError as BadDataErrorData:
            return ErrorHandlers.BadDataErrorHandler(BadDataErrorData)
        except :
            return ErrorHandlers.UnknownErrorHandler()


def readLog(request):
    if request.method == 'GET':
        try:
            logOutput = serializers.serialize('json', CardOperationLogString.objects.all())
            return HttpResponse(logOutput)
        except :
            return ErrorHandlers.UnknownErrorHandler()
      
        

def index(request):
    return HttpResponse("Hello, world. You're at the cardDb index.")
