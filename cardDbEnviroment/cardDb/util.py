from cardDb.models import Card, Operation, CardOperationLogString
from django.utils import timezone
from .errors import BadDataError
from datetime import datetime
from decimal import Decimal

def createCard(cardSeriesInput, cardIdInput, startDateInput, endDateInput, cvvInput, countInput, statusInput):
    if (len(cardSeriesInput) != 2) \
            or (len(cardIdInput) != 16) \
            or (not cardIdInput.isnumeric()) \
            or (startDateInput > endDateInput) \
            or (len(cvvInput) != 3) \
            or (not cvvInput.isnumeric()) \
            or (abs(countInput.as_tuple().exponent) > 2) \
            or (countInput > 1000000000) \
            or (statusInput not in [0,1,2]) :
        raise BadDataError("Invalid data present on card creation")
    else:
        cardInput = Card(cardSeries=cardSeriesInput, \
            cardId=cardIdInput, startDate=startDateInput, \
            endDate=endDateInput, cvv=cvvInput, \
            count=countInput, status=statusInput)
        return cardInput

def createCardJson(jsonCard):
    card = createCard(jsonCard["cardSeries"], jsonCard["cardId"], \
                datetime.strptime(jsonCard["startDate"],"%Y-%m-%dT%H:%M:%S.%fZ"),\
                datetime.strptime(jsonCard["endDate"],"%Y-%m-%dT%H:%M:%S.%fZ"), \
                jsonCard["cvv"], Decimal(jsonCard["count"]), jsonCard["status"])
    return card

def cardSearchQuery(jsonSearchField):
    query = {}
    if jsonSearchField["searchBySeries"]:
        query["cardSeries__exact"] = jsonSearchField["cardSeries"]
    if jsonSearchField["searchById"]:
        query["cardId__exact"] = jsonSearchField["cardId"]
    if jsonSearchField["searchByDateStartFrom"]:
        query["startDate__gte"] = jsonSearchField["dateStartFrom"]
    if jsonSearchField["searchByDateStartTo"]:
        query["startDate__lte"] = jsonSearchField["dateStartTo"]
    if jsonSearchField["searchByDateEndFrom"]:
        query["endDate__gte"] = jsonSearchField["dateEndFrom"]
    if jsonSearchField["searchByDateEndTo"]:
        query["endDate__lte"] = jsonSearchField["dateEndTo"]
    if jsonSearchField["searchByCountFrom"]:
        query["count__gte"] = jsonSearchField["countFrom"]
    if jsonSearchField["searchByCountTo"]:
        query["count__lte"] = jsonSearchField["countTo"]
    if jsonSearchField["searchByStatus"]:
        query["status__exact"] = jsonSearchField["status"]

    return query