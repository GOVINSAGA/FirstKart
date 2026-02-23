using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.Models
{
    public class PurchaseDetail
    {
        [Key]
        public long PurchaseId { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public short QuantityPurchased { get; set; }

        [ForeignKey("User")]
        public string EmailId { get; set; }

        public User User { get; set; }

        [ForeignKey("Product")]
        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}
