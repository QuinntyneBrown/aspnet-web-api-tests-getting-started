namespace Chloe.Api.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chloe.Api.Data.ChloeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Chloe.Api.Data.ChloeContext context)
        {
            context.Employees.AddOrUpdate(e => e.FirstName, new Employee { FirstName = "Quinntyne", LastName = "Brown" });

            context.SaveChanges();
        }
    }
}
