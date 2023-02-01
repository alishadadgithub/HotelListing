using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Security.Principal;

namespace HotelListing.Controllers.Data
{
    public class Hotel
    {

        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public double Rating { get; set; }




        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country? Country { get; set; } 


    }
}
 