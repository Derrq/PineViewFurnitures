//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G1_PVFAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUPPLy
    {
        public string VendorID { get; set; }
        public string MaterialID { get; set; }
        public string SupplyUnitPrice { get; set; }
        public string SupplyID { get; set; }
    
        public virtual RAWMATERIAL RAWMATERIAL { get; set; }
        public virtual VENDOR VENDOR { get; set; }
    }
}
