using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NVHN_0461.Models
{
    public class Wallet
    {
        [Key]
        public string WalletId { get; set; } = null!;
        public float  Money { get; set; }
        public int NameWallet { get; set; }
        public int UserId { get; set; }
        
        
         [InverseProperty("Wallet")]
        public virtual ICollection<User> Posts { get; set; } = new List<User>();
    }
}