using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Entities
{
    public class Auction
    {
        public int AuctionID { get; set; }
        public string Title { get; set; }
        public string PictureURL { get; set; }
        public string Discription { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }

    }
}
