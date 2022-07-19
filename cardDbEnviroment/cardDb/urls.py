from django.urls import path

from . import views

urlpatterns = [
    path('', views.index, name='index'),
    path('cards', views.getCards, name='cards'),
    path('cardSearchBy', views.cardSearchBy, name='cardSearchBy'),
    path('cardCountChange', views.cardCountChange, name='cardCountChange'),
    path('cardOperationWrite', views.cardOperationWrite, name="cardOperationWrite"),
    path('cardOperationsSelect', views.cardOperationsSelect, name='cardOperationsSelect'),
    path('cardStatusChange', views.cardStatusChange, name='cardStatusChange'),
    path('logwrite', views.logwrite, name='logwrite'),
    path('cardRemove', views.cardRemove, name='cardRemove'),
    path('cardsGenerate', views.cardsGenerate, name='cardsGenerate'),
    path('cardAdd', views.cardAdd, name='cardAdd'),
    path('readLog',views.readLog, name='readLog'),
]