using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeAdminPortal.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeeDataFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Name", "Phone", "Salary" },
                values: new object[,]
                {
                    { new Guid("a1111111-b222-c333-d444-e55555555555"), "john.doe@gmail.com", "John Doe", null, 45000m },
                    { new Guid("c1111111-b222-c333-d444-e55555555555"), "bob.johnson@gmail.com", "Bob Johnson", null, 48000m },
                    { new Guid("d1111111-b222-c333-d444-e55555555555"), "clara.lee@gmail.com", "Clara Lee", null, 52000m },
                    { new Guid("e1111111-b222-c333-d444-e55555555555"), "david.brown@gmail.com", "David Brown", null, 47000m },
                    { new Guid("f1111111-b222-c333-d444-e55555555555"), "alice.smith@gmail.com", "Alice Smith", null, 50000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-b222-c333-d444-e55555555555"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c1111111-b222-c333-d444-e55555555555"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d1111111-b222-c333-d444-e55555555555"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e1111111-b222-c333-d444-e55555555555"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-b222-c333-d444-e55555555555"));
        }
    }
}
