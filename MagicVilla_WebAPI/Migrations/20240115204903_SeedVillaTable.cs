using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_WebAPI.Migrations
{
    public partial class SeedVillaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[] { 1, "Private Pool, Wi-Fi, Air Conditioning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stunning luxury villa with breathtaking views.", "https://example.com/luxury-villa.jpg", "Luxury Villa", 8, 500.0, 3000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[] { 2, "Beach Access, BBQ Area, Ocean View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A cozy villa by the beach, perfect for a relaxing getaway.", "https://example.com/seaside-villa.jpg", "Seaside Retreat", 6, 300.0, 2000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
