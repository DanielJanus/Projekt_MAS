using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TrainingTypeUpdate.xaml
    /// </summary>
    // Formularz aktualizowania Formularz typu treningowego
    public partial class TrainingTypeUpdate : Window
    {
        MASDBEntities db = new MASDBEntities();

        public TrainingTypeUpdate()
        {
            InitializeComponent();
        }
        //Powrót do poprzedniego widoku
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Dodanie typu treningowego
        private void AddTrainingType(object sender, RoutedEventArgs e)
        {
            var num = (int.Parse(txtIdTypTreninguUpdate.Text));

            var query = from t in db.TypTreningu where t.IdTypTreningu == num select t;
            //Pobieranie informacji oraz zmiana
            foreach (TypTreningu typ in query)
            {
                typ.IdTypTreningu = int.Parse(txtIdTypTreninguUpdate.Text);
                typ.NazwaTypuTreningu = txtNazwaTypuUpdate.Text;
                typ.LiczbaSerii = int.Parse(txtLiczbaSeriiUpdate.Text);
                typ.LiczbaPowtorzen = int.Parse(txtLiczbaPowtorzenUpdate.Text);
                typ.MetodaTreningowa = txtMetodaTreningowaUpdate.Text;
                typ.AkcesoriaTreningowe = txtAkcesoriaTreningoweUpdate.Text;
                typ.MaszynyDoTreninguSilowego = txtMaszynySiloweUpdate.Text;
                typ.MaszynyCardio = txtMaszynyCardioUpdate.Text;
                typ.WyposazenieCardioFitness = txtWyposazenieCardioFitnessUpdate.Text;
            }
            //Próba zapisu
            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano typ treningu");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }
    }
}
