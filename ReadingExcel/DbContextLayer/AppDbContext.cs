using Microsoft.EntityFrameworkCore;
using ReadingExcel.Entitiy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingExcel.DbContextLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Commodity> Commodities { get; set; }

        public DbSet<CommodityGroup> CommodityGroups { get; set; }

        //Server=DESKTOP-40F80LR\SQLEXPRESS;Database=GOPH;Trusted_Connection=True;Trustservercertificate=True;MultipleActiveResultSets=true;Encrypt=False;
        //Server=DESKTOP-40F80LR\SQLEXPRESS;Database=readingexcel;Trusted_Connection=True;Trustservercertificate=True;MultipleActiveResultSets=true;Encrypt=False;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-40F80LR\SQLEXPRESS;Database=GOPH;Trusted_Connection=True;Trustservercertificate=True;MultipleActiveResultSets=true;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


      
        
    }

 
}
