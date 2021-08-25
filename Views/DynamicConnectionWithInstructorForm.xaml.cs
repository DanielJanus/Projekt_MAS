using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy DynamicConnectionWithInstructorForm.xaml
    /// </summary>
    // Dynamiczne utworzenie połączenie z klasą Instruktor
    public partial class DynamicConnectionWithInstructorForm : Window
    {
        MASDBEntities db = new MASDBEntities();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
        public DynamicConnectionWithInstructorForm()
        {
            InitializeComponent();
        }
        //Cofanie do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Tworzenie połączenia
        private void CreateDynamicConnection(object sender, RoutedEventArgs e)
        {

            int IdEmployeeData = int.Parse(txtIdPraocwnik.Text);
            //Szukanie Id osoby
            string MaxIdInstructorData = "SELECT MAX(IdInstruktor)+1 From Instruktor";

            int tmpIdInstrucotrData;

            //Pobieranie informacji o Pracownikach
            int tmpIdEmployeeCount;
            string CountEmployee = "Select Count(Pracownik_IdPracownik) From Instruktor Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";

            //Pobieranie informacji o Trenerze
            int tmpIdTrainerCount;
            string countTrainer = "Select Count(Pracownik_IdPracownik) From Trener Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            string deleteTrainer = "Delete From Trener Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";

            //Pobieranie informacji o recepcjoniscie
            int tmpIdReceptionistCount;
            string countReceptionist = "Select Count(Pracownik_IdPracownik) From Recepcjonista Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            string deleteReceptionist = "Delete From Recepcjonista Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(CountEmployee, conn))
                    {
                        conn.Open();
                        tmpIdEmployeeCount = (int)cmd.ExecuteScalar();
                        using (SqlCommand cmd2 = new SqlCommand(MaxIdInstructorData, conn))
                        {
                            using (SqlCommand cmd3 = new SqlCommand(countTrainer, conn))
                            {
                                tmpIdTrainerCount = (int)cmd3.ExecuteScalar();
                                using (SqlCommand cmd4 = new SqlCommand(countReceptionist, conn))
                                {
                                    tmpIdReceptionistCount = (int)cmd4.ExecuteScalar();
                                    tmpIdInstrucotrData = (int)cmd2.ExecuteScalar();

                                    Instruktor instruktor = new Instruktor()
                                    {
                                        IdInstruktor = tmpIdInstrucotrData,
                                        Pracownik_IdPracownik = IdEmployeeData,
                                    };

                                    try
                                    {
                                        //Zapisywanie do bazy danych
                                        if (tmpIdEmployeeCount != 0)
                                            throw new Exception("Instruktor już jest o takim id");
                                        else
                                            db.Instruktor.Add(instruktor);
                                        db.SaveChanges();
                                        MessageBox.Show("Dodano dynamiczne połączenie z instruktorem");
                                        if (tmpIdTrainerCount != 0) //Usun trenera a jak jego nie ma usun recepcjoniste
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
                                        if (tmpIdReceptionistCount != 0)
                                            using (SqlCommand cmd6 = new SqlCommand(deleteReceptionist, conn))
                                            {
                                                try
                                                {
                                                    cmd6.ExecuteNonQuery();
                                                    MessageBox.Show("Usunięto recepcjoniste");
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
                        }
                        conn.Close();
                    }
                }
            }
            catch (SqlException a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }

    }
}
