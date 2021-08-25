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
    /// Logika interakcji dla klasy TrainingInClubGrid.xaml
    /// </summary>
    // Główny widok dla treningu w klubie
    public partial class TrainingInClubGrid : Window
    {
        //Łączenie się z modelami
        MASDBEntities db = new MASDBEntities();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public TrainingInClubGrid()
        {
            InitializeComponent();
        }
        //Przekierowanie do okna głównego klasy Klub
        private void ClubGrid(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Trening
        private void TrainingGrid(object sender, RoutedEventArgs e)
        {
            Training training = new Training();
            this.Close();
            training.Show();
        }
        //Przekierowanie do formularza tworzącego trening w klubie
        private void AddTrainingInClub(object sender, RoutedEventArgs e)
        {
            TrainingInClubAddForm trainingInClubAddForm = new TrainingInClubAddForm();
            this.Close();
            trainingInClubAddForm.Show();
        }
        //Przekierowanie do formularza aktualizującego trening w klubie
        private void UpdateTrainingInClub(object sender, RoutedEventArgs e)
        {
            TrainingInClubUpdateForm trainingInClubUpdateForm = new TrainingInClubUpdateForm();
            trainingInClubUpdateForm.Show();
        }
        //Usuwanie treningu w klubie
        private void DeleteTrainingFromClub(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć trening w klubie?", "Usun trening w klubie", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int trainingToDelete = int.Parse(txtIdTrainingDelete.Text);
                int clubToDelete = int.Parse(txtIdKlubuDelete.Text);

                TreningKlub treningKlub = (from t in db.TreningKlub where t.Trening_IdTrening == trainingToDelete && t.Klub_IdKlub == clubToDelete select t).SingleOrDefault();
                try
                {
                    db.TreningKlub.Remove(treningKlub);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Wczytywanie informacji z bazy danych
        private void LoadTrainingInClub(object sender, RoutedEventArgs e)
        {

            var trainings = from t in db.TreningKlub
                            select new
                            {
                                IdTrening = t.Trening_IdTrening,
                                IdKlub = t.Klub_IdKlub,
                                DataTreningu = t.DataTreningu,
                                DlugoscTreningu = t.DlugoscTreningu,
                                Cena = t.Cena,
                                NazwaKlubu = t.Klub.NazwaKlubu,
                                NazwaTreningu = t.Trening.Nazwa
                            };

            this.gridTrainingInClub.ItemsSource = trainings.ToList();
        }
        //Powrót na stronę główną
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przekierowanie do okna głównego klasy Szkolenia
        private void ViewSchooling(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schoolingGrid = new SchoolingGrid();
            this.Close();
            schoolingGrid.Show();
        }
        //Przekierowanie do okna głównego klasy DaneOsobowe
        private void PersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalData = new PersonalDataGrid();
            this.Close();
            personalData.Show();
        }

        private void FindClub(object sender, RoutedEventArgs e)
        {
            int ClubIdValue = int.Parse(txtIdKlub.Text);

            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From TreningKlub Where Klub_IdKlub = '" + ClubIdValue + "'", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("TreningKlub");
                    da.Fill(dt);
                    gridTrainingInClub.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void FindTraining(object sender, RoutedEventArgs e)
        {
            int TrainingIdValue = int.Parse(txtIdTreningu.Text);

            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From TreningKlub Where Trening_IdTrening = '" + TrainingIdValue + "'", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("TreningKlub");
                    da.Fill(dt);
                    gridTrainingInClub.ItemsSource = dt.DefaultView;
                }
            }
        }

        private void FindSpecific(object sender, RoutedEventArgs e)
        {
            int TrainingIdValue = int.Parse(txtIdTreningu.Text);
            int ClubIdValue = int.Parse(txtIdKlub.Text);

            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From TreningKlub Where Trening_IdTrening = '" + TrainingIdValue + "' AND Klub_IdKlub = '" + ClubIdValue + "' ", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("TreningKlub");
                    da.Fill(dt);
                    gridTrainingInClub.ItemsSource = dt.DefaultView;
                }
            }
        }
    }
}
