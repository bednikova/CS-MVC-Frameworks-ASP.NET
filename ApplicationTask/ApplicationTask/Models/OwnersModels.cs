using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationTask.Models
{
    public class OwnersModels
    {
        public OwnersModels()
        {
            this.Owner = new HashSet<Owner>();
            this.Models = new HashSet<Models>();
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Owner> Owner { get; set; }

        public virtual ICollection<Models> Models { get; set; }
    }
}