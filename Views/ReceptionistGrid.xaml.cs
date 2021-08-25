using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ReceptionistGrid.xaml
    /// </summary>
    // Okno główne dotyczące klasy recepcjonista
    public partial class ReceptionistGrid : Window
    {
        //Nawiązywanie połączenia z modelami
        MASDBEntities db = new MASDBEntities();

        public ReceptionistGrid()
        {
            InitializeComponent();
        }
        //Powrót do okna głównego
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przekierowanie do okna głównego klasy Trener
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
        //Przekierowanie do okna głównego klasy DaneOsobowe
        private void ViewPersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalDataGrid = new PersonalDataGrid();
            this.Close();
            personalDataGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Pracownik
        private void MoveToEmployee(object sender, RoutedEventArgs e)
        {
            EmployeeGrid employeeGrid = new EmployeeGrid();
            this.Close();
            employeeGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Recepcjonista
        private void AddReceptionistData(object sender, RoutedEventArgs e)
        {
            ReceptionistAddForm receptionistAddForm = new ReceptionistAddForm();
            this.Close();
            receptionistAddForm.Show();
        }
        //Przekierowanie do formularza aktualizowania recepcjonisty
        private void UpdateReceptionistData(object sender, RoutedEventArgs e)
        {
            ReceptionistUpdateForm receptionistUpdateForm = new ReceptionistUpdateForm();
            receptionistUpdateForm.Show();
        }
        //Usuwanie recepcjonisty
        private void DeleteReceptionistData(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć recepcjoniste?", "Usun recepcjoniste", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdReceptionistDelete.Text);
                Recepcjonista recepcjonista = (from t in db.Recepcjonista where t.IdRecepcjonista == toDelete select t).SingleOrDefault();
                try
                {
                    db.Recepcjonista.Remove(recepcjonista);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Wczytywanie informacji o recepcjoniście
        private void LoadReceptionistData(object sender, RoutedEventArgs e)
        {
            var receptionist = from t in db.Recepcjonista
                           select new
                           {
                               IdRecepcjonisty = t.IdRecepcjonista,
                               IdPracownika = t.Pracownik_IdPracownik,
                               IlośćWykonanychRezerwacji = t.IloscWykonanychRezerwacji,
                               ImieRecepcjonisty = t.Pracownik.DaneOsobowe.Imie,
                               NazwiskoRecepcjonisty = t.Pracownik.DaneOsobowe.Nazwisko
                           };

            this.gridReceptionistData.ItemsSource = receptionist.ToList();
        }
    }
}
