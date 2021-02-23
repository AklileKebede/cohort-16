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

            IRestResponse<List<Hotel>> response = this.client.Get<List<Hotel>>(request); // We need to specify the type of Get

            // Display the list to the user
            PrintHotels(response.Data); // Prints the hotel ID and name

            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult ListReviews()
        {
            // TODO 02: Call the api to get hotels (/reviews)
            RestRequest request = new RestRequest("Reviews");

            IRestResponse<List<Review>> response = this.client.Get<List<Review>>(request); // Gives type list of type review

            // Display the list of reviews
            PrintReviews(response.Data);

            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult HotelDetails()
        {
            // Prompet the user for ID of hotel wanted
            int hotelId= GetInteger("Enter the hotel Id: ");

            // TODO 03: Call the api to get hotels (/hotels/{id})
            RestRequest request = new RestRequest($"hotels/{hotelId}"); // request is the correct full URL

            IRestResponse<Hotel> response = this.client.Get<Hotel>(request); // Information from the URL we are receiveing

            // Display
            PrintHotel(response.Data);

            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult HotelReviews()
        {
            // TODO 04: Call the api to get hotels (/hotels/{id}/reviews)
            Console.WriteLine("Not Implemented");

            return MenuOptionResult.WaitAfterMenuSelection;
        }

        private MenuOptionResult GetHotelsForRating()
        {
            // TODO 05: Call the api to get hotels (/hotels?stars={stars})
            Console.WriteLine("Not Implemented");

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
