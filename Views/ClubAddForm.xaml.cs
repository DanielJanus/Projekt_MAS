using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ClubAddForm.xaml
    /// </summary>
     // Formularz dodoawanie klubu do bazy danych

    public partial class ClubAddForm : Window
    {
        ClubGrid clubGrid = new ClubGrid();
        MASDBEntities db = new MASDBEntities();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;


        public ClubAddForm()
        {
            InitializeComponent();
        }
        //Główna metoda

        private void AddClub(object sender, RoutedEventArgs e)
        {
            //Szukanie najwiekszego ID

            string MaxIdClubValue = "SELECT MAX(IdKlub)+1 From Klub";
            int tmpIdClub;
            
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxIdClubValue, conn))
                    {
                        conn.Open();
                        tmpIdClub = (int)cmd.ExecuteScalar();

                        //Tworzenie klubu

                        Klub club = new Klub()
                        {
                            IdKlub = tmpIdClub,
                            NazwaKlubu = txtNazwa.Text,
                            Adres = txtAdres.Text,
                            TelefonSluzbowy = txtTelefon.Text
                        };


                        try
                        {
                            db.Klub.Add(club);
                            db.SaveChanges();
                            MessageBox.Show("Dodano nowy klub");

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

            this.Close();
            clubGrid.Show();
        }
        //Przejście do okna wstecz
        private void GoBack(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
    }
}
