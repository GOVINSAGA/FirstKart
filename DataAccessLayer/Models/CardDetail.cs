using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Models
{
    public class CardDetail
    {
        [Key]
        public string CardNumber { get; set; }

        public decimal Balance { get; set; }

        public string CardType { get; set; }

        public decimal CVVNumber { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string NameOnCard { get; set; }
    }
}
