//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Depo_Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sektor
    {
        public Sektor()
        {
            this.Teslimats = new HashSet<Teslimat>();
        }
    
        public int sektorno { get; set; }
        public string sektoradi { get; set; }
        public string sektorfaaliyetyil { get; set; }
        public string sektoraciklama { get; set; }
        public Nullable<int> malzemeno { get; set; }
    
        public virtual Malzeme Malzeme { get; set; }
        public virtual ICollection<Teslimat> Teslimats { get; set; }
    }
}