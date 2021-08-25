using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TreningForm.xaml
    /// </summary>
    // Formularz dodawania treningu
    public partial class TreningForm : Window
    {
        //Łączenie się z modelami oraz bazą danych
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;
        MASDBEntities db = new MASDBEntities();
        Training trainingPage = new Training();
        public TreningForm()
        {
            InitializeComponent();
        }
        //Powrót na stronę główną
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Cofnięcie się do poprzedniego widoku
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            trainingPage.Show();
        }
        //Dodawanie treningu
        private void AddTraining(object sender, RoutedEventArgs e)
        {
            string MaxIdTrainingValue = "SELECT MAX(IdTrening)+1 From Trening";
            int tmpIdTrainingValue;

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxIdTrainingValue, conn))
                    {
                        conn.Open();
                        tmpIdTrainingValue = (int)cmd.ExecuteScalar();

                        //Utworzenie nowego treningu

                        Trening training = new Trening()
                        {
                            IdTrening = tmpIdTrainingValue,
                            TypTreningu_IdTypTreningu = int.Parse(txtIdTyp.Text),
                            Trener_IdTrener = int.Parse(txtIdTrener.Text),
                            Recepcjonista_IdRecepcjonista = int.Parse(txtIdRecepcjonista.Text),
                            Nazwa = txtNazwa.Text,
                            Rodzaj = txtRodzaj.Text,
                            Rezerwacja = bool.Parse(txtRezerwacja.Text)
                        };
                        //Próba zapisu
                        try
                        {
                            db.Trening.Add(training);
                            db.SaveChanges();
                            MessageBox.Show("Dodano nowy trening");

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


            this.Close();
            trainingPage.Show();

        }

    }
}
