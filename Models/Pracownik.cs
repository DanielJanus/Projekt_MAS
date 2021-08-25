namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pracownik
    {
        public decimal GetWyngarodzenie(decimal IndywidualnaStawkaGodzinowa, decimal LiczbaGodzinPrzepracowanych, decimal premia)
        {
            return 0.0m;
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pracownik()
        {
            this.Instruktor = new HashSet<Instruktor>();
            this.Recepcjonista = new HashSet<Recepcjonista>();
            this.Trener = new HashSet<Trener>();
        }
    
        public int IdPracownik { get; set; }
        public int Umowa_IdUmowa { get; set; }
        public int DaneOsobowe_IdDaneOsobowe { get; set; }
        public decimal NumerKontaBankowego { get; set; }
        public decimal IndywidualnaStawkaGodzinowa { get; set; }
        public decimal LiczbaGodzinPrzepracowanych { get; set; }
        public decimal Pensja { get; set; }
    
        public virtual DaneOsobowe DaneOsobowe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instruktor> Instruktor { get; set; }
        public virtual Umowa Umowa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recepcjonista> Recepcjonista { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trener> Trener { get; set; }
    }
}
