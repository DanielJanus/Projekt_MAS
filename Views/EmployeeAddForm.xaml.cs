using MAS_Implementacja.Models;
using System;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy EmployeeAddForm.xaml
    /// </summary>
    // Formularz dodawania nowego pracownika

    public partial class EmployeeAddForm : Window
    {
        //Łączenie się z modelami
        MASDBEntities db = new MASDBEntities();
        EmployeeGrid employeeGrid = new EmployeeGrid();
        public EmployeeAddForm()
        {
            InitializeComponent();
        }
        //Główna metoda dodawania pracownika
        private void AddEmployeeData(object sender, RoutedEventArgs e)
        {
            Pracownik pracownik = new Pracownik()
            {
                IdPracownik = int.Parse(txtIdPracownika.Text),
                Umowa_IdUmowa = int.Parse(txtIdUmowa.Text),
                DaneOsobowe_IdDaneOsobowe = int.Parse(txtIdDane.Text),
                NumerKontaBankowego = decimal.Parse(txtNumerKonta.Text),
                IndywidualnaStawkaGodzinowa = decimal.Parse(txtIndywidualnaStawka.Text),
                LiczbaGodzinPrzepracowanych = decimal.Parse(txtLiczbaGodzin.Text),
                Pensja = decimal.Parse(txtPensja.Text)
            };
            //Próba dodania Pracownika
            try
            {
                db.Pracownik.Add(pracownik);
                db.SaveChanges();
                MessageBox.Show("Dodano nowe dane pracownika");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }

            this.Close();
            employeeGrid.Show();

        }
        //Wraca do okna głównego Pracowników
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            employeeGrid.Show();
        }
    }
}
