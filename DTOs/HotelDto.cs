using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.DTOs
{
    public class CreateHotelDto
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Address Is Too Long")]
        public string Address { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
    }

    public class HotelDto : CreateHotelDto
    {
        public int Id { get; set; }
        public CountryDto Country { get; set; }
        public IList<HotelDto> Hotels { get; set; }
    }
}