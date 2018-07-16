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

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int id { get; set; }
        [Display(Name = "Order Date")]
        public Nullable<System.DateTime> dateTime { get; set; }
        [Required(ErrorMessage ="Enter Mobile Number")]
        [Display(Name ="Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        public string number { get; set; }
        public int userId { get; set; }
        [Required(ErrorMessage = "Enter Delivery Address")]
        [Display(Name = "Delivery Charge")]
        [DataType(DataType.MultilineText)]
        public Nullable<double> deliveryCharge { get; set; }
        [Display(Name = "Other Charge")]
        public Nullable<double> otherCharge { get; set; }
        [Display(Name = "Total")]
        public Nullable<double> total { get; set; }
        [Required]
        [Display(Name = "Payment Method")]
        public Nullable<int> paymentMethodId { get; set; }
        [Required(ErrorMessage = "Enter Delivery Address")]
        [Display(Name = "Delivery Address")]
        public string deliveryAddress { get; set; }
         [Required]
        [Display(Name = "City")]
        public int cityId { get; set; }
        [Display(Name = "Status")]
        public string status { get; set; }
    
        public virtual City City { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}