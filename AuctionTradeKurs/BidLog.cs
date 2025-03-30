using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionTradeKurs
{
    internal class BidLog
    {
        public string Participant { get; set; }
        public string Action { get; set; }
        public DateTime ActionDateTime { get; set; }
    }
}
