using MAS_Implementacja.Models;
using System;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy PersonalDataAddForm.xaml
    /// </summary>
    // Formularz dodawania nowych danych osobwych
    public partial class PersonalDataAddForm : Window
    {
        //Łączenie się z modelami
        MASDBEntities db = new MASDBEntities();
        PersonalDataGrid personalDataGrid = new PersonalDataGrid();

        public PersonalDataAddForm()
        {
            InitializeComponent();
        }
        //Główna metoda dodawania danych
        private void AddPersonalData(object sender, RoutedEventArgs e)
        {
            DaneOsobowe daneOsobowe = new DaneOsobowe()
            {
                IdDaneOsobowe = int.Parse(txtIdDaneOsobowe.Text),
                Imie = txtImie.Text,
                Nazwisko = txtNazwisko.Text,
                DataUrodzenia = DateTime.Parse(txtDataUrodzenia.Text),
                AdresEmail = txtAdresEmail.Text,
                TelefonKontaktowy = txtTelefon.Text,
                AdresZamieszkania = txtAdres.Text,
                PESEL = decimal.Parse(txtPesel.Text)
            };
            //Próba zapisania
            try
            {
                db.DaneOsobowe.Add(daneOsobowe);
                db.SaveChanges();
                MessageBox.Show("Dodano nowe dane osobowe");
                personalDataGrid.Show();


            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }

            this.Close();
        }
        //Cofanie się do strony głównej
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            personalDataGrid.Show();
        }
    }
}
