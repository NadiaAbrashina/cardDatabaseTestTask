from django.db import models
from django.core import serializers
import json
from django.utils import timezone

# Create your models here.
class Card(models.Model):

    class CardStatus(models.IntegerChoices):
        ACTIVE = 0
        BLOCKED = 1
        EXPIRED = 2

    cardSeries = models.CharField(max_length=2)
    cardId = models.CharField(max_length=16, unique=True)
    startDate = models.DateTimeField('Published date')
    endDate = models.DateTimeField('Expired date')
    cvv = models.CharField(max_length=3)
    count = models.DecimalField(max_digits=12, decimal_places=2)
    status = models.IntegerField(choices=CardStatus.choices)

    def __str__(self):
        return serializers.serialize('json', self)
    
    def expired(self):
        expired = self.endDate < timezone.now()
        if expired and (self.status!= 2):
            self.status = 2
            self.save()
        return expired
        

class Operation(models.Model):

    class OperationTypes(models.IntegerChoices):
        INCOME = 0
        OUTCOME = 1
    
    moneyAmount = models.DecimalField(max_digits=12, decimal_places=2)
    operationType = models.IntegerField(choices=OperationTypes.choices)
    purpouce = models.CharField(max_length=255)
    card = models.ForeignKey(Card, on_delete=models.CASCADE)
    date = models.DateTimeField('OperationDate')

    def __str__(self):
        return serializers.serialize('json', self)

class CardOperationLogString(models.Model):
    class CardOperationType (models.IntegerChoices):
        CARD_CREATED = 0
        CARD_STATUS_CHANGED = 1
        CARD_DELETED = 2
    
    operationType = models.IntegerField(choices=CardOperationType.choices, editable=False)
    cardSeries = models.CharField(max_length=2, editable=False)
    cardId = models.CharField(max_length=16, editable=False)
    cardCount = models.DecimalField(max_digits=12, decimal_places=2, editable=False)
    date = models.DateTimeField('OperationDate')

    def __str__(self):
        return serializers.serialize('json', self)