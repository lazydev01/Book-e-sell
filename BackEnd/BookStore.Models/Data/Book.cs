using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models.Data
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Base64image { get; set; }
        public int Categoryid { get; set; }

        public virtual Category Category { get; set; }
    }
}
