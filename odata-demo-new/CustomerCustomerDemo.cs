//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace odata_demo_new
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerCustomerDemo
    {
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerTypeID { get; set; }
    
        public virtual CustomerDemographics CustomerDemographics { get; set; }
        public virtual Customers Customers { get; set; }
    }
}