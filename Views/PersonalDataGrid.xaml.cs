using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy PersonalDataGrid.xaml
    /// </summary>
    // Główne okno z informacjami dotyczącymi danych osobowych
    public partial class PersonalDataGrid : Window
    {
        MASDBEntities db = new MASDBEntities();

        public PersonalDataGrid()
        {
            InitializeComponent();
        }

        //private void AddPersonalData(object sender, RoutedEventArgs e)
        //{
        //    PersonalDataAddForm personalDataAddForm = new PersonalDataAddForm();
        //    this.Close();
        //    personalDataAddForm.Show();
        //}
        //Przekierowanie do formularza aktualizowania danych osobowych
        //private void UpdatePersonalData(object sender, RoutedEventArgs e)
        //{
        //    PersonalDataUpdateForm personalDataUpdateForm = new PersonalDataUpdateForm();
        //    personalDataUpdateForm.Show();
        //}
        //Usuwanie danych osobowych
        private void DeletePersonalData(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć dane osobowe?", "Usun dane osobowe", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdPersonalDelete.Text);
                DaneOsobowe daneOsobowe = (from t in db.DaneOsobowe where t.IdDaneOsobowe == toDelete select t).SingleOrDefault();
                try
                {
                    db.DaneOsobowe.Remove(daneOsobowe);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Wczytywanie danych personalnych
        private void LoadPersonalData(object sender, RoutedEventArgs e)
        {
            var personalData = from t in db.DaneOsobowe
                            select new
                            {
                                IdDaneOsobowe = t.IdDaneOsobowe,
                                Imie = t.Imie,
                                Nazwisko = t.Nazwisko,
                                DataUrodzenia = t.DataUrodzenia,
                                AdresEmail = t.AdresEmail,
                                AdresZamieszkania = t.AdresZamieszkania,
                                PESEL = t.PESEL
                            };

            this.gridPersonalData.ItemsSource = personalData.ToList();
        }
        //Powrót do strony głównej
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przekierowanie do okna głównego klasy Trening
        private void ViewTrainings(object sender, RoutedEventArgs e)
        {
            Training training = new Training();
            this.Close();
            training.Show();
        }
        //Przekierowanie do okna głównego klasy Szkolenia
        private void ViewSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schoolingGrid = new SchoolingGrid();
            this.Close();
            schoolingGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Klub
        private void ViewClubs(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Pracownik
        private void MoveToEmployee(object sender, RoutedEventArgs e)
        {
            EmployeeGrid employeeGrid = new EmployeeGrid();
            this.Close();
            employeeGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Klienci
        private void MoveToClients(object sender, RoutedEventArgs e)
        {
            ClientGrid clientGrid = new ClientGrid();
            this.Close();
            clientGrid.Show();
        }

    }
}
