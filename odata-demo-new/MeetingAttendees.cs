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
    
    public partial class MeetingAttendees
    {
        public int AttendeeId { get; set; }
        public int MeetingId { get; set; }
        public int ContactId { get; set; }
        public int AttendeeType { get; set; }
        public int AttendanceStatus { get; set; }
    
        public virtual Contacts Contacts { get; set; }
        public virtual Meetings Meetings { get; set; }
    }
}
