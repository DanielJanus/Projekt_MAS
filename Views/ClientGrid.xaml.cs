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
    /// Logika interakcji dla klasy ClientGrid.xaml
    /// </summary>
    // Okno główno dla klasy Klient
    public partial class ClientGrid : Window
    {
        MASDBEntities db = new MASDBEntities();

        public ClientGrid()
        {
            InitializeComponent();
        }
        //Wracanie do okna głównego
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
        //Przejście do okna ze szkoleniami
        private void ViewSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schoolingGrid = new SchoolingGrid();
            this.Close();
            schoolingGrid.Show();
        }
        //Przejście do okna z klubami
        private void ViewClubs(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
        //Przejście do okna z danymi personalanymi
        private void ViewPersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalDataGrid = new PersonalDataGrid();
            this.Close();
            personalDataGrid.Show();
        }
        //Przejście do okna z danymi personalanymi
        private void GoBackToPersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalDataGrid = new PersonalDataGrid();
            this.Close();
            personalDataGrid.Show();
        }
        //Przejście do okna z karnetami
        private void MoveToPass(object sender, RoutedEventArgs e)
        {
            PassGrid passGrid = new PassGrid();
            this.Close();
            passGrid.Show();
        }
        //Przejście do formularza dodawania klienta
        private void AddClientData(object sender, RoutedEventArgs e)
        {
            ClientAddForm clientAddForm = new ClientAddForm();
            this.Close();
            clientAddForm.Show();
        }
        //Wczytywanie danych z bazy danych
        private void LoadClientData(object sender, RoutedEventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select klient.IdKlient, klient.DaneOsobowe_IdDaneOsobowe, karnet.NumerKarnetu, daneosobowe.Imie, daneosobowe.Nazwisko, klient.RodzajDokumentuOsobistego, klient.ZaswiadczenieOdLekarza, klient.ZgodaDotyczacaRegulaminuKlubu, karnet.NazwaKarnetu, karnet.RodzajKarnetu From [Klient] klient Join [KlientKarnet] klientkarnet ON klient.IdKlient = klientkarnet.Klient_IdKlient Join [Karnet] karnet ON klientkarnet.NumerKarnetu = karnet.NumerKarnetu Join [DaneOsobowe] daneosobowe ON klient.DaneOsobowe_IdDaneOsobowe = daneosobowe.IdDaneOsobowe", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Klient");
                    da.Fill(dt);
                    gridClientData.ItemsSource = dt.DefaultView;
                }
            }
        }
        //Przejście do formualrza aktualizowania klienta
        private void UpdateClientData(object sender, RoutedEventArgs e)
        {
            ClientUpdateForm clientUpdateForm = new ClientUpdateForm();
            clientUpdateForm.Show();
        }
        //Usuwanie klienta
        private void DeleteClientData(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć klienta?", "Usun klienta", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdClientDelete.Text);
                Klient klient = (from t in db.Klient where t.IdKlient == toDelete select t).SingleOrDefault();
                try
                {
                    db.Klient.Remove(klient);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Szukanie karnetu
        private void SearchForCarnet(object sender, RoutedEventArgs e)
        {
            int PassTextBoxValue = int.Parse(txtIdCarnetToList.Text);
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from [Karnet] karnet Join [KlientKarnet] klientkarnet ON karnet.NumerKarnetu = klientkarnet.NumerKarnetu JOIN [Klient] klient ON klientkarnet.Klient_IdKlient = klient.IdKlient WHERE karnet.NumerKarnetu = '" + PassTextBoxValue + "'", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Karnet");
                    da.Fill(dt);
                    gridClientData.ItemsSource = dt.DefaultView;
                }
            }
        }
        //Szukanie klienta
        private void SearchForClient(object sender, RoutedEventArgs e)
        {
            string clientTextBoxValue = txtClientName.Text;
            string clientSurnameValue = txtClientSurname.Text;
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From [Klient] klient Join [KlientKarnet] klientkarnet ON klient.IdKlient = klientkarnet.Klient_IdKlient Join [Karnet] karnet ON klientkarnet.NumerKarnetu = karnet.NumerKarnetu Join [DaneOsobowe] daneosobowe ON klient.DaneOsobowe_IdDaneOsobowe = daneosobowe.IdDaneOsobowe Where daneosobowe.Imie Like '" + clientTextBoxValue + "' AND daneosobowe.Nazwisko Like '" + clientSurnameValue + "'", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Klient");
                    da.Fill(dt);
                    gridClientData.ItemsSource = dt.DefaultView;
                }
            }
        }
    }
}
