using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy SchoolingAddForm.xaml
    /// </summary>
    // Formularz dodawania nowego szkolenia
    public partial class SchoolingAddForm : Window
    {
        //Łączenie się z modelami oraz bazą danych
        SchoolingGrid schoolingGrid = new SchoolingGrid();
        MASDBEntities db = new MASDBEntities();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public SchoolingAddForm()
        {
            InitializeComponent();
        }
        //Główna metoda dodawania szkolenia
        private void AddSchooling(object sender, RoutedEventArgs e)
        {
            string MaxIdSchooligValue = "SELECT MAX(IdSzkolenie)+1 From Szkolenie";
            int tmpIdSchooling;

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxIdSchooligValue, conn))
                    {
                        conn.Open();
                        tmpIdSchooling = (int)cmd.ExecuteScalar();
                        //Tworzenie nowego szkolenia
                        Szkolenie schooling = new Szkolenie()
                        {
                            IdSzkolenie = tmpIdSchooling,
                            Instruktor_IdInstruktor = int.Parse(txtIdInstruktora.Text),
                            Nazwa = txtNazwa.Text,
                            DataSzkolenia = DateTime.Parse(txtDataSzkolenia.Text),
                            IloscOsob = int.Parse(txtIloscOsob.Text),
                            CzasTrwania = decimal.Parse(txtCzasTrwania.Text),
                            Koszt = decimal.Parse(txtKoszt.Text)
                        };

                        try
                        {
                            //Ograniczenie
                            if (schooling.IloscOsob < 5 || schooling.Koszt > 1000)
                                throw new Exception("Ilosc osób albo koszt przekracza ograniczenie");
                            else
                            db.Szkolenie.Add(schooling);
                            db.SaveChanges();
                            MessageBox.Show("Dodano nowe szkolenie");

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
            schoolingGrid.Show();

        }
        //Wróć do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            schoolingGrid.Show();
        }
    }
}
