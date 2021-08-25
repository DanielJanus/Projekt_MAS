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
    /// Logika interakcji dla klasy InstructorGrid.xaml
    /// </summary>
    // Główny widok dla klasy Instruktor
    public partial class InstructorGrid : Window
    {
        //Wczytywanie modeli
        MASDBEntities db = new MASDBEntities();

        public InstructorGrid()
        {
            InitializeComponent();
        }
        //Cofanie się do strony głównej
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przekierowanie do okna głównego klasy Trening
        private void ViewTrainings(object sender, RoutedEventArgs e)
        {
            Training training = new Training();
            this.Close();
            training.Show();
        }
        //Przekierowanie do okna głównego klasy Szkolenie
        private void ViewSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schoolingGrid = new SchoolingGrid();
            this.Close();
            schoolingGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Klub
        private void ViewClubs(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Trening
        private void ViewPersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalDataGrid = new PersonalDataGrid();
            this.Close();
            personalDataGrid.Show();
        }
        //Przekierowanie do okna głównego klasy Pracownik
        private void MoveToEmployee(object sender, RoutedEventArgs e)
        {
            EmployeeGrid employeeGrid = new EmployeeGrid();
            this.Close();
            employeeGrid.Show();
        }
        //Przejdź do formularza wstawiania nowego instruktor
        private void AddInstructorData(object sender, RoutedEventArgs e)
        {
            InstructorAddForm instructorAddForm = new InstructorAddForm();
            this.Close();
            instructorAddForm.Show();
        }
        //Wczytaj informację dotyczące instruktorów
        private void LoadInstructorData(object sender, RoutedEventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select IdInstruktor,Pracownik_IdPracownik,IdSzkolenie,Instruktor_IdInstruktor,Nazwa,DataSzkolenia,IloscOsob,CzasTrwania,Koszt,daneosobowe.Imie,daneosobowe.Nazwisko From [Instruktor] instructor JOIN [Szkolenie] szkolenie ON instructor.IdInstruktor = szkolenie.Instruktor_IdInstruktor JOIN [Pracownik] pracownik ON instructor.Pracownik_IdPracownik = pracownik.IdPracownik JOIN [DaneOsobowe] daneosobowe ON pracownik.DaneOsobowe_IdDaneOsobowe = daneosobowe.IdDaneOsobowe", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Klub");
                    da.Fill(dt);
                    gridInstructorData.ItemsSource = dt.DefaultView;
                }
            }
        }
        //Przekierowanie do formularza aktualizowania instruktora
        private void UpdateInstructorData(object sender, RoutedEventArgs e)
        {
            InstructorUpdateForm instructorUpdateForm = new InstructorUpdateForm();
            instructorUpdateForm.Show();
        }
        //Usuwanie instruktora
        private void DeleteInstructorData(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć instruktora?", "Usun instruktora", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdInstructorData.Text);
                Instruktor instruktor = (from t in db.Instruktor where t.IdInstruktor == toDelete select t).SingleOrDefault();
                try
                {
                    db.Instruktor.Remove(instruktor);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Poszukiwanie instruktora
        private void SearchForInstructor(object sender, RoutedEventArgs e)
        {
            //Wczytywanie informacji z pól tekstowych
            string instructorNameValue = txtInstructorName.Text;
            string instructorSurnNameValue = txtInstructorSurname.Text;
            string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * From [Instruktor] instructor JOIN [Szkolenie] szkolenie ON instructor.IdInstruktor = szkolenie.Instruktor_IdInstruktor JOIN [Pracownik] pracownik ON instructor.Pracownik_IdPracownik = pracownik.IdPracownik JOIN [DaneOsobowe] daneosobowe ON pracownik.DaneOsobowe_IdDaneOsobowe = daneosobowe.IdDaneOsobowe WHERE daneosobowe.Imie LIKE '" + instructorNameValue + "' AND daneosobowe.Nazwisko LIKE '" + instructorSurnNameValue + "'", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Klient");
                    da.Fill(dt);
                    gridInstructorData.ItemsSource = dt.DefaultView;
                }
            }
        }
    }
}
