using System.Collections.Generic;
using System.Data.Entity;

namespace WebAPISecurityDemo.Models
{
    internal class DbInit : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Employees.AddRange(new List<Employee>() {
                new Employee() { FirstName = "Scooby", LastName = "Doo" },
                new Employee() { FirstName = "Scrappy", LastName = "Doo" },
                new Employee() { FirstName = "Shaggy", LastName = "Rogers" },
                new Employee() { FirstName = "Fred", LastName = "Jones" },
                new Employee() { FirstName = "Daphne", LastName = "Blake" },
                new Employee() { FirstName = "Velma", LastName = "Dinkley" },
                new Employee() { FirstName = "Fred", LastName = "Flinstone" },
                new Employee() { FirstName = "Wilma", LastName = "Flinstone" },
                new Employee() { FirstName = "Barney", LastName = "Rubble" },
                new Employee() { FirstName = "Betty", LastName = "Rubble" },
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}