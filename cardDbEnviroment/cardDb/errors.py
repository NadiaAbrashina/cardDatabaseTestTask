class Error(Exception):
    """Base class for other exceptions"""

    # Constructor or Initializer
    def __init__(self, value):
        self.value = value
   
    # __str__ is to print() the value
    def __str__(self):
        return(repr(self.value))

    pass

class BadDataError(Error):
    """Reised when request data are incorrect to use even though can be processed"""
    pass

class OperationProhibitedError(Error):
    """Reised when some forbidden operation is attempted to perform"""
    pass