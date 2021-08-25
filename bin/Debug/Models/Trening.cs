namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trening
    {
        internal void setTrainer(Trener trener)
        {
            this.Trener = trener;
        }
        internal void setReceptionist(Recepcjonista recepcjonista)
        {
            this.Recepcjonista = recepcjonista;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trening()
        {
            this.TreningKlub = new HashSet<TreningKlub>();
        }
    
        public int IdTrening { get; set; }
        public int TypTreningu_IdTypTreningu { get; set; }
        public int Trener_IdTrener { get; set; }
        public Nullable<int> Recepcjonista_IdRecepcjonista { get; set; }
        public string Nazwa { get; set; }
        public string Rodzaj { get; set; }
        public Nullable<bool> Rezerwacja { get; set; }
    
        public virtual Recepcjonista Recepcjonista { get; set; }
        public virtual Trener Trener { get; set; }
        public virtual TypTreningu TypTreningu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreningKlub> TreningKlub { get; set; }

    }
}
