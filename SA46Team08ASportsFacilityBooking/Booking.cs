//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA46Team08ASportsFacilityBooking
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int BookingID { get; set; }
        public Nullable<int> MembershipNo { get; set; }
        public Nullable<int> FacilityID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Remark { get; set; }
        public Nullable<int> BookingStatus { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual Member Member { get; set; }
    }
}
