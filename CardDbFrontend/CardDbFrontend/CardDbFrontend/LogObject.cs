using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDbFrontend
{
    public class LogObject
    {
        public CardOperationType operationType { get; set; }
        public string cardSeries { get; set; }
        public string cardId { get; set; }
        public Decimal cardCount { get; set; }
        public DateTime date { get; set; }
    }

    public class LogObjectFromServer
    {
        public string model;
        public int pk;
        public LogObject fields;
    }
}
