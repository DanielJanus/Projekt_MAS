using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy EquipmentClubGrid.xaml
    /// </summary>
    // Główny widok dla klasy MaszynyWKlubie
    public partial class EquipmentClubGrid : Window
    {
        //Wczytywanie modeli
        MASDBEntities db = new MASDBEntities();
        public EquipmentClubGrid()
        {
            InitializeComponent();
        }
        //Przekierowanie do widoku głównego klasy Trening
        private void ViewTrainings(object sender, RoutedEventArgs e)
        {
            Training training = new Training();
            this.Close();
            training.Show();
        }
        //Powrót do strony głównej
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przekierowanie do widoku głównego klasy Szkolenie
        private void ViewSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schooling = new SchoolingGrid();
            this.Close();
            schooling.Show();
        }
        //Przekierowanie do formularza dodawania nowego maszyn
        private void AddEquipment(object sender, RoutedEventArgs e)
        {
            EquipmentAddForm equipmentAddForm = new EquipmentAddForm();
            this.Close();
            equipmentAddForm.Show();
        }
        //Przekierowanie do formularza aktualizowania maszyn
        private void UpdateEquipment(object sender, RoutedEventArgs e)
        {
            EquipmentUpdateForm equipmentUpdateForm = new EquipmentUpdateForm();
            equipmentUpdateForm.Show();
        }
        //Usuwanie MaszynyWKlubie
        private void DeleteEquipment(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć wyposażenie?", "Usun wyposazenie", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdEquipmentDelete.Text);
                MaszynyWKlubie maszynyWKlubie = (from t in db.MaszynyWKlubie where t.NumerIdentyfikacyjny == toDelete select t).SingleOrDefault();
                try
                {
                    //Usunięcie Maszyny
                    db.MaszynyWKlubie.Remove(maszynyWKlubie);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Wczytywanie danych MaszynWKlubie
        private void LoadEquipment(object sender, RoutedEventArgs e)
        {
            var equipments = from t in db.MaszynyWKlubie
                             select new
                             {
                                 NumerIdentyfikacyjny = t.NumerIdentyfikacyjny,
                                 IdKlub = t.Klub_IdKlub,
                                 Nazwa = t.Nazwa,
                                 Zastosowanie = t.Zastosowanie,
                                 OstatniaDataKonserwacji = t.OstatniaDataKonserwacji,
                                 ZaplanowanaDataKonserwacji = t.ZaplanowanaDataKonserwacji,
                                 NazwaKlubu = t.Klub.NazwaKlubu
                             };
            this.gridEquipment.ItemsSource = equipments.ToList();
        }
        //Przekierowanie do widoku głównego klasy Klub
        private void ClubGrid(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
        //Przekierowanie do widoku głównego klasy DaneOsobowe
        private void PersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalData = new PersonalDataGrid();
            this.Close();
            personalData.Show();
        }
    }
}
