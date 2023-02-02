using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class HotelDTO
    {

         public int Id { get; set; }

        [Required]
        [StringLength(30,ErrorMessage ="TOO LONG")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100, ErrorMessage = "TOO LONG")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }


        [Required]
        public int CountryId { get; set; }
    }


    public class CreateHotelDTO
    {

        

        [Required]
        [StringLength(30, ErrorMessage = "TOO LONG")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100, ErrorMessage = "TOO LONG")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }


        [Required]
        public int CountryId { get; set; }
    }
}
