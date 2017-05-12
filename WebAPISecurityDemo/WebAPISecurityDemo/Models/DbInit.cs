using System.Collections.Generic;
using System.Data.Entity;

namespace WebAPISecurityDemo.Models
{
    internal class DbInit : DropCreateDatabaseAlways<ApplicationDbContext>
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
                new Employee() { FirstName = "Michael", LastName = "Tucker" },
                new Employee() { FirstName = "Morgan", LastName = "Grimes" },
                new Employee() { FirstName = "Emmett", LastName = "Milbarge" },
                new Employee() { FirstName = "Harry", LastName = "Tang" },
                new Employee() { FirstName = "Diane", LastName = "Beckman" },
                new Employee() { FirstName = "John", LastName = "Casey" },
                new Employee() { FirstName = "Fernando" },
                new Employee() { FirstName = "Bunny" },
                new Employee() { FirstName = "Chuck", LastName = "Bartowski" },
                new Employee() { FirstName = "Jeffrey", LastName = "Barnes" },
                new Employee() { FirstName = "Lester", LastName = "Patel" },
                new Employee() { FirstName = "Skip", LastName = "Johnson" },
                new Employee() { FirstName = "Anna", LastName = "Wu" },
                new Employee() { FirstName = "Hannah" },
                new Employee() { FirstName = "Greta" },
                new Employee() { FirstName = "Rick", LastName = "Noble" },
                new Employee() { FirstName = "Victoria", LastName = "Dunwoody" },
                new Employee() { FirstName = "Moses", LastName = "Finkelstein" },
                new Employee() { FirstName = "Porter", LastName = "Bauer" },
                new Employee() { FirstName = "Marvin", LastName = "Gadsby" },
                new Employee() { FirstName = "Cecil", LastName = "Goldenberg" },
                new Employee() { FirstName = "Christina", LastName = "James" },
                new Employee() { FirstName = "Ruben", LastName = "Mango" },
                new Employee() { FirstName = "Sal", LastName = "Sawaya" },
                new Employee() { FirstName = "Skye", LastName = "Stoinitz" },
                new Employee() { FirstName = "Leticia", LastName = "Williams" },
                new Employee() { FirstName = "Sarah", LastName = "Yang"}
        });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}