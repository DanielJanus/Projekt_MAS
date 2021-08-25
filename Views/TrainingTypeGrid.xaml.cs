using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TrainingTypeGrid.xaml
    /// </summary>
    // Główny widok dla TypuTreningu
    public partial class TrainingTypeGrid : Window
    {
        //Łączenie się z modelami
        MASDBEntities db = new MASDBEntities();

        public TrainingTypeGrid()
        {
            InitializeComponent();
        }
        //Przekierowanie do okna głównego klasy Treningu
        private void BackToTraining(object sender, RoutedEventArgs e)
        {
            Training trainingPage = new Training();
            this.Close();
            trainingPage.Show();
        }
        //Powrót na stronę główną
        private void BackToMainPage(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }
        //Przekierowanie do formularza dodawania nowego typu 
        private void AddTrainingType(object sender, RoutedEventArgs e)
        {
            TrainingType trainingType = new TrainingType();
            this.Close();
            trainingType.Show();
        }
        //Wczytaj dane treningowe
        private void LoadTrainingTypes(object sender, RoutedEventArgs e)
        {
            var trainingTypes = from t in db.TypTreningu
                                select new
                                {
                                    IdTypTreningu = t.IdTypTreningu,
                                    NazwaTypuTreningu = t.NazwaTypuTreningu,
                                    LiczbaSerii = t.LiczbaSerii,
                                    LiczbaPowtorzen = t.LiczbaPowtorzen,
                                    MetodaTreningowa = t.MetodaTreningowa,
                                    AkcesoriaTreningowe = t.AkcesoriaTreningowe,
                                    MaszynyDoTreninguSilowego = t.MaszynyDoTreninguSilowego,
                                    MaszynyCardio = t.MaszynyCardio,
                                    WyposazenieCardioFitness = t.WyposazenieCardioFitness
                                };

            this.gridTrainingType.ItemsSource = trainingTypes.ToList();
        }
        //Formularz do aktualizowanie typu treningowego
        private void UpdateTrainingTypes(object sender, RoutedEventArgs e)
        {
            TrainingTypeUpdate trainingTypeUpdate = new TrainingTypeUpdate();
            trainingTypeUpdate.Show();
        }
        //Usuwanie danych z typu treningowego
        private void DeleteTrainingType(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć typ treningu?", "Usun typ treningu", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdTrainingDelete.Text);
                TypTreningu tren = (from t in db.TypTreningu where t.IdTypTreningu == toDelete select t).SingleOrDefault();
                try
                {
                    db.TypTreningu.Remove(tren);
                    db.SaveChanges();
                }
                catch(Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Przekierowanie do okna głównego klasy Szkolenia
        private void ViewSchooling(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schooling = new SchoolingGrid();
            this.Close();
            schooling.Show();
        }
        //Przekierowanie do okna głównego klasy Klub
        private void ViewClubs(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Dane Osobowe
        private void PersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalData = new PersonalDataGrid();
            this.Close();
            personalData.Show();
        }
    }
}
