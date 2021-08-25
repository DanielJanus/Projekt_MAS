using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy PassUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania karnetu
    public partial class PassUpdateForm : Window
    {
        MASDBEntities db = new MASDBEntities();

        public PassUpdateForm()
        {
            InitializeComponent();
        }
        //Metoda główna aktualizowania danych
        private void UpdatePassData(object sender, RoutedEventArgs e)
        {
            var passData = (int.Parse(txtNumerKarnetuUpdate.Text));

            //Szukanie konkretnego karnetu

            var query = from t in db.Karnet where t.NumerKarnetu == passData  select t;

            foreach (Karnet karnet in query)
            {
                karnet.RodzajKarnetu = txtRodzajUpdate.Text;
                karnet.NazwaKarnetu = txtNazwaUpdate.Text;
            }
            //Próba zapisania
            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano karnet");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
