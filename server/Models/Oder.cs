﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace server.Models
{
    [Table("Oder")]
    public class Oder
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime OderAt { get; set; }
        [Required]
        public DateTime PaidAt { get; set; }
        [Required]
        [Range(0, Double.MaxValue)]
        public double Total_money { get; set; }
        [Required]
        [Range (0,Double.MaxValue)]
        public double Paid { get; set; }
        [Range(0, Double.MaxValue)]
        public double Change { get; set;}
        [Required]
        public string SellerId { get; set; }
        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
        public ApplicationUser Seller { get; set; }
        public ICollection<OderItem> oderItems { get; set; }
    }
}