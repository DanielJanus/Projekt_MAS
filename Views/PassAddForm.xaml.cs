using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy PassAddForm.xaml
    /// </summary>
    // Formularz dodawania nowego karneta 
    public partial class PassAddForm : Window
    {
        //Łączenie się z modelami oraz nawiązywanie połączenia z bazą danych
        MASDBEntities db = new MASDBEntities();
        PassGrid passGrid = new PassGrid();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public PassAddForm()
        {
            InitializeComponent();
        }
        //Metoda główna dodawania karnetu po naciśnięciu na przyczisk
        private void AddPassData(object sender, RoutedEventArgs e)
        {
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
                            //Próba zapisania oraz dodania
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

            //Dodawanie relacji

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
                        MessageBox.Show("Dodano nowy karnet");

                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }


            this.Close();
            passGrid.Show();

        }
        //Powrót do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            passGrid.Show();
        }
    }
}
