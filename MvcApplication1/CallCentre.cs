//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class CallCentre
    {
        public CallCentre()
        {
            this.Ambulances = new HashSet<Ambulance>();
            this.Hospitals = new HashSet<Hospital>();
        }
    
        public int CallCentreID { get; set; }
        public System.Data.Spatial.DbGeometry lat { get; set; }
        public System.Data.Spatial.DbGeometry lon { get; set; }
    
        public virtual ICollection<Ambulance> Ambulances { get; set; }
        public virtual ICollection<Hospital> Hospitals { get; set; }
    }
}