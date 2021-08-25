using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ContractUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowanie umów

    public partial class ContractUpdateForm : Window
    {
        MASDBEntities db = new MASDBEntities();
        public ContractUpdateForm()
        {
            InitializeComponent();
        }
        //Aktualizowaie umowy
        private void UpdateContract(object sender, RoutedEventArgs e)
        {
            var num = (int.Parse(txtIdUmowaUpdate.Text));
            //Szukanie takiej umowy
            var query = from t in db.Umowa where t.IdUmowa == num select t;

            foreach (Umowa umowa in query)
            {
                umowa.RodzajUmowy = txtRodzajUmowyUpdate.Text;
                umowa.DataRozpoczeciaUmowy = DateTime.Parse(txtDataRozpoczeciaUpdate.Text);
                umowa.DataZakonczeniaUmowy = DateTime.Parse(txtDataZakonczeniaUpdate.Text);
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano umowe");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }
        //Cofanie się do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
