//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fitnesspro.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceSetting
    {
        public int SettingId { get; set; }
        public Nullable<int> ExtraTimeType { get; set; }
        public Nullable<int> DurationId { get; set; }
        public Nullable<int> Tax { get; set; }
        public Nullable<bool> EnableVoucherSale { get; set; }
        public Nullable<int> VoucherExpiryPeriod { get; set; }
        public Nullable<bool> EnableCommission { get; set; }
        public Nullable<int> ServiceId { get; set; }
    
        public virtual Service Service { get; set; }
    }
}
