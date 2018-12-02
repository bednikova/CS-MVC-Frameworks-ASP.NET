using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveTesting.Models
{
    public class Mouse
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int Dpi { get; set; }

        public int NumberOfButtons { get; set; }
    }
}