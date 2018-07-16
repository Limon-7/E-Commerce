//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LimonSelling.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ProductComment
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="Product")]
        public int productId { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public int userId { get; set; }
        
        [Display(Name = "Date")]
        public Nullable<System.DateTime> dateTime { get; set; }
        [Required]
        [Display(Name ="Review")]
        public string comment { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
