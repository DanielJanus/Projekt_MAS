using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TrainingInClubAddForm.xaml
    /// </summary>
    // Formularz dodawania nowego treningu w klubie
    public partial class TrainingInClubAddForm : Window
    {
        //Łączenie się z bazą danych oraz modelami
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
        MASDBEntities db = new MASDBEntities();
        TrainingInClubGrid trainingInClubGrid = new TrainingInClubGrid();

        public TrainingInClubAddForm()
        {
            InitializeComponent();
        }
        //Dodawanie treningu w klubie
        private void AddTrainingInClub(object sender, RoutedEventArgs e)
        {
            TreningKlub treningKlub = new TreningKlub();

            int IdTraining = int.Parse(txtIdTrening.Text);
            int IdClub = int.Parse(txtIdKlubu.Text);
            DateTime DateOfTraining = DateTime.Parse(txtData.Text);
            decimal LengthOfTraining = decimal.Parse(txtDlugosc.Text);
            decimal Cost = treningKlub.GetCena(LengthOfTraining);

            //Zapytanie wykonujące wstawienie

            string AddTrainingClubData = "Insert into TreningKlub(Trening_IdTrening, Klub_IdKlub, DataTreningu, DlugoscTreningu, Cena)" +
                "VALUES('" + IdTraining + "' , '" + IdClub + "' , '" + DateOfTraining + "', '" + LengthOfTraining + "' , '" + Cost + "')";
            
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(AddTrainingClubData, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Dodano nowy trening w klubie");

                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }

            this.Close();
            trainingInClubGrid.Show();

        }
        //Cofnięcie się do poprzedniego widoku
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            trainingInClubGrid.Show();
        }
    }
}
