using System.ComponentModel.DataAnnotations;

namespace HotelListing.Controllers.Data
{
    public class Country
    {

        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; } = string.Empty;
        [Required] public string ShortName { get;set; } = string.Empty;
    }
}
