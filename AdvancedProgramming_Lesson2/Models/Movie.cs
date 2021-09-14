using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Movie
    {

        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(ResourceType =typeof(Resources.SharedResource), Name = "Title")]

        public string Title { get; set; }

        [DataType(DataType.Date)]

        [Display(ResourceType =typeof(Resources.SharedResource),Name = "ReleaseDate")]
        public DateTime ReleaseDate { get; set; }

        [Display(ResourceType =typeof(Resources.SharedResource),Name = "Genre")]
        public string Genre { get; set; }

        [Display(ResourceType =typeof(Resources.SharedResource),Name = "Price")]
        public decimal Price { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Rating")]

        public string Rating { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Description")]

        public string Description { get; set; }
    }
}
