using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Main.xaml
    /// </summary>
    // Strona główna aplikacji
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }
        //Przekierowanie do okna głównego klasy Trening
        private void ShowTraining(object sender, RoutedEventArgs e)
        {
            Training trainingPage = new Training();
            trainingPage.Show();
        }
        //Przekierowanie do okna głównego klasy Szkolenie
        private void ViewSchooling(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schooling = new SchoolingGrid();
            schooling.Show();
        }
        //Przekierowanie do okna głównego klasy Klub
        private void ViewClubs(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            clubGrid.Show();
        }
        //Przekierowanie do okna głównego klasy DaneOsobowe
        private void PersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalDataGrid = new PersonalDataGrid();
            personalDataGrid.Show();
        }
        //Przekierowanie do okna ofert dla klientów
        private void OpenOffer(object sender, RoutedEventArgs e)
        {
            OfferWindow offerWindow = new OfferWindow();
            offerWindow.Show();
        }
    }
}
