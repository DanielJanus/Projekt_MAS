using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy EmployeeUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania informcji o pracowniku
    public partial class EmployeeUpdateForm : Window
    {
        //Wczytywanie modeli
        MASDBEntities db = new MASDBEntities();

        public EmployeeUpdateForm()
        {
            InitializeComponent();
        }
        //Aktualizowanie pracownika
        private void UpdateEmployeeData(object sender, RoutedEventArgs e)
        {
            var personalData = (int.Parse(txtIdDaneUpdate.Text));

            //Poszukiwanie pracownika

            var query = from t in db.Pracownik where t.DaneOsobowe_IdDaneOsobowe == personalData select t;

            foreach (Pracownik pracownik in query)
            {
                pracownik.IdPracownik = int.Parse(txtIdPracownikaUpdate.Text);
                pracownik.Umowa_IdUmowa = int.Parse(txtIdUmowaUpdate.Text);
                pracownik.NumerKontaBankowego = decimal.Parse(txtNumerKontaUpdate.Text);
                pracownik.IndywidualnaStawkaGodzinowa = decimal.Parse(txtIndywidualnaStawkaUpdate.Text);
                pracownik.LiczbaGodzinPrzepracowanych = decimal.Parse(txtLiczbaGodzinUpdate.Text);
                pracownik.Pensja = decimal.Parse(txtPensjaUpdate.Text);
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano pracownika");

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
            this.Close();
        }
    }
}
