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
    
    public partial class TusluTelefon
    {
        public int TusluTelefonID { get; set; }
        public string Markasi { get; set; }
        public string Modeli { get; set; }
        public string CikisYili { get; set; }
        public string TahminiFiyatAraligi { get; set; }
        public string DahiliDepolama { get; set; }
        public string RAM { get; set; }
        public string EkranBoyutu { get; set; }
        public string BataryaKapasitesi { get; set; }
        public string ArkaKameraÇözünürlüğü { get; set; }
        public string ÖnKameraÇözünürlüğü { get; set; }
        public string İşlemci { get; set; }
        public string Ağırlık { get; set; }
        public Nullable<int> TelefonID { get; set; }
    
        public virtual Telefon Telefon { get; set; }
    }
}
