using System;
using System.Collections.Generic;

#nullable disable

namespace Nortwind_DB_First.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
