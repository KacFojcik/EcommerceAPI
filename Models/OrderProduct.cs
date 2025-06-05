﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApi.Models
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal UnitPrice { get; set; }

    }
}
