using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NVHN_0461.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        
        public string UserName { get; set; } = null!;
        public string WalletId { get; set; } = null!;
        [ForeignKey("WalletId")]
        [InverseProperty("User")]
        public virtual Wallet Wallet { get; set; } = null!;
    }
}