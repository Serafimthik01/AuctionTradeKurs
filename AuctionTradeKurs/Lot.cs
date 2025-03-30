using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionTradeKurs
{
    internal class Lot
    {
        public int LotId { get; set; }
        public string CategoryName { get; set; }
        public string LotName { get; set; }
        public string Description { get; set; }
        public decimal StartPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public string Status { get; set; }
        public string SellerName { get; set; }
        public string BuyerName { get; set; }
        public int BidCount { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
