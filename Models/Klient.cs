namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klient
    {
        public void addPassQualification(Karnet newPass)
        {
            if (!passQualified.ContainsKey(newPass.NumerKarnetu))
            {
                if (passes.Contains(newPass))
                {
                    throw new Exception("Karnet o takim numerze zosta³ ju¿ przydzielony");
                }
                passQualified.Add(newPass.NumerKarnetu, newPass);
                newPass.setClient(this);
                passes.Add(newPass);
            }
        }

        public void RemovePass(Karnet removePass)
        {
            if (passQualified.ContainsKey(removePass.NumerKarnetu))
            {
                passQualified.Remove(removePass.NumerKarnetu);

                removePass.setClient(this);
            }
        }

        public void removePassQualification(Karnet pass)
        {
            if (passQualified.ContainsKey(pass.NumerKarnetu))
            {
                passQualified.Remove(pass.NumerKarnetu);
            }
        }

        public void findPassQualification(int PassNumber)
        {
            if (passQualified.ContainsKey(PassNumber))
            {
                Console.WriteLine("Znaleziono karnet o numerze " + PassNumber);
            }
            else
            {
                throw new Exception("Nie znaleziono karneta o podanym numerze");
            }

        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klient()
        {
            this.Karnet = new HashSet<Karnet>();
        }
    
        public int IdKlient { get; set; }
        public int DaneOsobowe_IdDaneOsobowe { get; set; }
        public string RodzajDokumentuOsobistego { get; set; }
        public bool ZaswiadczenieOdLekarza { get; set; }
        public bool ZgodaDotyczacaRegulaminuKlubu { get; set; }
    
        public virtual DaneOsobowe DaneOsobowe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Karnet> Karnet { get; set; }

        private Dictionary<int, Karnet> passQualified = new Dictionary<int, Karnet>();
        private Dictionary<int, Karnet> checkPassQualified = new Dictionary<int, Karnet>();
        private static List<Karnet> passes = new List<Karnet>() { };

    }
}
