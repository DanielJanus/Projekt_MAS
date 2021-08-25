namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TreningKlub
    {

        public decimal GetCena(decimal dlugoscTrening)
        {
            return dlugoscTrening * 3;
        }

        public int Trening_IdTrening { get; set; }
        public int Klub_IdKlub { get; set; }
        public System.DateTime DataTreningu { get; set; }
        public decimal DlugoscTreningu { get; set; }
        public decimal Cena { get; set; }
    
        public virtual Klub Klub { get; set; }
        public virtual Trening Trening { get; set; }
    }
}
