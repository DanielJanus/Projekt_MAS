namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Umowa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Umowa()
        {
            this.Pracownik = new HashSet<Pracownik>();
        }

        public int IdUmowa { get; set; }
        public string RodzajUmowy { get; set; }
        public System.DateTime DataRozpoczeciaUmowy { get; set; }
        public System.DateTime DataZakonczeniaUmowy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownik> Pracownik { get; set; }
    }
}
