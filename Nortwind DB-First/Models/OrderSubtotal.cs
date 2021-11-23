using System;
using System.Collections.Generic;

#nullable disable

namespace Nortwind_DB_First.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
