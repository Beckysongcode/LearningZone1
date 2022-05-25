using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace s4587831Milestone3.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Course Course { get; set; }
        public int Amount { get; set; }


        public string ShoppingCartId { get; set; }
    }
}
