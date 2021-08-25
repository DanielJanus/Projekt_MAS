using MAS_Implementacja.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ContractsAddForm.xaml
    /// </summary>
     // Formularz dodoawanie nowej umowy

    public partial class ContractsAddForm : Window
    {
        MASDBEntities db = new MASDBEntities();
        ContractGrid contractGrid = new ContractGrid();
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public ContractsAddForm()
        {
            InitializeComponent();
        }
        //Dodawanie umowy
        private void AddContract(object sender, RoutedEventArgs e)
        {
            string MaxIdContractValue = "SELECT MAX(IdUmowa)+1 From Umowa";
            int tmpIdUmowa;
            //Łączenie z bazą danych
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(MaxIdContractValue, conn))
                    {
                        conn.Open();
                        tmpIdUmowa = (int)cmd.ExecuteScalar();

                        //Nowa umowa
                        Umowa umowa = new Umowa()
                        {
                            IdUmowa = tmpIdUmowa,
                            RodzajUmowy = txtRodzajUmowy.Text,
                            DataRozpoczeciaUmowy = DateTime.Parse(txtDataRozpoczecia.Text),
                            DataZakonczeniaUmowy = DateTime.Parse(txtDataZakonczenia.Text)
                        };


                        try
                        {
                            db.Umowa.Add(umowa);
                            db.SaveChanges();
                            MessageBox.Show("Dodano nową umowe");

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
            contractGrid.Show();

        }
        //Cofanie do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
            contractGrid.Show();
        }
    }
}
