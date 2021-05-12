using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperationsDotNetCore5.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required, MaxLength(100) ]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public double Rate { get; set; }

        [Required, MaxLength(2500)]
        public string StoryLine { get; set; }

        [Required]
        public byte[] Poster { get; set; }

        public byte GenreID { get; set; }
        
        public Genre Genre  { get; set; }


    }
}
