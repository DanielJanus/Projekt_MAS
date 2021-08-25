using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy PassSpecificClientAddForm.xaml
    /// </summary>
    // Formularz dodawania karnetu do konkretnego klienta
    public partial class PassSpecificClientAddForm : Window
    {
        //Łączenie się ze strona główną karnetów, nawiązywanie połączenia z modelami oraz SQL połączeniem
        PassGrid passGrid = new PassGrid();
        MASDBEntities db = new MASDBEntities();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public PassSpecificClientAddForm()
        {
            InitializeComponent();
        }
        //Metoda główna dodawania karnetu do klienta
        private void AddSpecificPass(object sender, RoutedEventArgs e)
        {
            //Wczytywanie informacji z pól tekstowych
            int IdClient = int.Parse(txtIdClient.Text);
            string MaxIdPass = "SELECT MAX(NumerKarnetu)+1 From Karnet";
            int tmpIdPass;

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxIdPass, conn))
                    {
                        conn.Open();
                        tmpIdPass = (int)cmd.ExecuteScalar();

                        //Tworzenie nowego karnetu

                        Karnet karnet = new Karnet()
                        {
                            NumerKarnetu = tmpIdPass,
                            RodzajKarnetu = txtRodzaj.Text,
                            NazwaKarnetu = txtNazwa.Text
                        };

                        try
                        {
                            db.Karnet.Add(karnet);
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

            //Wstawianie nowej relacji

            string AddClientPassRelation = "INSERT INTO KlientKarnet(NumerKarnetu, Klient_IdKlient)" +
                "VALUES((SELECT MAX(NumerKarnetu) FROM Karnet), '" + IdClient + "')";
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {

                    using (SqlCommand cmd = new SqlCommand(AddClientPassRelation, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Dodano nowy karnet");

                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }


            this.Close();

        }
        //Cofanie sie okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
