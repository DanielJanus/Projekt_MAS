namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recepcjonista
    {
        public decimal GetWyngarodzenie(decimal IndywidualnaStawkaGodzinowa, decimal LiczbaGodzinPrzepracowanych, decimal premia)
        {
            return (IndywidualnaStawkaGodzinowa * LiczbaGodzinPrzepracowanych) + premia + (IloscWykonanychRezerwacji * 100);
        }
        public void ZarezerwujTrening(Trening workout)
        {
            if (workout.Rezerwacja == true)
            {
                Console.WriteLine("Trening ju¿ by³ zarezerwowany");
            }
            else
            {
                workout.Rezerwacja = true;
                Console.WriteLine("Trening zosta³ zarezerwowany");
                IloscWykonanychRezerwacji++;
            }
        }
        public void ZarezerwujTrening(Trener trainer, Trening workout)
        {
            if (workout.Rezerwacja == true)
            {
                Console.WriteLine("Trening ju¿ by³ zarezerwowany");
            }
            else
            {
                workout.Trener = trainer;
                workout.Rezerwacja = true;
                Console.WriteLine("Trening zosta³ zarezerwowany");
                IloscWykonanychRezerwacji++;
            }
        }

        public void OdwolajTrening(Trening removeWorkout)
        {
            if (workouts.Contains(removeWorkout))
            {
                workouts.Remove(removeWorkout);

                removeWorkout.setReceptionist(this);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recepcjonista()
        {
            this.Trening = new HashSet<Trening>();
        }
    
        public int IdRecepcjonista { get; set; }
        public int Pracownik_IdPracownik { get; set; }
        public int IloscWykonanychRezerwacji { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trening> Trening { get; set; }

        private List<Trening> workouts = new List<Trening>() { };

    }
}
