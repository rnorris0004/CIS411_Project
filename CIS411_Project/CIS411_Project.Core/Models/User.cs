using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS411_Project.Core.Models
{
    public class User
    {
        public int USER_ID { get; set; }

        public string USER_FNAME { get; set; }

        public string USER_LNAME { get; set; }

        public string USER_DISPLAYNAME { get; set; }

        public int REPUTATION { get; set; }

        public string EMAIL { get; set; }

        public DateTime CREATED_TIMESTAMP { get; set; }
    }
}