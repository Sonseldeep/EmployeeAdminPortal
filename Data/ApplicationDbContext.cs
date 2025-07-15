using EmployeeAdminPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = Guid.Parse("a1111111-b222-c333-d444-e55555555555"),
                Name = "John Doe",
                Email = "john.doe@gmail.com",
                Salary = 45000
            },
            new Employee
            {
                Id = Guid.Parse("f1111111-b222-c333-d444-e55555555555"),
                Name = "Alice Smith",
                Email = "alice.smith@gmail.com",
                Salary = 50000
            },
            new Employee
            {
                Id = Guid.Parse("c1111111-b222-c333-d444-e55555555555"),
                Name = "Bob Johnson",
                Email = "bob.johnson@gmail.com",
                Salary = 48000
            },
            new Employee
            {
                Id = Guid.Parse("d1111111-b222-c333-d444-e55555555555"),
                Name = "Clara Lee",
                Email = "clara.lee@gmail.com",
                Salary = 52000
            },
            new Employee
            {
                Id = Guid.Parse("e1111111-b222-c333-d444-e55555555555"),
                Name = "David Brown",
                Email = "david.brown@gmail.com",
                Salary = 47000
            }
        );

    }
}