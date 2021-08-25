using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ClubGrid.xaml
    /// </summary>
    // Główno okno dotyczące klasy Klub

    public partial class ClubGrid : Window
    {
        MASDBEntities db = new MASDBEntities();


        public ClubGrid()
        {
            InitializeComponent();
        }
        //Przejście do strony głównej
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przejście do okna z treningami
        private void ViewTrainings(object sender, RoutedEventArgs e)
        {
            Training training = new Training();
            this.Close();
            training.Show();
        }
        //Przejście do okna ze szkoleiami
        private void VievSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schoolingGrid = new SchoolingGrid();
            this.Close();
            schoolingGrid.Show();
        }
        //Przejście do formularza dodawania klubu
        private void AddClub(object sender, RoutedEventArgs e)
        {
            ClubAddForm clubAddForm = new ClubAddForm();
            this.Close();
            clubAddForm.Show();
        }

        private void LoadClubs(object sender, RoutedEventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From [Klub] klub JOIN [MaszynyWKlubie] maszyny ON klub.IdKlub = maszyny.Klub_IdKlub", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Klub");
                    da.Fill(dt);
                    gridClub.ItemsSource = dt.DefaultView;
                }
            }
        }
        //Aktualizowanie klubu
        private void UpdateClub(object sender, RoutedEventArgs e)
        {
            ClubUpdateForm clubUpdateForm = new ClubUpdateForm();
            clubUpdateForm.Show();
        }
        // Usuwanie danych klubu
        private void DeleteClub(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć klub?", "Usun klub", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdClubDelete.Text);
                Klub klub = (from t in db.Klub where t.IdKlub == toDelete select t).SingleOrDefault();
                try
                {
                    db.Klub.Remove(klub);
                    db.SaveChanges();
                }catch(Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Przejście do okna głównego dotyczącego wyposażeń
        private void EquipmentClubGrid(object sender, RoutedEventArgs e)
        {
            EquipmentClubGrid equipmentClubGrid = new EquipmentClubGrid();
            this.Close();
            equipmentClubGrid.Show();
        }
        //Przejście do okna głównego dotyczącego treningu w klubie
        private void TrainingInClub(object sender, RoutedEventArgs e)
        {
            TrainingInClubGrid trainingInClubGrid = new TrainingInClubGrid();
            this.Close();
            trainingInClubGrid.Show();
        }
        //Przejście do okna z danymi personalanymi
        private void PersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalData = new PersonalDataGrid();
            this.Close();
            personalData.Show();
        }
        //Przeszukiwanie bazy danych w celu znalezienia konkretego sprzętu
        private void SearchForEquipment(object sender, RoutedEventArgs e)
        {
            string clubNameValue = txtClubName.Text;
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From [Klub] klub JOIN [MaszynyWKlubie] maszyny ON klub.IdKlub = maszyny.Klub_IdKlub WHERE klub.NazwaKlubu = '" + clubNameValue + "'", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Klub");
                    da.Fill(dt);
                    gridClub.ItemsSource = dt.DefaultView;
                }
            }
        }
        //Przeszukiwanie bazy danych w celu znalezienia klubu
        private void SearchForClub(object sender, RoutedEventArgs e)
        {
            string clubAddressValue = txtClubAddress.Text;
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From [Klub] klub JOIN [MaszynyWKlubie] maszyny ON klub.IdKlub = maszyny.Klub_IdKlub WHERE klub.Adres = '" + clubAddressValue + "'", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Klub");
                    da.Fill(dt);
                    gridClub.ItemsSource = dt.DefaultView;
                }
            }
        }
        //Przeszukiwanie bazy danych w celu znalezienia treningu w klubie
        private void SearchForTrainingInClub(object sender, RoutedEventArgs e)
        {
            string clubNameValue = txtClubNameTraining.Text;
            string clubAddressValue = txtClubAddressTraining.Text;
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT IdKlub, NazwaKlubu, Adres, treningklub.DataTreningu, treningklub.DlugoscTreningu, treningklub.Cena, trening.Nazwa, trening.Rodzaj FROM [Klub] klub JOIN [TreningKlub] treningklub ON klub.IdKlub = treningklub.Klub_IdKlub JOIN [Trening] trening ON treningklub.Trening_IdTrening = trening.IdTrening WHERE klub.NazwaKlubu LIKE '" + clubNameValue + "' AND klub.Adres LIKE '" + clubAddressValue + "'", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Klub");
                    da.Fill(dt);
                    gridClub.ItemsSource = dt.DefaultView;
                }
            }
        }
    }
}
