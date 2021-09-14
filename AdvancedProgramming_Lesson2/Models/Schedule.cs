using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Subject")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseEnterTheNameOfTheSubject")]
        public string Subject { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Lecturer")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseEnterFirstAndLastName")]
        public string Lecturer { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "StartDate")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseEnterADate")]
        [DataType(DataType.DateTime)]
        public DateTime StartSubjectDate { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "EndDate")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseEnterADate")]
        [DataType(DataType.DateTime)]
        public DateTime EndSubjectDate { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "TypeOfSubject")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseSelectTheTypeOfSubject")]
        [EnumDataType(typeof(Types))]
        public Types Type { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Description")]
        public string Description { get; set; }


        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Email")]
        public string Email { get; set; }
    }
    public enum Types
    {
        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Lecture")]
        Lecture = 0,
        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Lab")]
        Lab =1,
        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Exercise")]
        Exercise = 2,
        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Conseratory")]
        Conseratory = 3
    }

}
