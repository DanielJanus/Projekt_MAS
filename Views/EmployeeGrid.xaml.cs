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
    /// Logika interakcji dla klasy EmployeeGrid.xaml
    /// </summary>
    // Główne okno dotyczące widoku i zarządzania Pracownikami

    public partial class EmployeeGrid : Window
    {
        //Łączenie się z modelami
        MASDBEntities db = new MASDBEntities();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public EmployeeGrid()
        {
            InitializeComponent();
        }
        //Przkierowanie do okna głównego klasy DaneOsobowe
        private void ViewPersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalDataGrid = new PersonalDataGrid();
            this.Close();
            personalDataGrid.Show();
        }
        //Przkierowanie do okna głównego klasy Szkolenia
        private void ViewSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schoolingGrid = new SchoolingGrid();
            this.Close();
            schoolingGrid.Show();
        }
        //Przkierowanie do okna głównego klasy Trening
        private void ViewTrainings(object sender, RoutedEventArgs e)
        {
            Training training = new Training();
            this.Close();
            training.Show();
        }
        //Przkierowanie do okna głównego klasy Klub
        private void ViewClubs(object sender, RoutedEventArgs e)
        {
            ClubGrid clubGrid = new ClubGrid();
            this.Close();
            clubGrid.Show();
        }
        //Przkierowanie do strony głównej
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przkierowanie do okna głównego klasy Trenerzy
        private void MoveToTrainers(object sender, RoutedEventArgs e)
        {
            TrainerGrid trainerGrid = new TrainerGrid();
            this.Close();
            trainerGrid.Show();
        }
        //Przkierowanie do okna głównego klasy Recepcjonista
        private void MoveToReceptionists(object sender, RoutedEventArgs e)
        {
            ReceptionistGrid receptionistGrid = new ReceptionistGrid();
            this.Close();
            receptionistGrid.Show();
        }
        //Przkierowanie do okna głównego klasy Instruktor
        private void MoveToInstructors(object sender, RoutedEventArgs e)
        {
            InstructorGrid instructorGrid = new InstructorGrid();
            this.Close();
            instructorGrid.Show();
        }
        // Dodawanie nowego pracownika wyłączone
        //private void AddEmployeeData(object sender, RoutedEventArgs e)
        //{
        //    EmployeeAddForm employeeAddForm = new EmployeeAddForm();
        //    this.Close();
        //    employeeAddForm.Show();
        //}

        //Przekierowanie do formularza aktualizowania danych pracownika
        //private void UpdateEmployeeData(object sender, RoutedEventArgs e)
        //{
        //    EmployeeUpdateForm employeeUpdateForm = new EmployeeUpdateForm();
        //    employeeUpdateForm.Show();
        //}
        //Usuwanie pracownika
        private void DeleteEmployeeData(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć pracownika?", "Usun pracownika", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdEmployeDelete.Text);
                Pracownik pracownik = (from t in db.Pracownik where t.IdPracownik == toDelete select t).SingleOrDefault();
                //Próba usunięcia pracownika
                try
                {
                    db.Pracownik.Remove(pracownik);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
        //Wczytywanie informacji o Pracownika z bazy danych
        private void LoadEmployeeData(object sender, RoutedEventArgs e)
        {
            //Pracownik
            var employee = from t in db.Pracownik
                        select new
                        {
                            IdPracownik = t.IdPracownik,
                            IdUmowa = t.Umowa_IdUmowa,
                            IdDaneOsobowe = t.DaneOsobowe_IdDaneOsobowe,
                            NumerKontaBankowego = t.NumerKontaBankowego,
                            IndywidualnaStawkaGodzinowa = t.IndywidualnaStawkaGodzinowa,
                            LiczbaGodzinPrzepracowanych = t.LiczbaGodzinPrzepracowanych,
                            Pensja = t.Pensja,
                            Imie = t.DaneOsobowe.Imie,
                            Nazwisko = t.DaneOsobowe.Nazwisko,
                            RodzajUmowy = t.Umowa.RodzajUmowy
                        };

            this.gridEmployeeData.ItemsSource = employee.ToList();
        }
        //Przkierowanie do okna głównego klasy Umowa
        private void MoveToContracts(object sender, RoutedEventArgs e)
        {
            ContractGrid contractGrid = new ContractGrid();
            this.Close();
            contractGrid.Show();
        }
        //Przkierowanie do formularza dynamicznego połączenia z Trenerem
        private void NewDynamicConnectionWithTrainer(object sender, RoutedEventArgs e)
        {
            DynamicConnectionWithTrainerForm dynamicConnectionWithTrainerForm = new DynamicConnectionWithTrainerForm();
            dynamicConnectionWithTrainerForm.Show();
        }
        //Przkierowanie do formularza dynamicznego połączenia z Recepcjonistą
        private void NewDynamicConnectionWithReceptionist(object sender, RoutedEventArgs e)
        {
            DynamicConnectionWithReceptionistForm dynamicConnectionWithReceptionistForm = new DynamicConnectionWithReceptionistForm();
            dynamicConnectionWithReceptionistForm.Show();
        }
        //Przkierowanie do formularza dynamicznego połączenia z Instruktorem
        private void NewDynamicConnectionWithInstructor(object sender, RoutedEventArgs e)
        {
            DynamicConnectionWithInstructorForm dynamicConnectionWithInstructorForm = new DynamicConnectionWithInstructorForm();
            dynamicConnectionWithInstructorForm.Show();
        }
        private void LowerValue(object sender, RoutedEventArgs e)
        {
            Trener trener = new Trener();

            int ValueToLower = int.Parse(txtLowerValue.Text);
            Trener.ObnizWynagrodzenie(ValueToLower);

            string UpdateQuery = "UPDATE Pracownik Set IndywidualnaStawkaGodzinowa = IndywidualnaStawkaGodzinowa - '" + ValueToLower + "' FROM Pracownik JOIN Trener on Pracownik.IdPracownik = Trener.Pracownik_IdPracownik where Pracownik.IdPracownik = Trener.Pracownik_IdPracownik";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(UpdateQuery, conn))
                    {
                        //Otwieranie oraz wykonywanie zapytania
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Wynagrodzenie obniżone");

                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }
        }
    }
}
