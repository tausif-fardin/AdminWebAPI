//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdInfo
    {
        public int AdId { get; set; }
        public string AdName { get; set; }
        public string AdType { get; set; }
        public double AdBudget { get; set; }
        public string ContactInfo { get; set; }
        public int advertiserid { get; set; }
    
        public virtual Advertiser Advertiser { get; set; }
    }
}