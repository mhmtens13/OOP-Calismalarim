//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fırın
    {
        public int FırınID { get; set; }
        public string Markasi { get; set; }
        public string Modeli { get; set; }
        public string TahminiFiyatAraligi { get; set; }
        public string FirinTipi { get; set; }
        public Nullable<int> FonksiyonSayisi { get; set; }
        public string EnerjiTuketimSinifi { get; set; }
        public string Yukseklik { get; set; }
        public string Genislik { get; set; }
        public string Hacim { get; set; }
        public Nullable<int> BeyazEsyaID { get; set; }
    
        public virtual BeyazEsya BeyazEsya { get; set; }
    }
}
