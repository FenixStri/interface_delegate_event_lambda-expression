using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3033_1_HW3_.Data
{
    public class DBCon:DbContext
    {
        public DbSet<Receipt> receipts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=E:\Visual 2022\3033_1_HW3_\3033_1_HW3_\receipts.db");
        }
    }
}
