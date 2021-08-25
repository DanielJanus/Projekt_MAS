using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TrainingInClubUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania treningu w klubie
    public partial class TrainingInClubUpdateForm : Window
    {
        //Łączenie się z modelami
        MASDBEntities db = new MASDBEntities();

        public TrainingInClubUpdateForm()
        {
            InitializeComponent();
        }
        //Aktualizowanie treningu w klubie
        private void UpdateTrainingInClub(object sender, RoutedEventArgs e)
        {
            var trainingId = (int.Parse(txtIdTreningUpdate.Text));
            var clubId = (int.Parse(txtIdKlubuUpdate.Text));
            //Zapytanie szukające  konkretego treningu w klubie
            var query = from t in db.TreningKlub where t.Trening_IdTrening == trainingId  && t.Klub_IdKlub == clubId select t;

            foreach (TreningKlub treningKlub in query)
            {
                treningKlub.DataTreningu = DateTime.Parse(txtDataUpdate.Text);
                treningKlub.DlugoscTreningu = decimal.Parse(txtDlugoscUpdate.Text);
                treningKlub.Cena = decimal.Parse(txtCenaUpdate.Text);
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano trening w klubie");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }
        //Powrót do poprzedniego widoku
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
