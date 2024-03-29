﻿

namespace shop1.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]

        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get;
            set; }

        [Display(Name = "Last Purchase")]
        public DateTime LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime LastSale { get; set; }

        [Display(Name = "Is Aviable?")]
        public bool IsAviable { get; set; }

        [DisplayFormat(DataFormatString ="{0:N2}", ApplyFormatInEditMode =false)]

        public double Stook { get; set; }


    }
}
