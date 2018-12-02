namespace LiveTesting.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("StoreContext")
        {
        }

        public DbSet<Mouse> Mice { get; set; }

       
    }

   
}