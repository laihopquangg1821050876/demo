using System;
using System.ComponentModel.DataAnnotations;



namespace MvcMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Required(ErrorMessage = " Not found")]
        [MaxLength(15)]
        [MinLength(3)]
        public decimal Price { get; set; }
    }
}