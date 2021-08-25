using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TrainerUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania danych Trenera
    public partial class TrainerUpdateForm : Window
    {
        MASDBEntities db = new MASDBEntities();

        public TrainerUpdateForm()
        {
            InitializeComponent();
        }
        //Zaktualizowanie Trenera
        private void UpdateTrainer(object sender, RoutedEventArgs e)
        {
            var IdTrainer = (int.Parse(txtIdTreneraUpdate.Text));
            var IdEmployee = (int.Parse(txtIdPracownikUpdate.Text));

            //Wyszukiwanie trenera
            var query = from t in db.Trener where t.IdTrener == IdTrainer && t.Pracownik_IdPracownik == IdEmployee select t;

            foreach (Trener trener in query)
            {
                trener.OferowaneTreningi = txtOferowaneTreningiUpdate.Text;
                trener.PrawoWykonywaniaZawodu = bool.Parse(txtPrawoUpdate.Text);
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano trenera");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }
        //Powrót do poprzedniej strony
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
