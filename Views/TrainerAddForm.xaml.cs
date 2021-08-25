using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TrainerAddForm.xaml
    /// </summary>
    //  <Rectangle Fill="#FFACACAC" HorizontalAlignment="Left" Height="54" Margin="58,1027,0,0" Stroke="Black" VerticalAlignment="Top" Width="594"/>
    //  <Label Content = "Pensja:" HorizontalAlignment="Left" Margin="62,999,0,0" VerticalAlignment="Top" Foreground="White" Background="Black" FontSize="16" Height="28"/>
    //  <TextBox x:Name="txtPensja" Height="24" Margin="64,1043,70,0" TextWrapping="Wrap" VerticalAlignment="Top" FontSize="18" Foreground="Black" Background="#FFACACAC"/> 
    // Formularz dodawania nowego Trenera

    public partial class TrainerAddForm : Window
    {
        //Łączenie się z bazą danych oraz modelami
        MASDBEntities db = new MASDBEntities();
        TrainerGrid trainerGrid = new TrainerGrid();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public TrainerAddForm()
        {
            InitializeComponent();
        }
        //Metoda główna dodawania nowego trenera
        private void AddTrainer(object sender, RoutedEventArgs e)
        {
            //Tworzenie nowego trenera
            Trener trener = new Trener();

            //Wczytywanie informacji z pól tekstowych
            int IdContract = int.Parse(txtIdUmowa.Text);
            decimal AccountNumber = decimal.Parse(txtNumerKontaBankowego.Text);
            decimal IndividualHourlyRate = decimal.Parse(txtIndywidualnaStawkaGodzinowa.Text);
            decimal HoursWorked = decimal.Parse(txtLiczbaGodzinPrzepracowanych.Text);
            decimal Salary = trener.GetWyngarodzenie(IndividualHourlyRate, HoursWorked, 300.0M);
            //decimal Salary = decimal.Parse(txtPensja.Text);
            string WorkoutOnOffer = txtOferowaneTreningi.Text;
            bool RightToJob = bool.Parse(txtPrawo.Text);

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
            //Wstawianie nowego pracownika
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

            //Wstawianie nowego trenera
            string AddTrainerData = "Insert Into Trener(IdTrener, Pracownik_IdPracownik, OferowaneTreningi, PrawoWykonywaniaZawodu, ZaswiadczenieONiekaralnosci)" +
                "VALUES((SELECT MAX(IdTrener)+1 FROM Trener), (SELECT MAX(IdPracownik) FROM PRACOWNIK), '" + WorkoutOnOffer + "', '" + RightToJob + "', 'true')";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(AddTrainerData, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Dodano nowewgo trenera");

                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }


            this.Close();
            trainerGrid.Show();

        }
        //Cofanie się do ekranu głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            trainerGrid.Show();
        }
    }
}
