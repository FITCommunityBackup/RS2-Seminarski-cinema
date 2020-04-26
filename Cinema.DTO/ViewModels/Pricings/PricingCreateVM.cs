﻿using System.ComponentModel.DataAnnotations;

namespace Cinema.DTO.ViewModels.Pricings
{
    public class PricingCreateVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field is required!")]
        [Range(0, 100)]
        [DisplayFormat(DataFormatString = "{0:#,###.00}", ApplyFormatInEditMode = true)]
        public float Price { get; set; }
    }
}
