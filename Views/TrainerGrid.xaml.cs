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
    /// Logika interakcji dla klasy TrainerGrid.xaml
    /// </summary>
    //Widok okna głównego dla klasy Trener
    public partial class TrainerGrid : Window
    {
        //Łączenie się z modelami
        MASDBEntities db = new MASDBEntities();

        public TrainerGrid()
        {
            InitializeComponent();
        }
        //Przekierowanie do okna głównego klasy Pracownik
        private void MoveToEmployee(object sender, RoutedEventArgs e)
        {
            EmployeeGrid employeeGrid = new EmployeeGrid();
            this.Close();
            employeeGrid.Show();
        }
        //Przekierowanie do formularza dodawania trenera
        private void AddTrainerData(object sender, RoutedEventArgs e)
        {
            TrainerAddForm trainerAddForm = new TrainerAddForm();
            this.Close();
            trainerAddForm.Show();
        }
        //Przekierowanie do formularza aktualizowania trenera
        private void UpdateTrainerData(object sender, RoutedEventArgs e)
        {
            TrainerUpdateForm trainerUpdateForm = new TrainerUpdateForm();
            trainerUpdateForm.Show();
        }
        //Usuwanie trenera
        private void DeleteTrainerData(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć trenera?", "Usun trenera", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdTrainerDelete.Text);
                Trener trener = (from t in db.Trener where t.IdTrener == toDelete select t).SingleOrDefault();
                try
                {
                    db.Trener.Remove(trener);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Wczytywanie informacji o trenerze
        private void LoadTrainerData(object sender, RoutedEventArgs e)
        {
            var trainer = from t in db.Trener
                           select new
                           {
                               IdTrener = t.IdTrener,
                               IdPracownik = t.Pracownik_IdPracownik,
                               OferowaneTreningi = t.OferowaneTreningi,
                               PrawoWykonywaniaZawodu = t.PrawoWykonywaniaZawodu,
                               ImieTrenera = t.Pracownik.DaneOsobowe.Imie,
                               NazwiskoTrenera = t.Pracownik.DaneOsobowe.Nazwisko
                           };

            this.gridTrainerData.ItemsSource = trainer.ToList();
        }
        //Przekierowanie do okna głównego klasy DaneOsobowe
        private void ViewPersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalDataGrid = new PersonalDataGrid();
            this.Close();
            personalDataGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Szkolenia
        private void ViewSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schoolingGrid = new SchoolingGrid();
            this.Close();
            schoolingGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Trening
        private void ViewTrainings(object sender, RoutedEventArgs e)
        {
            Training training = new Training();
            this.Close();
            training.Show();
        }
        //Przekierowanie do strony głównej
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przekierowanie do okna głównego klasy Klub
        private void ViewClubs(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
        //Metoda wyszukująca trening
        private void SearchForTrainings(object sender, RoutedEventArgs e)
        {
            string trainerNameValue = txtTrainerName.Text;
            string trainerSurnNameValue = txtTrainerSurnName.Text;
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Trener] trener JOIN [Trening] trening ON trener.IdTrener = trening.Trener_IdTrener JOIN [TreningKlub] treningklub ON trening.IdTrening = treningklub.Trening_IdTrening JOIN [Klub] klub ON treningklub.Klub_IdKlub = klub.IdKlub JOIN [Pracownik] pracownik ON trener.Pracownik_IdPracownik = pracownik.IdPracownik JOIN [DaneOsobowe] daneosobowe ON pracownik.DaneOsobowe_IdDaneOsobowe = daneosobowe.IdDaneOsobowe WHERE daneosobowe.Imie LIKE '" + trainerNameValue + "' AND daneosobowe.Nazwisko LIKE '" + trainerSurnNameValue + "'", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Klient");
                    da.Fill(dt);
                    gridTrainerData.ItemsSource = dt.DefaultView;
                }
            }
        }
    }
}
