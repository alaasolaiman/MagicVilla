using MagicVilla_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace MagicVilla_WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new List<Villa>() {
                new Villa()
                {
                    Id = 1,
                    Name = "Luxury Villa",
                    Details = "A stunning luxury villa with breathtaking views.",
                    Rate = 500.00,
                    Sqft = 3000,
                    Occupancy = 8,
                    ImageUrl = "https://example.com/luxury-villa.jpg",
                    Amenity = "Private Pool, Wi-Fi, Air Conditioning",
                    CreatedDate = DateTime.Now,
                },
                new Villa
                {
                    Id = 2,
                    Name = "Seaside Retreat",
                    Details = "A cozy villa by the beach, perfect for a relaxing getaway.",
                    Rate = 300.00, 
                    Sqft = 2000,   
                    Occupancy = 6, 
                    ImageUrl = "https://example.com/seaside-villa.jpg", 
                    Amenity = "Beach Access, BBQ Area, Ocean View",
                    CreatedDate = DateTime.Now,

                }
        }
                );
        }
    }
}

