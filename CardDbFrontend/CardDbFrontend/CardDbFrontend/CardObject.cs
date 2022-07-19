using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDbFrontend
{
    public class CardObject
    {
        public string cardSeries { get; set; }
        public string cardId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string cvv { get; set; }
        public Decimal count { get; set; }
        public CardStatus status { get; set; }
        public int pk { get; set; }
    }

    public class CardObjectFromServer
    {
        public string model;
        public int? pk;
        public CardObject fields;
    }
}
