namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Karnet
    {
        public void setClient(Klient klient)
        {
            this.klient = klient;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Karnet()
        {
            this.Klient = new HashSet<Klient>();
        }
    
        public int NumerKarnetu { get; set; }
        public string RodzajKarnetu { get; set; }
        public string NazwaKarnetu { get; set; }

        public Klient klient { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Klient> Klient { get; set; }

    }
}
