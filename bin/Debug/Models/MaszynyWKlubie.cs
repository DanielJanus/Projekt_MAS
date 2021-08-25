namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaszynyWKlubie
    {
        internal void setClub(Klub klub)
        {
            this.Klub = klub;
        }

        internal void UsunKlub(Klub klub)
        {
            if (klub.NazwaKlubu == Klub.NazwaKlubu)
            {
                klub.UsunWyposazenie(this);
                klub = null;
            }
        }
        public void PrzeprowadzSeries(DateTime dateTime)
        {
            OstatniaDataKonserwacji = ZaplanowanaDataKonserwacji;
            ZaplanowanaDataKonserwacji = dateTime;
        }

        public int NumerIdentyfikacyjny { get; set; }
        public int Klub_IdKlub { get; set; }
        public string Nazwa { get; set; }
        public string Zastosowanie { get; set; }
        public System.DateTime OstatniaDataKonserwacji { get; set; }

        public System.DateTime ZaplanowanaDataKonserwacji { get; set; }
    
        public virtual Klub Klub { get; set; }


    }
}
