using System.ComponentModel.DataAnnotations;

namespace NVHN_0461.Models
{
    public class Wallet
    {
        [Key]
        public string WalletId { get; set; } = null!;
        public float  Money { get; set; }
        public int NameWallet { get; set; }
    }
}