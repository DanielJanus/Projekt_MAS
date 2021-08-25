namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trener
    {
        public decimal GetWyngarodzenie(decimal IndywidualnaStawkaGodzinowa, decimal LiczbaGodzinPrzepracowanych, decimal premia)
        {
            return (IndywidualnaStawkaGodzinowa * LiczbaGodzinPrzepracowanych) + premia;
        }

        public static string ObnizWynagrodzenie(decimal Value)
        {
            foreach (Trener p in Trainers)
            {
                p.Pracownik.IndywidualnaStawkaGodzinowa -= Value;
            }
            return Value.ToString();
        }

        public void PrzeprowadzTrening(Trener trainer, Trening workout)
        {
            if (workout.Rezerwacja == false)
            {
                workout.Rezerwacja = true;
                workout.Trener_IdTrener = trainer.IdTrener;
            }
            else
            {
                workout.Trener = trainer;
            }
        }
        public void OdwolajTrening(Trening removeWorkout)
        {
            if (workouts.Contains(removeWorkout))
            {
                workouts.Remove(removeWorkout);

                removeWorkout.setTrainer(this);
            }
        }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trener()
        {
            this.Trening = new HashSet<Trening>();
        }
    
        public int IdTrener { get; set; }
        public int Pracownik_IdPracownik { get; set; }
        public string OferowaneTreningi { get; set; }
        public bool PrawoWykonywaniaZawodu { get; set; }
        public bool ZaswiadczenieONiekaralnosci { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trening> Trening { get; set; }

        private static List<Trener> Trainers = new List<Trener>() { };

        private List<Trening> workouts = new List<Trening>() { };
    }
}
