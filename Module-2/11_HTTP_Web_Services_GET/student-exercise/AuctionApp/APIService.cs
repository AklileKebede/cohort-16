using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        // Path to Application Programming Interface end point=Uniform Resource Location
        public const string API_URL = "http://localhost:3000/auctions";
        // Creates a new client and can be accessed by all methods
        public IRestClient client = new RestClient();

        public List<Auction> GetAllAuctions()
        {
            // Create a new request with the path
            RestRequest request = new RestRequest(API_URL);
            // GET request using the client 
            IRestResponse<List<Auction>> response = this.client.Get<List<Auction>>(request);

            // Deserialize JSON and // Display
            return (response.Data);

           
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            // Create a new request with the path
            RestRequest request = new RestRequest($"{API_URL}/{auctionId}");

            // GET request using the client 
            IRestResponse<Auction> response = client.Get<Auction>(request);
            
            // Deserialize JSON and // Display
            return response.Data;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            // Create a new request with the path
            RestRequest request = new RestRequest($"{API_URL}?title_like={searchTitle}");

            //Get response using the request
            IRestResponse<List<Auction>> response = this.client.Get<List<Auction>>(request);

            // Deserialize JSON and // Return
            return response.Data;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            // Creat a new request path
            RestRequest request = new RestRequest($"{API_URL}?currentBid_lte={searchPrice}");

            // Get response using the request
            IRestResponse<List<Auction>> response = this.client.Get<List<Auction>>(request);

            // Deserialize JSON and// return

            return response.Data;
        }
    }
}
