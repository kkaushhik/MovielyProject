using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Moviely.Models
{
    public class Movie
    {
        public int Id { get; set; }
        //[Required]
        public string Name { get; set; }
        [Display(Name = "Date of Release")]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}
