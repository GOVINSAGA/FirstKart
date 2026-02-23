using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.Models
{
    public class User
    {
        public User()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        [Key]
        public string EmailId { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string UserPassword { get; set; }

        [ForeignKey("Role")]
        public byte RoleId { get; set; }

        public Role Role { get; set; }

        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
