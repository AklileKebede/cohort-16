using RestSharp;
using System;
using System.Collections.Generic;

namespace LocationApp
{
    public class APIService
    {
        const string API_URL = "http://localhost:3000/locations";
        readonly RestClient client = new RestClient();

        public List<Location> GetAllLocations()
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Location>> response = client.Get<List<Location>>(request);
            return response.Data;
        }

        public Location GetDetailsForLocation(int locationId)
        {
            RestRequest requestOne = new RestRequest(API_URL + "/" + locationId);
            IRestResponse<Location> response = client.Get<Location>(requestOne);

            if(response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("An error occured communicating with the server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new Exception("An error response was received from the server. The status code is " + (int)response.StatusCode);
            }
            else
            {
                return response.Data;
            }
        }

        public Location AddLocation(Location newLocation)
        {
            //Creat new request path
            RestRequest request = new RestRequest(API_URL);

            // Attach request with new data
            request.AddJsonBody(newLocation);

            // Serialize request data and // Deserialize Post response
            IRestResponse<Location> response = client.Post<Location>(request);

            // return
            return response.Data;
        }

        public Location UpdateLocation(Location locationToUpdate)
        {
            // Create a new request path
            RestRequest request = new RestRequest(API_URL + "/" + locationToUpdate.Id);

            // Attach request with data
            request.AddJsonBody(locationToUpdate);

            // Serialize request and // Deserialize Put response
            IRestResponse<Location> response = client.Put<Location>(request);

            // return
            return response.Data;
        }

        public bool DeleteLocation(int locationId)
        {
            // Creat a new request path
            RestRequest request = new RestRequest(API_URL + "/" + locationId);

            // Creat response
            IRestResponse response = this.client.Delete(request);
        }
    }
}