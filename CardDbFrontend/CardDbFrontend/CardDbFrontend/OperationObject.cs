using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDbFrontend
{
    public class OperationObject
    {
        public Decimal moneyAmount { get; set; }
        public OperationTypes operationType { get; set; }
        public string purpouce { get; set; }
        public int card { get; set; }
        public DateTime date { get; set; }
    }

    public class OperationObjectFromServer
    {
        public string model;
        public int pk;
        public OperationObject fields;
    }
}
