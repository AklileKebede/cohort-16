using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")] //"/auctions"
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        // Step Two: Implement Get/auctions // Step Five: Enhancement of http method to get Serching by ?title_like=
        [HttpGet]
        public List<Auction> GettAuctions(string title_like="", double currentBid_lte=0)
        {
            if (currentBid_lte > 0 && title_like != "")
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            else if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            else if (title_like!="")
            {
                return dao.SearchByTitle(title_like);
            }
            return dao.List();
        }

        // Step Three: Implement GET /auctions/id
        [HttpGet("{idAuction}")]
        public Auction GetAuction(int idAuction)
        {
            return dao.Get(idAuction);
        }

        // Step Four: Implement POST /auctions
        [HttpPost]
        public Auction CreateAuction(Auction newAuction)
        {
            return dao.Create(newAuction);
        }
    }
}
