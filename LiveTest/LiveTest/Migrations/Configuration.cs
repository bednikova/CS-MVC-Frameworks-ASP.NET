namespace LiveTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LiveTest.Models;
    using LiveTest.Controllers;
    using System.Dynamic;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<LiveTest.Data.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LiveTest.Data.StoreContext context)
        {
         //   context.Games.AddOrUpdate(pt => pt.Name, new Game[]  //List<Game>()
          //  {
            //    new Game()
              //  {
                //     Name = "Coffe",
                  //   Price = 400,
                    // Size = 32,
                //}           ,

               //new Game()
                //{
                  //   Name = "Daniii",
                    // Price = 400,
                     //Size = 32
                //}
            //});
        }
    }
}
