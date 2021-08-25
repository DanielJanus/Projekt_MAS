using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy SchoolingGrid.xaml
    /// </summary>
    // Okno główne dla klasy Szkolenie
    public partial class SchoolingGrid : Window
    {
        //Łaczenie się z modelami
        MASDBEntities db = new MASDBEntities();

        public SchoolingGrid()
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
            Training schooling = new Training();
            this.Close();
            schooling.Show();
        }
        //Ładowanie informacji o szkoleniach
        private void Loadchoolings(object sender, RoutedEventArgs e)
        {
            var schoolings = from t in db.Szkolenie
                            select new
                            {
                                IdSzkolenie = t.IdSzkolenie,
                                Instruktor_IdInstruktor = t.Instruktor_IdInstruktor,
                                Nazwa = t.Nazwa,
                                DataSzkolenia = t.DataSzkolenia,
                                IloscOsob = t.IloscOsob,
                                CzasTrwania = t.CzasTrwania,
                                Koszt = t.Koszt,
                                ImieInstruktora = t.Instruktor.Pracownik.DaneOsobowe.Imie,
                                NazwiskoInstruktora = t.Instruktor.Pracownik.DaneOsobowe.Nazwisko
                            };

            this.gridSchooling.ItemsSource = schoolings.ToList();
        }
        //Otwieranie formularza szkoleń
        private void AddSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingAddForm schoolingAddForm = new SchoolingAddForm();
            this.Close();
            schoolingAddForm.Show();
        }
        //Przekierowanie do formularza aktualizowania szkolenia
        private void UpdateSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingUpdateForm updateSchoolingForm = new SchoolingUpdateForm();
            updateSchoolingForm.Show();
        }
        //Usuwanie szkolenia
        private void DeleteSchoolings(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć szkolenie?", "Usun szkolenie", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdSchoolingDelete.Text);
                Szkolenie szkolenie = (from t in db.Szkolenie where t.IdSzkolenie == toDelete select t).SingleOrDefault();
                try
                {
                    db.Szkolenie.Remove(szkolenie);
                    db.SaveChanges();
                }catch(Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Przekierowanie do okna głównego klasy Klub
        private void ViewClubs(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
        //Przekierowanie do okna głównego klasy DaneOsobowe
        private void PersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalData = new PersonalDataGrid();
            this.Close();
            personalData.Show();
        }
    }
}
