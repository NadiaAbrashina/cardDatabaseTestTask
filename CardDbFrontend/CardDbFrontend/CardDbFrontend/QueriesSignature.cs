using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDbFrontend
{
    public class CardSelectData
    {
        public int card;
    }

    public class CardOperationPerform
    {
        public int card;
        public int operationType;
        public string moneyAmount;
        public string purpouce;
    }

    public class LogData
    {
        public string cardSeries;
        public string cardId;
        public string count;
        public int operation;
    }

    public class CardStatusChangeData
    {
        public int card;
        public int status;
    }

    public class CardSearchData
    {
        public bool searchBySeries;
        public bool searchById;
        public bool searchByDateStartFrom;
        public bool searchByDateStartTo;
        public bool searchByDateEndFrom;
        public bool searchByDateEndTo;
        public bool searchByStatus;
        public bool searchByCountFrom;
        public bool searchByCountTo;

        public string cardSeries;
        public string cardId;
        public DateTime dateStartFrom;
        public DateTime dateStartTo;
        public DateTime dateEndFrom;
        public DateTime dateEndTo;
        public int status;
        public string countFrom;
        public string countTo;
    }

    public class CardGenerateData
    {
        public string cardsSeries;
        public int cardsNumber;
        public int daysActive;
    }
}
