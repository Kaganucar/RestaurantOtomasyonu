//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLProducts
    {
        public int id { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Images { get; set; }
        public string Contents { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> CategoriesId { get; set; }
    }
}