using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
        public DateTime Added { get; set; }
        public int StockNumber { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}