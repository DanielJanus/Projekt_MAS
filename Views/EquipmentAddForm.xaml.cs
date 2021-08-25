using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy EquipmentAddForm.xaml
    /// </summary>
    // Formularz dodawania nowego wyposażenia 
    public partial class EquipmentAddForm : Window
    {
        //Wczytywanie modeli oraz połączenia bazą danych
        MASDBEntities db = new MASDBEntities();
        EquipmentClubGrid equipmentClub = new EquipmentClubGrid();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public EquipmentAddForm()
        {
            InitializeComponent();
        }
        //Dodawanie wyposażenia
        private void AddEquipment(object sender, RoutedEventArgs e)
        {
            string MaxIdEquipmentValue = "SELECT MAX(NumerIdentyfikacyjny)+1 From MaszynyWKlubie";
            int tmpIdEquipment;

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxIdEquipmentValue, conn))
                    {
                        conn.Open();
                        tmpIdEquipment = (int)cmd.ExecuteScalar();

                        //Dodawanie nowej maszyny

                        MaszynyWKlubie maszynyWKlubie = new MaszynyWKlubie()
                        {
                            NumerIdentyfikacyjny = tmpIdEquipment,
                            Klub_IdKlub = int.Parse(txtIdKlubu.Text),
                            Nazwa = txtNazwa.Text,
                            Zastosowanie = txtZastosowanie.Text,
                            OstatniaDataKonserwacji = DateTime.Parse(txtOstatniaData.Text),
                            ZaplanowanaDataKonserwacji = DateTime.Parse(txtZaplanowanaData.Text)
                        };
                        //Próba dodania i zapisania zmian
                        try
                        {
                            db.MaszynyWKlubie.Add(maszynyWKlubie);
                            db.SaveChanges();
                            MessageBox.Show("Dodano nowe wyposażenie");

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
            equipmentClub.Show();

        }
        //Powrót do poprzedniego okna
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            equipmentClub.Show();
        }
    }
}
