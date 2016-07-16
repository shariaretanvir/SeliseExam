using System.Collections.Generic;
using BusinessLayer;

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.ContactContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.ContactContext context)
        {
            GetContact().ForEach(c => context.Contacts.Add(c));
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        private List<Contact> GetContact()
        {
            return new List<Contact>
            {
                new Contact
                {
                    Name = "Akash",
                    Phone = "01233333333",
                    Email = "akash@yahoo.com",
                    Company = "Redlime Solutions",
                    Title = "Software Eng",
                    House = "122A",
                    Street = "2",
                    PoBox = "Gulshan",
                    City = "Dhaka",
                    Zip ="1000"
                },new Contact
                {
                    Name = "Lalana",
                    Phone = "01233333333",
                    Email = "akash@yahoo.com",
                    Company = "Redlime Solutions",
                    Title = "Software Eng",
                    House = "122A",
                    Street = "2",
                    PoBox = "Gulshan",
                    City = "Dhaka",
                    Zip ="1000"
                },
                new Contact
                {
                    Name = "Pogba",
                    Phone = "01233333333",
                    Email = "akash@yahoo.com",
                    Company = "Redlime Solutions",
                    Title = "Software Eng",
                    House = "122A",
                    Street = "2",
                    PoBox = "Gulshan",
                    City = "Dhaka",
                    Zip ="1000"
                },
                new Contact
                {
                    Name = "Messi",
                    Phone = "01233333333",
                    Email = "akash@yahoo.com",
                    Company = "Redlime Solutions",
                    Title = "Software Eng",
                    House = "122A",
                    Street = "2",
                    PoBox = "Gulshan",
                    City = "Dhaka",
                    Zip ="1000"
                },
                new Contact
                {
                    Name = "Akram",
                    Phone = "01233333333",
                    Email = "akash@yahoo.com",
                    Company = "Redlime Solutions",
                    Title = "Software Eng",
                    House = "122A",
                    Street = "2",
                    PoBox = "Gulshan",
                    City = "Dhaka",
                    Zip ="1000"
                },
                new Contact
                {
                    Name = "Ronaldo",
                    Phone = "01233333333",
                    Email = "akash@yahoo.com",
                    Company = "Redlime Solutions",
                    Title = "Software Eng",
                    House = "122A",
                    Street = "2",
                    PoBox = "Gulshan",
                    City = "Dhaka",
                    Zip ="1000"
                },
                new Contact
                {
                    Name = "Karim",
                    Phone = "01233333333",
                    Email = "akash@yahoo.com",
                    Company = "Redlime Solutions",
                    Title = "Software Eng",
                    House = "122A",
                    Street = "2",
                    PoBox = "Gulshan",
                    City = "Dhaka",
                    Zip ="1000"
                }

            };
        }
    }
}
