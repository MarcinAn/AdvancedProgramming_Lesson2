using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Books
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "ClientNumber")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseEnterACustomerNumber")]
        [StringLength(5, MinimumLength = 5, ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "TheCustomerNumberShouldConsistOf5Digits")]
        [RegularExpression(@"[0-9]{5}", ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "TheCustomerNumberShouldConsistOf5Digits")]
        public string CustomerID { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Title")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseInsertTitle")]
        public string Title { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Author")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseEnterTheAuthor")]
        public string Author { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "DateOfBorrow")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseEnterTheBorrowDate")]
        [DataType(DataType.Date)]
        public DateTime BorrowDate { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "DateOfReturn")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseEnterTheReturnDate")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Copies")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "EnterTheNumberOfCopiesMaximum5")]
        [Range(minimum: 1, maximum: 5, ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "AMaximumOf5CopiesCanBeBorrowed")]
        public int BooksAmount { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "Email")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseInsertEmailAddress")]
        public string Email { get; set; }

        [Display(ResourceType = typeof(Resources.SharedResource), Name = "PhoneNumber")]
        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource), ErrorMessageResourceName = "PleaseInsertPhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
