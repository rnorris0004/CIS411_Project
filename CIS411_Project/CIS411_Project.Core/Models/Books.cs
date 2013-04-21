using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS411_Project.Core.Models
{
    public class Books
    {
        public int BOOK_ID { get; set; }

        public string BOOK_TITLE { get; set; }

        public string BOOK_DESC { get; set; }

        public string BOOK_AUTHOR { get; set; }
   
        public Nullable<int> BOOK_EDITION { get; set; }

        public string BOOK_PUBLISHER { get; set; }
      
        public Nullable<decimal> ISBN10 { get; set; }
   
        public Nullable<decimal> ISBN13 { get; set; }

        public int CONDITION_ID { get; set; }

        public int CATEGORY_ID { get; set; }

        public int USER_ID { get; set; }

        public decimal BOOK_PRICE { get; set; }

        public DateTime CREATED_TIMESTAMP { get; set; }
        


    }
}