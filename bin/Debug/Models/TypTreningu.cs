namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypTreningu
    {

        public decimal ObliczSpaloneKcal(TypTreningu typTreningu, int wiek, int wzrost, int waga)
        {
            int serie = typTreningu.LiczbaSerii;
            int powtorzenia = typTreningu.LiczbaPowtorzen;

            decimal podsumowanie = (66.47m + (13.7m * waga) + (5 * wzrost) - (6.76m * wiek) + serie + powtorzenia);

            return podsumowanie;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypTreningu()
        {
            this.Trening = new HashSet<Trening>();
        }
    
        public int IdTypTreningu { get; set; }
        public string NazwaTypuTreningu { get; set; }
        public int LiczbaSerii { get; set; }
        public int LiczbaPowtorzen { get; set; }
        public string MetodaTreningowa { get; set; }
        public string AkcesoriaTreningowe { get; set; }
        public string MaszynyDoTreninguSilowego { get; set; }
        public string MaszynyCardio { get; set; }
        public string WyposazenieCardioFitness { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trening> Trening { get; set; }
    }
}
