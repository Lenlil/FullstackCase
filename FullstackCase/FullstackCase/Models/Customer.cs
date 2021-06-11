using System;
using System.Collections.Generic;

#nullable disable

namespace FullstackCase.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
