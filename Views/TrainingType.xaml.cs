using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TrainingType.xaml
    /// </summary>
    // Formularz dodawania nowego typu treningu
    public partial class TrainingType : Window
    {
        //Łączenie się z bazą danych oraz modelami
        MASDBEntities db = new MASDBEntities();
        TrainingTypeGrid trainingTypeGrid = new TrainingTypeGrid();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public TrainingType()
        {
            InitializeComponent();
        }
        //Dodawanie treningu
        private void AddTrainingType(object sender, RoutedEventArgs e)
        {
            string MaxIdTypeTraining = "SELECT MAX(IdTypTreningu)+1 From TypTreningu";
            int tmpIdTypeTraining;

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxIdTypeTraining, conn))
                    {
                        conn.Open();
                        tmpIdTypeTraining = (int)cmd.ExecuteScalar();
                        //Dodawanie nowego treningu
                        TypTreningu typTreningu = new TypTreningu()
                        {
                            IdTypTreningu = tmpIdTypeTraining,
                            NazwaTypuTreningu = txtNazwaTypu.Text,
                            LiczbaSerii = int.Parse(txtLiczbaSerii.Text),
                            LiczbaPowtorzen = int.Parse(txtLiczbaPowtorzen.Text),
                            MetodaTreningowa = txtMetodaTreningowa.Text,
                            AkcesoriaTreningowe = txtAkcesoriaTreningowe.Text,
                            MaszynyDoTreninguSilowego = txtMaszynySilowe.Text,
                            MaszynyCardio = txtMaszynyCardio.Text,
                            WyposazenieCardioFitness = txtWyposazenieCardioFitness.Text
                        };
                        //Próba zapisu
                        try
                        {
                            db.TypTreningu.Add(typTreningu);
                            db.SaveChanges();
                            MessageBox.Show("Dodano nowy typ treningowy");

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
            trainingTypeGrid.Show();

        }
    
        //Cofanie się do poprzedniego widoku
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            trainingTypeGrid.Show();
        }
    }
}
