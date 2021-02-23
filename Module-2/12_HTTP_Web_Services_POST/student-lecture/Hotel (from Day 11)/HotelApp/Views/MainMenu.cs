using MenuFramework;
using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_GET_lecture.Views
{
    public class MainMenu : ConsoleMenu
    {
        // Client for http calls
        private RestClient client;

        public MainMenu(string apiUrl)
        {
            // TODO 01: Create the RestClient here...
            client = new RestClient(apiUrl);

            AddOption("List Hotels", ListHotels)
                .AddOption("List Reviews", ListReviews)
                .AddOption("Show Details for a Hotel", HotelDetails)
                .AddOption("Show Reviews for a Hotel", HotelReviews)
                .AddOption("List Hotels with Rating", GetHotelsForRating)
                .AddOption("Exit", Exit)
                .Configure(c =>
                {
                    c.Title = "Welcome to Online Hotels! Please make a selection:";
                    c.ItemForegroundColor = ConsoleColor.Blue;
                });
        }

        private MenuOptionResult ListHotels()
        {
            // Call the api to get hotels (/hotels)
            RestRequest request = new RestRequest("hotels");

            IRestResponse<List<Hotel>> response = this.client.Get<List<Hotel>>(request);


            // Error shoting
            if(response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error - unable to reach teh server"); 
            } // Since we are throwing the above we don't have to use else
            if (!response.IsSuccessful)
            {
                throw new Exception($"Error - server returned error response: {(int)response.StatusCode} - {response.StatusCode}");
            }

            // Display the list to the user
            PrintHotels(response.Data);

            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult ListReviews()
        {
            // TODO 02: Call the api to get hotels (/reviews)
            RestRequest request = new RestRequest("reviews");
            IRestResponse<List<Review>> response = this.client.Get<List<Review>>(request);

            // TODO: Check for errors here.

            PrintReviews(response.Data);

            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult HotelDetails()
        {
            int hotelId = GetInteger("Enter the Hotel Id: ");

            // TODO 03: Call the api to get hotels (/hotels/{id})

            RestRequest request = new RestRequest($"hotels/{hotelId}");

            IRestResponse<Hotel> response = client.Get<Hotel>(request);
           
            // Error shoting
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception("Error - unable to reach teh server");
            } // Since we are throwing the above we don't have to use else
            if (!response.IsSuccessful)
            {
                throw new Exception($"Error - server returned error response: {(int)response.StatusCode} - {response.StatusCode}");
            }

            PrintHotel(response.Data);

            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult HotelReviews()
        {
            // TODO 04: Call the api to get hotels (/hotels/{id}/reviews)
            // Prompt user to giv us hotel Id
            int hotelId = GetInteger("Enter the Hotel Id: ");

            // Create a request
            RestRequest request = new RestRequest("hotels/" + hotelId + "/reviews");

            // Response with list of reviws and // Deserilize
            IRestResponse<List<Review>> response = client.Get<List<Review>>(request);

            //Display
            PrintReviews(response.Data);
            
            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult GetHotelsForRating()
        {
            // TODO 05: Call the api to get hotels (/hotels?stars={stars})
            // Prompt user for int of stars hotel 
            int star = GetInteger("Enter the star rating: ");

            // Create new request
            RestRequest request = new RestRequest("hotels?starts=" + star);

            // Get response with list of hotels and // Deserilize
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            // Disply response data
            PrintHotels(response.Data);

            return MenuOptionResult.WaitAfterMenuSelection;
        }


        #region Print Methods:
        private static void PrintHotels(List<Hotel> hotels)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hotels");
            Console.WriteLine("--------------------------------------------");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine(hotel.Id + ": " + hotel.Name);
            }
        }

        private static void PrintHotel(Hotel hotel)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hotel Details");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" Id: " + hotel.Id);
            Console.WriteLine(" Name: " + hotel.Name);
            Console.WriteLine(" Stars: " + hotel.Stars);
            Console.WriteLine(" Rooms Available: " + hotel.RoomsAvailable);
            Console.WriteLine(" Cover Image: " + hotel.CoverImage);
        }

        private static void PrintReviews(List<Review> reviews)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Review Details");
            Console.WriteLine("--------------------------------------------");
            foreach (Review review in reviews)
            {
                Console.WriteLine(" Hotel ID: " + review.HotelID);
                Console.WriteLine(" Title: " + review.Title);
                Console.WriteLine(" Review: " + review.ReviewText);
                Console.WriteLine(" Author: " + review.Author);
                Console.WriteLine(" Stars: " + review.Stars);
                Console.WriteLine("---");
            }
        }
        #endregion

    }
}
