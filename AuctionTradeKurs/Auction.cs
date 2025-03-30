using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionTradeKurs
{
    public class Auction
    {
        public int AuctionId { get; set; }
        public string Auctioneer { get; set; }
        public string Place { get; set; }
        public string Form { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Status { get; set; }
    }
}
