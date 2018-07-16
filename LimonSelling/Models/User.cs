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

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.ProductComments = new HashSet<ProductComment>();
            this.Orders = new HashSet<Order>();
            this.wishlists = new HashSet<wishlist>();
        }
    
        public int id { get; set; }
        [Required]
        [Display(Name ="Customer Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Mobile")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone Number Must Be Numeric")]
        public string contact { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        
        [Display(Name = "Date")]
        public Nullable<System.DateTime> createDate { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public int genderId { get; set; }
        
        [Display(Name = "Type")]
        public string type { get; set; }
        [Required]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string address { get; set; }
        [Required]
         [Display(Name ="City")]
        public int cityId { get; set; }
    
        public virtual City City { get; set; }
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductComment> ProductComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wishlist> wishlists { get; set; }
    }
}