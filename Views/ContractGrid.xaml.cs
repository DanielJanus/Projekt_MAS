using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ContractGrid.xaml
    /// </summary>
    // Główno okno dotyczące klasy Umowa
    public partial class ContractGrid : Window
    {
        MASDBEntities db = new MASDBEntities();

        public ContractGrid()
        {
            InitializeComponent();
        }
        //Przkierowanie do okna głównego klasy Pracownik
        private void MoveToEmployee(object sender, RoutedEventArgs e)
        {
            EmployeeGrid employeeGrid = new EmployeeGrid();
            this.Close();
            employeeGrid.Show();
        }
        //Przkierowanie do strony głównej
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przkierowanie do okna głównego klasy Trening
        private void ViewTrainings(object sender, RoutedEventArgs e)
        {
            Training training = new Training();
            this.Close();
            training.Show();
        }
        //Przkierowanie do okna głównego klasy Szkolenia
        private void VievSchoolings(object sender, RoutedEventArgs e)
        {
            SchoolingGrid schoolingGrid = new SchoolingGrid();
            this.Close();
            schoolingGrid.Show();
        }
        //Przkierowanie do okna głównego klasy DaneOsobowe
        private void PersonalData(object sender, RoutedEventArgs e)
        {
            PersonalDataGrid personalDataGrid = new PersonalDataGrid();
            this.Close();
            personalDataGrid.Show();
        }
        //Przkierowanie do okna głównego klasy Umowa
        private void AddContract(object sender, RoutedEventArgs e)
        {
            ContractsAddForm contractsAddForm = new ContractsAddForm();
            this.Close();
            contractsAddForm.Show();
        }
        //Przekierowanie do formularza aktualizowania umowy
        private void UpdateContract(object sender, RoutedEventArgs e)
        {
            ContractUpdateForm contractUpdateForm = new ContractUpdateForm();
            contractUpdateForm.Show();
        }
        //Wczytywanie danych umów
        private void LoadContracts(object sender, RoutedEventArgs e)
        {
            var contracts = from t in db.Umowa
                        select new
                        {
                            IdUmowa = t.IdUmowa,
                            RodzajUmowy = t.RodzajUmowy,
                            DataRozpoczeciaUmowy = t.DataRozpoczeciaUmowy,
                            DataZakonczeniaUmowy = t.DataZakonczeniaUmowy,
                        };

            this.gridContracts.ItemsSource = contracts.ToList();
        }
        //Usuwanie umowy
        private void DeleteContract(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("Jesteś pewien że chcesz usunąć umowe?", "Usun umowe", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);

            if (msgBoxResult == MessageBoxResult.Yes)
            {
                int toDelete = int.Parse(txtIdContractDelete.Text);
                Umowa umowa = (from t in db.Umowa where t.IdUmowa == toDelete select t).SingleOrDefault();
                try
                {
                    db.Umowa.Remove(umowa);
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
