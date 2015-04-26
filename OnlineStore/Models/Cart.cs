using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public int ProductId { get; set; }
        public string CartId { get; set; }
        public virtual ProductModel Product { get; set; }
    }
}