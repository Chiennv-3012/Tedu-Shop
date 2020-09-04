﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail : Auditable
    {
        [Key]
        public int OrderId { set; get; }

        [Key]
        public int ProductId { set; get; }

        public int Quantity { set; get; }

        [ForeignKey("OrderId")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}