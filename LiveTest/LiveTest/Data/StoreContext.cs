namespace LiveTest.Data
{
    using System;
    using System.Data.Entity;
    using LiveTest.Models;
    using System.Linq;

    public class StoreContext : DbContext
    {

        public StoreContext()
            : base("StoreContext")
        {
        }

       public DbSet<User> Users { get; set; }

       public DbSet<Game> Games { get; set;  }
    }


}