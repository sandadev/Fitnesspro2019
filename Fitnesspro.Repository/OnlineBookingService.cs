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
    
    public partial class OnlineBookingService
    {
        public int BookingId { get; set; }
        public Nullable<bool> EnableOnlineBooking { get; set; }
        public string Description { get; set; }
        public Nullable<int> ServiceAvailableFor { get; set; }
        public Nullable<int> ServiceId { get; set; }
    
        public virtual Service Service { get; set; }
    }
}
