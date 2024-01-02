using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NVHN_0461.Models;

namespace NVHN_0461.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options): base(options)
        {} 
        public DbSet<Wallet> Wallets { get; set; }
        
        
    }
}