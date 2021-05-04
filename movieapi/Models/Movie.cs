using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }


        public int ReleaseDate { get; set; }

        [MaxLength(50)]
        public string Genre { get; set; }


        public int Runtime { get; set; }
        
        //[ForeignKey("Director")]
        //public int DirectorId { get; set; }
        //public Director Director { get; set; }
    }
}
