using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy InstructorAddForm.xaml
    /// </summary>
    //  <Rectangle Fill="#FFACACAC" HorizontalAlignment="Left" Height="54" Margin="56,1029,0,0" Stroke="Black" VerticalAlignment="Top" Width="594"/>
    //  <Label Content = "Pensja:" HorizontalAlignment="Left" Margin="60,1001,0,0" VerticalAlignment="Top" Foreground="White" Background="Black" FontSize="16" Height="28"/>
    //  <TextBox x:Name="txtPensja" Height="24" Margin="62,1045,72,0" TextWrapping="Wrap" VerticalAlignment="Top" FontSize="18" Foreground="Black" Background="#FFACACAC"/>
    // Formularz dodawania nowego instruktora
    public partial class InstructorAddForm : Window
    {
        //Tworzenie połączenia z modelami oraz z bazą danych
        MASDBEntities db = new MASDBEntities();
        InstructorGrid instructorGrid = new InstructorGrid();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public InstructorAddForm()
        {
            InitializeComponent();
        }
        //Formularz dodawania nowego instruktora
        private void AddInstructor(object sender, RoutedEventArgs e)
        {
            Instruktor instruktor = new Instruktor();

            int IdContract = int.Parse(txtIdUmowa.Text);
            decimal AccountNumber = decimal.Parse(txtNumerKontaBankowego.Text);
            decimal IndividualHourlyRate = decimal.Parse(txtIndywidualnaStawkaGodzinowa.Text);
            decimal HoursWorked = decimal.Parse(txtLiczbaGodzinPrzepracowanych.Text);
            decimal Salary = instruktor.GetWyngarodzenie(IndividualHourlyRate, HoursWorked, 100.0M);
            //decimal Salary = decimal.Parse(txtPensja.Text);

            //Szukanie maksymalnego ID DanychOsobowych
            string MaxIdPersonalData = "SELECT MAX(IdDaneOsobowe)+1 From DaneOsobowe";
            int tmpIdPersonal;

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxIdPersonalData, conn))
                    {
                        conn.Open();
                        tmpIdPersonal = (int)cmd.ExecuteScalar();

                        //Nowe DaneOsobowe

                        DaneOsobowe daneOsobowe = new DaneOsobowe()
                        {
                            IdDaneOsobowe = tmpIdPersonal,
                            Imie = txtImie.Text,
                            Nazwisko = txtNazwisko.Text,
                            DataUrodzenia = DateTime.Parse(txtDataUrodzenia.Text),
                            AdresEmail = txtAdresEmail.Text,
                            TelefonKontaktowy = txtTelefon.Text,
                            AdresZamieszkania = txtAdresZamieszkania.Text,
                            PESEL = decimal.Parse(txtPesel.Text)
                        };

                        try
                        {
                            db.DaneOsobowe.Add(daneOsobowe);
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
            //Wstawianie nowego pracownika
            string AddEmployeeData = "Insert Into Pracownik(IdPracownik, DaneOsobowe_IdDaneOsobowe, Umowa_IdUmowa, NumerKontaBankowego, IndywidualnaStawkaGodzinowa, LiczbaGodzinPrzepracowanych, Pensja)" +
                "VALUES((SELECT MAX(IdPracownik)+1 FROM Pracownik), (SELECT MAX(IdDaneOsobowe) FROM DaneOsobowe), '" + IdContract + "', '" + AccountNumber + "', '" + IndividualHourlyRate + "', '" + HoursWorked + "', '" + Salary + "')";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(AddEmployeeData, conn))
                    {
                        //Otwieranie oraz wykonywanie zapytania
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }

            //Wstawianie nowego instruktora
            string AddInstructorData = "Insert into Instruktor(IdInstruktor, Pracownik_IdPracownik)" +
                "VALUES((SELECT MAX(IdInstruktor)+1 FROM Instruktor), (SELECT MAX(IdPracownik) FROM Pracownik))";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(AddInstructorData, conn))
                    {
                        //Otwieranie oraz wykonywanie zapytania
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Dodano nowewgo instruktora");

                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }

            this.Close();
            instructorGrid.Show();

        }
        //Cofanie do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            instructorGrid.Show();
        }

    }
}
