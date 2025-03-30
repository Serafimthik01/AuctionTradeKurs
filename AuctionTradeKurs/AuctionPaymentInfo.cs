using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionTradeKurs
{
    internal class AuctionPaymentInfo
    {
        public string LotName { get; set; }
        public string BuyerName { get; set; }
        public decimal FinalPrice { get; set; }
        public DateTime AuctionEndTime { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public string PaymentStatus { get; set; }
    }
}
