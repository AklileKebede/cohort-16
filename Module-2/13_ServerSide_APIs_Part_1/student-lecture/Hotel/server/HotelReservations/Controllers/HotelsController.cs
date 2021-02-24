using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")] // This is the list commen dominator
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelDao hotelDao;
        private IReservationDao reservationDao;

        public HotelsController()
        { // If we didn't define the Dao here, we would have passed it in as a parameter
            hotelDao = new HotelFakeDao();
            reservationDao = new ReservationFakeDao();
        }

        [HttpGet("hotels")]
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public Hotel GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }

            return null;
        }

        [HttpGet("hotels/{hotelId}/reservations")]
        public List<Reservation> GetReservations(int hotelId)
        {
            return reservationDao.FindByHotel(hotelId);
        }

        // Get all reservation in the DB
        [HttpGet("reservations")]
        public List<Reservation> GetReservations()
        {
            return reservationDao.List();
        }

        // Create a new reservation
        [HttpPost("reservations")]
        public ActionResult<Reservation> CreateReservation(Reservation newReservation)
        {
            Reservation reservation = reservationDao.Create(newReservation);
            
            return Created($"/reservations/{reservation.Id}",reservation);
        }
        
        // Update an existing reservation

        [HttpPut("reservations/{reservationId}")]
        public ActionResult<Reservation> UpdateReservation(int reservationId, Reservation UpdatedReservation)
        {
            // Make sure the id's match

            if (reservationId != UpdatedReservation.Id)
            {
                return UnprocessableEntity();
            }

            UpdatedReservation = reservationDao.Update(UpdatedReservation);
           
            return Ok(UpdatedReservation);
        }

        // Delete reservation
        [HttpDelete("reservations/{idToDelete}")]
        public ActionResult DeleteReservation(int idToDelete)
        {
            if (reservationDao.Delete(idToDelete))
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
