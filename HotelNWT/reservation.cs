//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelNWT
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservation
    {
        public int idreservation { get; set; }
        public System.DateTime from_date { get; set; }
        public System.DateTime to_date { get; set; }
        public float price { get; set; }
        public sbyte status { get; set; }
        public Nullable<sbyte> type { get; set; }
        public int user_iduser { get; set; }
    
        public virtual user user { get; set; }
    }
}
