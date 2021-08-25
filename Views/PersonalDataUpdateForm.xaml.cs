using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy PersonalDataUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania danych osobowych
    public partial class PersonalDataUpdateForm : Window
    {
        //Łączenie się z modelami
        MASDBEntities db = new MASDBEntities();

        public PersonalDataUpdateForm()
        {
            InitializeComponent();
        }
        //Metoda główna aktualizowania danych
        private void UpdatePersonalData(object sender, RoutedEventArgs e)
        {
            var num = (int.Parse(txtIdDaneOsoboweUpdate.Text));
            //Szukanie osoby
            var query = from t in db.DaneOsobowe where t.IdDaneOsobowe == num select t;

            foreach (DaneOsobowe daneOsobowe in query)
            {
                daneOsobowe.Imie = txtImieUpdate.Text;
                daneOsobowe.Nazwisko = txtNazwiskoUpdate.Text;
                daneOsobowe.DataUrodzenia = DateTime.Parse(txtDataUrodzeniaUpdate.Text);
                daneOsobowe.AdresEmail = txtAdresEmailUpdate.Text;
                daneOsobowe.TelefonKontaktowy = txtTelefonUpdate.Text;
                daneOsobowe.AdresZamieszkania = txtAdresUpdate.Text;
                daneOsobowe.PESEL = decimal.Parse(txtPeselUpdate.Text);
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano dane osobowe");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }
        //Powrót do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
