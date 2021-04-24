using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.DTOs
{
    public class CountryCreateDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Is too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Country Name Is too Long")]
        public string ShortName { get; set; }
    }

    public class CountryDto : CountryCreateDto
    {
        public int Id { get; set; }
        public IList<HotelDto> Hotels { get; set; }
    }

    public class UpdateCountryDto : CountryCreateDto
    {
        public IList<CreateHotelDto> Hotels { get; set; }
    }
}