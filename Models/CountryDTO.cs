using HotelListing.Controllers.Data;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CountryDTO : CreateCountryDTO
    {

        public int Id { get; set; }

        public   IList<HotelDTO> Hotels { get; set; }
    }

    //WITHOUT ID
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "country name is too long")]
        public string Name { get; set; } = string.Empty;


        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "country short  is too long")]
        public string ShortName { get; set; } = string.Empty;

    }




}
