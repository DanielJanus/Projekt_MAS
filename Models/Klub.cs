namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klub
    {
        public void DodajWyposazenie(MaszynyWKlubie maszynyWKlubie)
        {
            if (!MaszynyWKlubie.Contains(maszynyWKlubie))
                if (MaszynyWKlubie.Contains(maszynyWKlubie))
                {
                    throw new Exception("To wyposa¿enie zosta³o ju¿ dodane do klubu");
                }

            MaszynyWKlubie.Add(maszynyWKlubie);
            maszynyWKlubie.setClub(this);
            MaszynyWKlubie.Add(maszynyWKlubie);
        }
        public void UsunWyposazenie(MaszynyWKlubie maszynyWKlubie)
        {
            if (MaszynyWKlubie.Contains(maszynyWKlubie))
            {

                MaszynyWKlubie.Remove(maszynyWKlubie);
                maszynyWKlubie.setClub(this);
                maszynyWKlubie.UsunKlub(this);
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klub()
        {
            this.MaszynyWKlubie = new HashSet<MaszynyWKlubie>();
            this.TreningKlub = new HashSet<TreningKlub>();
        }
    
        public int IdKlub { get; set; }
        public string NazwaKlubu { get; set; }
        public string Adres { get; set; }
        public string TelefonSluzbowy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaszynyWKlubie> MaszynyWKlubie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreningKlub> TreningKlub { get; set; }
    }
}
