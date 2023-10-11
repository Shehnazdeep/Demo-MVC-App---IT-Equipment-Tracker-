using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment_1.Models
{
    public class EquipmentRequest
    {


      public int Id {get; set;}

      public bool Availability { get; set; }

        [Required (ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

      [Required (ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required (ErrorMessage = "Please enter your phone number")]
        [Phone]
        public string PhoneNumber { get; set; }

       [Required (ErrorMessage = "Please enter your role.")]

        public string Role { get; set; }


      [Required (ErrorMessage = "Please enter the request details")]
        public string RequestDetails { get; set; }

        [Required (ErrorMessage = "Please enter the duration of days the equipment is required.")] 
        public int Duration { get; set; }

    
          public enum EquipmentType
        {
            Laptop,
            Phone,
            Tablet,
            Another
        }

        [Required (ErrorMessage = "Please select the equipment type")] 
         public EquipmentType EquipmentSelected { get; set; }
    }
}