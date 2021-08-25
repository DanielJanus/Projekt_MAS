using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;


namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ClientAddForm.xaml
    /// </summary>
    /// 
    //Formularz dodawania do klasy: Klient

    public partial class ClientAddForm : Window
    {
        MASDBEntities db = new MASDBEntities();
        ClientGrid clientGrid = new ClientGrid();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public ClientAddForm()
        {
            InitializeComponent();
        }
        //Wydarzenie po nacisnieciu na klawisz "Dodaj klienta"
        private void AddClientData(object sender, RoutedEventArgs e)
        {
            //Pola z formualrza
            string TypeOfDocument = txtRodzajDokumentu.Text;
            bool MedicalStatus = bool.Parse(txtZaswiadczenie.Text);
            bool AcceptingOfRegulations = bool.Parse(txtZgoda.Text);


            string MaxId = "SELECT MAX(IdDaneOsobowe)+1 From DaneOsobowe";
            int id;

            //Otwieranie połączenia
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxId, conn))
                    {
                        conn.Open();
                        id = (int)cmd.ExecuteScalar();
                        
                        //Wstawianie rzeczy do klasy DaneOsobowe
                        DaneOsobowe daneOsobowe = new DaneOsobowe()
                        {
                            IdDaneOsobowe = id,
                            Imie = txtImie.Text,
                            Nazwisko = txtNazwisko.Text,
                            DataUrodzenia = DateTime.Parse(txtDataUrodzenia.Text),
                            AdresEmail = txtAdresEmail.Text,
                            TelefonKontaktowy = txtTelefon.Text,
                            AdresZamieszkania = txtAdresZamieszkania.Text,
                            PESEL = decimal.Parse(txtPesel.Text)
                        };

                        try
                        {
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
            //SQL-owe zapytanie wstawiające informację do Klient

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
                        MessageBox.Show("Dodano nowego klienta");

                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }
            this.Close();
            clientGrid.Show();
        }
        //Powót do wcześniejszego widoku
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            clientGrid.Show();
        }
    }
}
