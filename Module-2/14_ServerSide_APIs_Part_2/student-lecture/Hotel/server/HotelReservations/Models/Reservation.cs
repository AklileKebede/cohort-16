using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    // TODO 03: Use Postman to show how we can enter invalid data
    /*** TODO 04: Add data validation attributes to protect the model data
    *          HotelId, FullName, Checkin, Checkout and Guests are all required
    *          The number of guests should be in the Range of 1 - 5
    *          Full name should be at least 6 characters long
    ***/

    public class Reservation
    {
        /// <summary>
        /// The confirmation number for this reservation
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// The id of the hotel this reservation is for
        /// </summary>
        [Required(ErrorMessage ="The field HotelId is required.")]
        public int HotelId { get; set; }
        /// <summary>
        /// Full name of the guest staying at the hotel
        /// </summary>
        [Required(ErrorMessage ="The field FullName is required.")]
        [StringLength(100,ErrorMessage ="Invalid name length.")]
        public string FullName { get; set; }
        /// <summary>
        /// Date of arrival
        /// </summary>
       [Required(ErrorMessage ="The field Checkin is required.")]
        public DateTime CheckinDate { get; set; }
        /// <summary>
        /// Date of departure
        /// </summary>
        [Required(ErrorMessage ="The field Checkout is required.")]
        public DateTime CheckoutDate { get; set; }
        /// <summary>
        /// Total number of guests expected to stay overnight in the room.
        /// </summary>
        [Required]
        [Range(1,5,ErrorMessage ="Max number of guests is 5")]
        public int Guests { get; set; }

        public Reservation(int? id, int hotelId, string fullName, DateTime cID, DateTime cOD, int guests)
        {
            /*
            if (cID >= cOD) // if (checkinDate >= checkoutDate) //cID will not work but checkinDate will because the name matches. In general this is a bad coding as when running 
            {
                throw new Exception("checkout must be after checkin date");
            }
            */
            Id = id ?? new Random().Next(100, int.MaxValue);
            HotelId = hotelId;
            FullName = fullName;
            CheckinDate = cID;
            CheckoutDate = cOD;
            Guests = guests;
        }
    }
}
