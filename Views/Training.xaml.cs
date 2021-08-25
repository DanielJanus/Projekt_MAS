using System.Linq;
using System.Windows;
using MAS_Implementacja.Models;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Training.xaml
    /// </summary>
    // Okno główne dla klasy Trening
    public partial class Training : Window
    {
        MASDBEntities db = new MASDBEntities();
        public Training()
        {
            InitializeComponent();

        }
        //Powró na stronę główną
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Wczytywanie treningów
        private void LoadTrainings(object sender, RoutedEventArgs e)
        {
            var trainings = from t in db.Trening
                            select new
                            {
                                IdTraining = t.IdTrening,
                                IdRecepcjonista = t.Recepcjonista_IdRecepcjonista,
                                IdTypTreningu = t.TypTreningu_IdTypTreningu,
                                IdTrener = t.Trener_IdTrener,
                                Nazwa = t.Nazwa,
                                Rodzaj = t.Rodzaj,
                                Rezerwacja = t.Rezerwacja,
                                ImieTrenera = t.Trener.Pracownik.DaneOsobowe.Imie,
                                NazwiskoTrenera = t.Trener.Pracownik.DaneOsobowe.Nazwisko,
                                NazwaTypuTreningu = t.TypTreningu.NazwaTypuTreningu,
                                MetodaTreningowa = t.TypTreningu.MetodaTreningowa
                            };

            this.gridTraining.ItemsSource = trainings.ToList();
        }
        //Przekierowanie do formularza aktualizowania treningów
        private void UpdateTraining(object sender, RoutedEventArgs e)
        {
            TrainingUpdateForm trainingUpdate = new TrainingUpdateForm();
            trainingUpdate.Show();
        }
        //Przekierowanie do formularza dodawania treningu
        private void AddTraining(object sender, RoutedEventArgs e)
        {
            TreningForm treningForm = new TreningForm();
            this.Close();
            treningForm.Show();
        }
        //Przekierowanie do okna głównego klasy TypTreningu
        private void AddTrainingType(object sender, RoutedEventArgs e)
        {
            TrainingTypeGrid trainingType = new TrainingTypeGrid();
            this.Close();
            trainingType.Show();
        }
        //Usuwanie treningu
        private void DeleteTraining(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć trening?", "Usun trening", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdTrainingDelete.Text);
                Trening tren = (from t in db.Trening where t.IdTrening == toDelete select t).SingleOrDefault();
                db.Trening.Remove(tren);
                db.SaveChanges();
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
        //Przekierowanie do okna głównego klasy TreningKlub
        private void TrainingInClub(object sender, RoutedEventArgs e)
        {
            TrainingInClubGrid trainingInClubGrid = new TrainingInClubGrid();
            this.Close();
            trainingInClubGrid.Show();
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
