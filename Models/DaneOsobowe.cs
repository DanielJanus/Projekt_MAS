namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DaneOsobowe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaneOsobowe()
        {
            this.Klient = new HashSet<Klient>();
            this.Pracownik = new HashSet<Pracownik>();
        }
    
        public int IdDaneOsobowe { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public System.DateTime DataUrodzenia { get; set; }
        public string AdresEmail { get; set; }
        public string TelefonKontaktowy { get; set; }
        public string AdresZamieszkania { get; set; }
        public decimal PESEL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Klient> Klient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownik> Pracownik { get; set; }
    }
}
