using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ReceptionistAddForm.xaml
    /// </summary>
    //  <Rectangle Fill="#FFACACAC" HorizontalAlignment="Left" Height="54" Margin="56,1029,0,0" Stroke="Black" VerticalAlignment="Top" Width="594"/>
    //  <Label Content = "Pensja:" HorizontalAlignment="Left" Margin="60,1001,0,0" VerticalAlignment="Top" Foreground="White" Background="Black" FontSize="16" Height="28"/>
    //  <TextBox x:Name="txtPensja" Height="24" Margin="62,1045,72,0" TextWrapping="Wrap" VerticalAlignment="Top" FontSize="18" Foreground="Black" Background="#FFACACAC"/>
    // Formularz dodawania nowego recepcjonisty
    public partial class ReceptionistAddForm : Window
    {
        //Łączenie się z modelami oraz nawiązywanie połączenia z bazą danych
        MASDBEntities db = new MASDBEntities();
        ReceptionistGrid receptionistGrid = new ReceptionistGrid();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public ReceptionistAddForm()
        {
            InitializeComponent();
        }
        //Metoda główna dodawania recepcjonisty
        private void AddReceptionist(object sender, RoutedEventArgs e)
        {
            Recepcjonista recepcjonista = new Recepcjonista();

            //Wczytywanie infromacji z pól tekstowych

            int IdContract = int.Parse(txtIdUmowa.Text);
            decimal AccountNumber = decimal.Parse(txtNumerKontaBankowego.Text);
            decimal IndividualHourlyRate = decimal.Parse(txtIndywidualnaStawkaGodzinowa.Text);
            decimal HoursWorked = decimal.Parse(txtLiczbaGodzinPrzepracowanych.Text);
            decimal Salary = recepcjonista.GetWyngarodzenie(IndividualHourlyRate, HoursWorked, 200.0M);
            //decimal Salary = decimal.Parse(txtPensja.Text);
            int NumberOfReservations = int.Parse(txtIloscWykonanychRezerwacji.Text);

            //Szukanie Id danych osobowych

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

                        //Tworzenie nowych danych osobwych

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

            //Dodawanie nowego pracownika
            string AddEmployeeData = "Insert Into Pracownik(IdPracownik, DaneOsobowe_IdDaneOsobowe, Umowa_IdUmowa, NumerKontaBankowego, IndywidualnaStawkaGodzinowa, LiczbaGodzinPrzepracowanych, Pensja)" +
                "VALUES((SELECT MAX(IdPracownik)+1 FROM Pracownik), (SELECT MAX(IdDaneOsobowe) FROM DaneOsobowe), '" + IdContract + "', '" + AccountNumber + "', '" + IndividualHourlyRate + "', '" + HoursWorked + "', '" + Salary + "')";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(AddEmployeeData, conn))
                    {
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

            //Dodawanie nowego recepcjonisty
            string AddReceptionistData = "Insert into Recepcjonista(IdRecepcjonista, Pracownik_IdPracownik, IloscWykonanychRezerwacji)" +
                "VALUES((SELECT MAX(IdRecepcjonista)+1 FROM Recepcjonista), (SELECT MAX(IdPracownik) From Pracownik), '" + NumberOfReservations + "')";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(AddReceptionistData, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Dodano nowewgo recepcjoniste");

                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }

            this.Close();
            receptionistGrid.Show();

        }
        //Powrót do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            receptionistGrid.Show();
        }
    }
}
