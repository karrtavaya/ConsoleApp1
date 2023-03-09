using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DB
{
    internal class GoodsContext : DbContext
    {
        public DbSet<Good> Goods { get; set; }
        public DbSet<Category> Categories { get; set; }
        private string _path = "goods.db";
        public GoodsContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_path}");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category(){ IdCategory = Guid.NewGuid(),
                    Name = "Овощи" },
                new Category() { IdCategory = Guid.NewGuid(),
                Name = "Фрукты"}
                );
            
            
        }
    }
}
