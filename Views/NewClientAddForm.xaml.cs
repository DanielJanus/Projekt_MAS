using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy NewClientAddForm.xaml
    /// </summary>
    //  Formularz nowego klienta
    public partial class NewClientAddForm : Window
    {
        //Wczytywanie modeli oraz połączenia z bazy danych
        MASDBEntities db = new MASDBEntities();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
        public NewClientAddForm()
        {
            InitializeComponent();
        }
        //Główna metoda dodawania
        private void AddNewClientData(object sender, RoutedEventArgs e)
        {
            //Wczytywanie informacji z pól tekstowych
            string TypeOfDocument = txtRodzajDokumentu.Text;
            bool MedicalStatus = bool.Parse(txtZaswiadczenieOdLekarza.Text);
            bool AcceptingOfRegulations = bool.Parse(txtZgodaDoTyczacaRegulaminu.Text);
            string PassName = txtNazwaKarnetu.Text;
            string TypeOfPass = txtRodzajKarnetu.Text;
            //Szukanie największego ID
            string MaxId = "SELECT MAX(IdDaneOsobowe)+1 From DaneOsobowe";
            int id;

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxId, conn))
                    {
                        conn.Open();
                        id = (int)cmd.ExecuteScalar();

                        //Tworzenie nowych danych osobowych
                        DaneOsobowe daneOsobowe = new DaneOsobowe()
                        {
                            IdDaneOsobowe = id,
                            Imie = txtImie.Text,
                            Nazwisko = txtNazwisko.Text,
                            DataUrodzenia = DateTime.Parse(txtDataUrodzenia.Text),
                            AdresEmail = txtAdresEmail.Text,
                            TelefonKontaktowy = txtPhoneNumber.Text,
                            AdresZamieszkania = txtAdresZamieszkania.Text,
                            PESEL = decimal.Parse(txtPesel.Text)
                        };

                        try
                        {
                            //Próba dodania oraz zapisania
                            db.DaneOsobowe.Add(daneOsobowe);
                            db.SaveChanges();
                        }
                        catch (Exception a)
                        {
                            Console.WriteLine(a);
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            //SQL komenda dodawania nowego klienta
            string AddClientData = "INSERT INTO Klient(IdKlient, DaneOsobowe_IdDaneOsobowe, RodzajDokumentuOsobistego, ZaswiadczenieOdLekarza, ZgodaDotyczacaRegulaminuKlubu)" +
                "VALUES((SELECT MAX(IdKlient)+1 FROM Klient), (SELECT MAX(IdDaneOsobowe) FROM DaneOsobowe), '" + TypeOfDocument + "', '" + MedicalStatus + "', '" + AcceptingOfRegulations + "')";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(AddClientData, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }
            //SQL komenda dodawania nowego karnetu
            string AddPassData = "INSERT INTO Karnet(NumerKarnetu, RodzajKarnetu, NazwaKarnetu)" +
                "VALUES((SELECT MAX(NumerKarnetu)+1 FROM Karnet), '" + TypeOfPass + "', '" + PassName + "')";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(AddPassData, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }
            //SQL komenda wstawiania połączenia
            string AddClientPassRelation = "INSERT INTO KlientKarnet(NumerKarnetu, Klient_IdKlient)" +
                "VALUES((SELECT MAX(NumerKarnetu) FROM Karnet), (SELECT MAX(IdKlient) FROM Klient))";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    
                    using (SqlCommand cmd = new SqlCommand(AddClientPassRelation, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Dodano nowego klienta");

                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }

            this.Close();
        }
        //Powrót do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            OfferWindow offerWindow = new OfferWindow();
            this.Close();
            offerWindow.Show();
        }
    }
}
