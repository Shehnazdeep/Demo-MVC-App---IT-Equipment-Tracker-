using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment_1.Models
{
    public class EquipmentRequest
    {


        [Required]
        public string Name { get; set; }

      [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

       [Required]

        public string Role { get; set; }


      [Required]
        public string RequestDetails { get; set; }

        [Required]
        public int Duration { get; set; }

    
          public enum EquipmentType
        {
            Laptop,
            Phone,
            Tablet,
            Another
        }

        [Required]
         public EquipmentType EquipmentSelected { get; set; }
    }
}