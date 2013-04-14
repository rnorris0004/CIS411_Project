using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CIS411_Project.Models
{
    public class Book
    {
        public int BOOK_ID { get; set; }

        public string BOOK_TITLE { get; set; }

        public string BOOK_DESC { get; set; }

        public string BOOK_AUTHOR { get; set; }

        [Range(1, 100)]
        public int BOOK_EDITION { get; set; }

        public string BOOK_PUBLISHER { get; set; }

        [MaxLength(10)]
        public int ISBN10 { get; set; }

        [MaxLength(13)]
        public int ISBN13 { get; set; }

        public int CONDITION_ID { get; set; }

        public int CATEGORY_ID { get; set; }

        public int USER_ID { get; set; }
    }
}