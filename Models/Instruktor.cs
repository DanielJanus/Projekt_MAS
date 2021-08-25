namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Instruktor
    {
        public decimal GetWyngarodzenie(decimal IndywidualnaStawkaGodzinowa, decimal LiczbaGodzinPrzepracowanych, decimal premia)
        {
            return (IndywidualnaStawkaGodzinowa * LiczbaGodzinPrzepracowanych) + premia * Szkolenie.Count();
        }

        public void PrzeprowadzSzkolenie(Szkolenie szkolenie) {
            szkolenie.Instruktor_IdInstruktor = IdInstruktor;
        }
        public void OdwolajSzkolenie(Szkolenie szkolenie)
        {
            if (schoolings.Contains(szkolenie))
            {
                schoolings.Remove(szkolenie);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instruktor()
        {
            this.Szkolenie = new HashSet<Szkolenie>();
        }
    
        public int IdInstruktor { get; set; }
        public int Pracownik_IdPracownik { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szkolenie> Szkolenie { get; set; }

        private List<Szkolenie> schoolings = new List<Szkolenie>() { };

    }
}
