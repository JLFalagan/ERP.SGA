using ERP.SGA.Models.Products;
using ERP.SGA.Models.Vehicles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ERP.SGA.WinApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=SGADataBase;user=root;password=joseluis2024;");
            optionsBuilder.EnableSensitiveDataLogging(true);
            //this.ChangeTracker.LazyLoadingEnabled = false;
            optionsBuilder.UseLazyLoadingProxies(false);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Color> Color { get; set; }
        public DbSet<Cost> Cost { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<Shelf> Shelf { get; set; }
        public DbSet<TechnicalInformation> TechnicalInformation { get; set; }

        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleBrand> VehicleBrand { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }
    }
}
