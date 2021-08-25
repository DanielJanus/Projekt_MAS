using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy DynamicConnectionWithReceptionistForm.xaml
    /// </summary>
    //Utworzenie dynamicznego połączenia z klasą Recepcjonista

    public partial class DynamicConnectionWithReceptionistForm : Window
    {
        //Inicjalizowanie bazy danych oraz połączenia z bazą danych
        MASDBEntities db = new MASDBEntities();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
        public DynamicConnectionWithReceptionistForm()
        {
            InitializeComponent();
        }
        //Metoda główna 
        private void CreateDynamicConnection(object sender, RoutedEventArgs e)
        {
            int IdEmployeeData = int.Parse(txtIdPraocwnik.Text);
            int NumberOfReservation = int.Parse(txtIloscRezerwacji.Text);
            //Pobieranie informacji o recepcjoniście
            string MaxIdReceptionistData = "SELECT MAX(IdRecepcjonista)+1 From Recepcjonista";
            int tmpIdReceptionist;
            //Pobieranie informacji o trenerze
            int tmpIdTrainerCount;
            string countTrainer = "Select Count(Pracownik_IdPracownik) From Trener Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            string deleteTrainer = "Delete From Trener Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            //Pobieranie informacji o instruktorze
            int tmpIdInstructor;
            string countInstructor = "Select Count(Pracownik_IdPracownik) From Instruktor Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            string deleteInstructor = "Delete From Instruktor Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            //Pobieranie informacji o pracowniku
            int tmpIdEmployeeCount;
            string CountEmployee = "Select Count(Pracownik_IdPracownik) From Recepcjonista Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(CountEmployee, conn))
                    {
                        conn.Open();
                        tmpIdEmployeeCount = (int)cmd.ExecuteScalar();
                        using (SqlCommand cmd2 = new SqlCommand(MaxIdReceptionistData, conn))
                        {
                            using (SqlCommand cmd3 = new SqlCommand(countTrainer, conn))
                            {
                                using (SqlCommand cmd4 = new SqlCommand(countInstructor, conn))
                                {
                                    tmpIdTrainerCount = (int)cmd3.ExecuteScalar();
                                    tmpIdReceptionist = (int)cmd2.ExecuteScalar();
                                    tmpIdInstructor = (int)cmd4.ExecuteScalar();


                                    //Tworzenie recepcjonisty
                                    Recepcjonista recepcjonista = new Recepcjonista()
                                    {
                                        IdRecepcjonista = tmpIdReceptionist,
                                        Pracownik_IdPracownik = IdEmployeeData,
                                        IloscWykonanychRezerwacji = NumberOfReservation
                                    };

                                    try
                                    {
                                        //Dodawanie recepcjonisty
                                        if (tmpIdEmployeeCount != 0)
                                            throw new Exception("Recepcjonista już jest o takim id");
                                        else
                                            db.Recepcjonista.Add(recepcjonista);
                                        db.SaveChanges();
                                        MessageBox.Show("Dodano dynamiczne połączenie z recepcjonistą");
                                        if (tmpIdTrainerCount != 0) //Usun trenera a jak jego nie ma usun instruktora
                                            using (SqlCommand cmd5 = new SqlCommand(deleteTrainer, conn))
                                            {
                                                try
                                                {
                                                    cmd5.ExecuteNonQuery();
                                                    MessageBox.Show("Usunięto trenera");
                                                }
                                                catch (Exception a)
                                                {
                                                    Console.WriteLine(a);
                                                }
                                            }
                                        else //Usun recepcjoniste
                                        if (tmpIdInstructor != 0)
                                            using (SqlCommand cmd6 = new SqlCommand(deleteInstructor, conn))
                                            {
                                                try
                                                {
                                                    cmd6.ExecuteNonQuery();
                                                    MessageBox.Show("Usunięto instruktora");
                                                }
                                                catch (Exception a)
                                                {
                                                    Console.WriteLine(a);
                                                }
                                            }
                                    }
                                    catch (Exception a)
                                    {
                                        Console.WriteLine(a);
                                    }
                                }
                            }
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        this.Close();
        }
        //Cofanie do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
