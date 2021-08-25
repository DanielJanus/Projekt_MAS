using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy DynamicConnectionWithTrainerForm.xaml
    /// </summary>
    // Tworzenie dynamicznego połączenia z klasą trener

    public partial class DynamicConnectionWithTrainerForm : Window
    {
        //Inicjalizowanie modeli oraz połączenia bazą danych
        MASDBEntities db = new MASDBEntities();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public DynamicConnectionWithTrainerForm()
        {
            InitializeComponent();
        }
        //Metoda główna dodawania
        private void AddDynamicConnection(object sender, RoutedEventArgs e)
        {
            //Pola tekstowe z formularza
            int IdEmployeeData = int.Parse(txtIdPracownik.Text);
            string WorkoutsOnOffer = txtOferowaneTreningi.Text;
            bool RightToPractiseProfession = bool.Parse(txtPrawo.Text);
            //Pobieranie informacji o trenerze
            string MaxIdTrainerData = "SELECT MAX(IdTrener)+1 From Trener";
            int tmpIdTrainer;
            //Pobieranie informacji o pracowniku
            int tmpIdEmployeeCount;
            string CountEmployee = "Select Count(Pracownik_IdPracownik) From Trener Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            //Pobieranie informacji o instruktorze
            string countInstructor = "Select Count(Pracownik_IdPracownik) From Instruktor Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            int tmpIdInstructor;
            string deleteInstructor = "Delete From Instruktor Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            //Pobieranie informacji o recepcjoniscie
            int tmpIdReceptionistCount;
            string countReceptionist = "Select Count(Pracownik_IdPracownik) From Recepcjonista Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";
            string deleteReceptionist = "Delete From Recepcjonista Where Pracownik_IdPracownik = '" + IdEmployeeData + "'";


            //Próbowanie utworzenia trenera
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(CountEmployee, conn))
                    {
                        conn.Open();
                        tmpIdEmployeeCount = (int)cmd.ExecuteScalar();
                        using (SqlCommand cmd2 = new SqlCommand(MaxIdTrainerData, conn))
                        {
                            using (SqlCommand cmd3 = new SqlCommand(countReceptionist, conn))
                            {
                                using (SqlCommand cmd4 = new SqlCommand(countInstructor, conn))
                                {
                                    tmpIdTrainer = (int)cmd2.ExecuteScalar();
                                    tmpIdReceptionistCount = (int)cmd3.ExecuteScalar();
                                    tmpIdInstructor = (int)cmd4.ExecuteScalar();

                                    Trener trener = new Trener()
                                    {
                                        IdTrener = tmpIdTrainer,
                                        Pracownik_IdPracownik = IdEmployeeData,
                                        OferowaneTreningi = WorkoutsOnOffer,
                                        PrawoWykonywaniaZawodu = RightToPractiseProfession,
                                        ZaswiadczenieONiekaralnosci = true
                                    };

                                    try
                                    {
                                        //Dodawanie trenera
                                        if (tmpIdEmployeeCount != 0)
                                            throw new Exception("Trener już jest o takim id");
                                        else
                                            db.Trener.Add(trener);
                                        db.SaveChanges();
                                        MessageBox.Show("Dodano dynamiczne połączenie z trenerem");
                                        if (tmpIdInstructor != 0) //Usun instruktora a jak jego nie ma usun recepcjoniste
                                            using (SqlCommand cmd5 = new SqlCommand(deleteInstructor, conn))
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
