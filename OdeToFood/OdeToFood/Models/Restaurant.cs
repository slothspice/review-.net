﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// as name implies
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class Restaurant
    {

        public int Id { get; set; }

        [Display(Name="Restaurant Name")]
        [DataType(DataType.Text)]
        [Required, MaxLength(20)]
        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }


    }
}
