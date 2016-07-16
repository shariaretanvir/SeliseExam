using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataAccessLayer
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("name = SchoolDBConnectionString")
        {
            Database.SetInitializer<ContactContext>(new DropCreateDatabaseIfModelChanges<ContactContext>());
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
