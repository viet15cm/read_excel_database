﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ReadingExcel.Entitiy
{
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Code { get; set; }

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "{0} không được bỏ trống.")]
        public string Name { get; set; }

        public string UrlImage { get; set; }


        [Display(Name = "Giá vốn")]
        [Required(ErrorMessage = "{0} không được bỏ trống.")]
        public decimal CapitalPrice { get; set; }

        [Display(Name = "Giá bán")]
        [Required(ErrorMessage = "{0} không được bỏ trống.")]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public string CommodidyId { get; set; }

        [ForeignKey("CommodidyId")]
        public virtual Commodity Commodity { get; set; }

        public string CommodityGroupId { get; set; }

        [ForeignKey("CommodityGroupId")]
        public virtual CommodityGroup CommodityGroup { get; set; }

        public string HangHoa { get; set; }

        public string NhomHang { get; set; }

    }
}
