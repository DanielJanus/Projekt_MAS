using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy PassGrid.xaml
    /// </summary>
    // Okno główno dotyczące klasy Karnet
    public partial class PassGrid : Window
    {
        //Łączenie z modelami
        MASDBEntities db = new MASDBEntities();
        public PassGrid()
        {
            InitializeComponent();
        }
        //Przekierowanie do formularza dodawania nowego karnetu
        private void AddPassData(object sender, RoutedEventArgs e)
        {
            PassAddForm passAddForm = new PassAddForm();
            this.Close();
            passAddForm.Show();
        }
        //Przekierowanie do formularza aktualizowania nowego karnetu
        private void UpdatePassData(object sender, RoutedEventArgs e)
        {
            PassUpdateForm passUpdateForm = new PassUpdateForm();
            passUpdateForm.Show();
        }
        //Usuwanie informacji o karnecie
        private void DeletePassData(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć karnet?", "Usun karnet", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdPassDelete.Text);
                Karnet karnet = (from t in db.Karnet where t.NumerKarnetu == toDelete select t).SingleOrDefault();
                try
                {
                    db.Karnet.Remove(karnet);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Wczytywanie informacji o karnecie
        private void LoadPassData(object sender, RoutedEventArgs e)
        {
            var pass = from t in db.Karnet
                           select new
                           {
                               NumerKarnetu = t.NumerKarnetu,
                               RodzajKarnetu = t.RodzajKarnetu,
                               NazwaKarnetu = t.NazwaKarnetu
                           };

            this.gridPassData.ItemsSource = pass.ToList();
        }
        //Powrót na stronę główną
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
        //Przekierowanie do okna głównego klasy Szkolenie
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
        //Przekierowanie do okna głównego klasy Klient
        private void MoveToClient(object sender, RoutedEventArgs e)
        {
            ClientGrid clientGrid = new ClientGrid();
            this.Close();
            clientGrid.Show();
        }
        //Przekierowanie do formularza dodawania karnetu do konkretnego klienta
        private void AddToSpecificClient(object sender, RoutedEventArgs e)
        {
            PassSpecificClientAddForm passSpecificClientAddForm = new PassSpecificClientAddForm();
            passSpecificClientAddForm.Show();
        }
    }
}
