//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iHotel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomFacility
    {
        public int id { get; set; }
        public int room_id { get; set; }
        public int facility_id { get; set; }
        public bool deleted { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual Room Room { get; set; }
    }
}