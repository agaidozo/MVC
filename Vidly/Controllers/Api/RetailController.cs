using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RetailController : ApiController
    {
        private ApplicationDbContext _context;

        public RetailController()
        {
            _context = new ApplicationDbContext();
        }

        //POST /api/retail
        [HttpPost]
        public IHttpActionResult CreateRetail(RentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(m => newRental.MoviesId.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Retail.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
