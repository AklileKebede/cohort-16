using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Locations.DAO;
using Locations.Models;

namespace Locations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationDao dao;

        public LocationsController(ILocationDao locationsDao)
        {
            dao = locationsDao;
        }

        [HttpGet]
        public List<Location> List()
        {
            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Location> Get(int id)
        {
            Location location = dao.Get(id);
            if (location != null)
            {
                return Ok(location);
            }
            else
            {
                return NotFound("Location does not exist");
            }
        }

        [HttpPost]
        public ActionResult<Location> Add(Location location)
        { // Removed the null condition after setting a [Required] attribute to the properties of Location
            /*if (location != null)
            {*/
            Location returnLocation = dao.Create(location);
            return Created($"locations/{returnLocation.Id}", returnLocation); //you'll send back the location of the new resource—that is, the URL—along with the resource itself

            /* }
             return null;
            */
        }
        [HttpPut("{id}")]
        public ActionResult<Location> UpdateLocation(int id, Location location)
        {
            // Client tries to update a location that doesn't exist

            Location doesLocationExist = dao.Get(id);
            if(doesLocationExist== null)
            {
                return NotFound("Location doesn't exist.");
            }

            //  ID is a valid
            location = dao.Update(id, location);
            return Ok(location);
        }

        // Step Six: Delete a location
        [HttpDelete("{id}")]
        public ActionResult DeleteLocation(int id)
        {
            Location doesLocationExist = dao.Get(id);
            if (doesLocationExist == null)
            {
                return NotFound("Location doesn't exist.");
            }
            dao.Delete(id);
            return NoContent();
        }
    }

}
