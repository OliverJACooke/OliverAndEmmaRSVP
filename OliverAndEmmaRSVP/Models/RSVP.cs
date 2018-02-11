using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OliverAndEmmaRSVP.Models
{
    public class RSVP
    {
        [Required(ErrorMessage = "Number of guests is required")]
        [Range(1, 5)]
        public int NumberOfGuests { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "E-Mail is required")]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
        public string Questions { get; set; }
    }
}