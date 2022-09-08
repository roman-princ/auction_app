using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auction_app.Models
{
    public class Auction
    {
        public Guid AuctionId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int HighestBid { get; set; }
        public DateTime EndDate { get; set; }
        public User Creator { get; set; }
        public User HighestBidder { get; set; }
        

    }
}
