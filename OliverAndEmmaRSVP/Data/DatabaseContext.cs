using System;
using System.Data.Entity;

namespace OliverAndEmmaRSVP
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("OliverAndEmma") {
            Database.SetInitializer<DatabaseContext>(new CreateDatabaseIfNotExists<DatabaseContext>());
        }

        public DbSet<Data.Entity.RSVPEntity> RSVP { get; set; }
    }
}
