using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CIS411_Project.Models
{
    public class User
    {
        public int USER_ID { get; set; }

        [Required]
        public string USER_FNAME { get; set; }

        [Required]
        public string USER_LNAME { get; set; }

        [Range(1, 100000)]
        public decimal REPUTATION { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EMAIL { get; set; }
    }
}