using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy SchoolingUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania Szkolenia
    public partial class SchoolingUpdateForm : Window
    {
        MASDBEntities db = new MASDBEntities();

        public SchoolingUpdateForm()
        {
            InitializeComponent();
        }
        //Metoda główna aktualizowania
        private void UpdateSchooling(object sender, RoutedEventArgs e)
        {
            var num = (int.Parse(txtIdSzkoleniaUpdate.Text));
            var query = from t in db.Szkolenie where t.IdSzkolenie == num select t;

            //Dla każdego szkolenia w zapytaniu 
            foreach (Szkolenie szkolenie in query)
            {
                szkolenie.Instruktor_IdInstruktor = int.Parse(txtIdInstruktoraUpdate.Text);
                szkolenie.Nazwa = txtNazwaUpdate.Text;
                szkolenie.DataSzkolenia = DateTime.Parse(txtDataSzkoleniaUpdate.Text);
                szkolenie.IloscOsob = int.Parse(txtIloscOsobUpdate.Text);
                szkolenie.CzasTrwania = decimal.Parse(txtCzasTrwaniaUpdate.Text);
                szkolenie.Koszt = decimal.Parse(txtKosztUpdate.Text);
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano szkolenie");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }
        //Cofanie się do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schoolingGrid = new SchoolingGrid();
            this.Close();
            schoolingGrid.Show();
        }
    }
}
