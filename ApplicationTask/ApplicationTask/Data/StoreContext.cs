namespace ApplicationTask.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("StoreContext")
        {
        }

        public DbSet<Owner> Owner { get; set; }

        public DbSet<Models> Models { get; set; }

        public DbSet<OwnersModels> OwnerModels { get; set; }
    }

}