using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveTest.Models
{
    public class User
    {
        public User()
        {
            this.Games = new HashSet<Game>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}