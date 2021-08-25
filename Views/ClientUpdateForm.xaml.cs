using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ClientUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania bazy danych dla klasy klient
    public partial class ClientUpdateForm : Window
    {
        MASDBEntities db = new MASDBEntities();

        public ClientUpdateForm()
        {
            InitializeComponent();
        }
        //Główna metoda aktualizująca
        private void UpdateClientData(object sender, RoutedEventArgs e)
        {
            var clientData = (int.Parse(txtIdKlientUpdate.Text));
            var personalData = (int.Parse(txtIdDaneUpdate.Text));

            //Szukanie klienta który ma takie samo id i dane osobowe jakie wpisaliśmy

            var query = from t in db.Klient where t.IdKlient == clientData && t.DaneOsobowe_IdDaneOsobowe == personalData select t;

            foreach (Klient klient in query)
            {
                klient.RodzajDokumentuOsobistego = txtRodzajDokumentuUpdate.Text;
                klient.ZaswiadczenieOdLekarza = bool.Parse(txtZaswiadczenieUpdate.Text);
                klient.ZgodaDotyczacaRegulaminuKlubu = bool.Parse(txtZgodaUpdate.Text);

            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano klienta");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }
        //Cofanie do poprzedniego okna
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
