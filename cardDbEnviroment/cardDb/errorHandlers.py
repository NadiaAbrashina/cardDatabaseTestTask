from django.http import HttpResponseBadRequest, HttpResponseServerError

class ErrorHandlers():

    @staticmethod
    def UnknownErrorHandler():
        return HttpResponseServerError("Unknown error occured", status = 500)

    @staticmethod
    def JSONErrorHandler(data):
        return HttpResponseBadRequest("Incorrect JSON string provided: " + str(data), status=400)

    @staticmethod
    def DataTypeErrorHandler(data):
        return HttpResponseBadRequest("Some data have incorrect format: " + str(data), status=400)

    @staticmethod
    def FieldErrorHandler(data):
        return HttpResponseBadRequest("Some incorrect fields provided: " + str(data), status=422)

    @staticmethod
    def BadDataErrorHandler(data):
        return HttpResponseBadRequest("Some data don't match requirement" + str(data), status=422)

    @staticmethod
    def KeyErrorHandler(data):
        return HttpResponseBadRequest("Some data not present" + str(data), status=422)

    @staticmethod
    def CardNotFoundHandler(data):
        return HttpResponseBadRequest("No such card"+ str(data), status=404)

    @staticmethod
    def IntegrityErrorHandler(data):
        return HttpResponseBadRequest("Card already exists" + str(data), status=422)

    @staticmethod
    def OperationProhibitedErrorHandler(data):
        return HttpResponseBadRequest("Attempt to perform invalid operation: "+ str(data), status=403)