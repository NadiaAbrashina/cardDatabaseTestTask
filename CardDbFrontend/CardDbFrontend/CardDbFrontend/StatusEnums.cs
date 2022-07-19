using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDbFrontend
{
    public enum CardStatus
    {
        ACTIVE = 0,
        BLOCKED = 1,
        EXPIRED = 2
    }

    public enum OperationTypes
    {
        INCOME = 0,
        OUTCOME = 1,
        ERROR_TYPE = 3
    }

    public enum CardOperationType
    {
        CARD_CREATED = 0,
        CARD_STATUS_CHANGED = 1,
        CARD_DELETED = 2
    }

    public enum CardDurations
    {
        YEAR = 0,
        SIX_MONTHS = 1,
        MONTH = 2
    }
}
