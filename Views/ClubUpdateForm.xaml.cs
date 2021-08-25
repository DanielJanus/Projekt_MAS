using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;
namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ClubUpdateForm.xaml
    /// </summary>
    // Formularz dotyczące aktualizowania danych o klubie
    public partial class ClubUpdateForm : Window
    {
        ClubGrid clubGrid = new ClubGrid();
        //Inicjalizacja Modeli
        MASDBEntities db = new MASDBEntities();

        public ClubUpdateForm()
        {
            InitializeComponent();
        }
        //Aktualizowanie klubu
        private void UpdateClub(object sender, RoutedEventArgs e)
        {
            var num = (int.Parse(txtIdKlubUpdate.Text));
            var query = from t in db.Klub where t.IdKlub == num select t;

            foreach (Klub klub in query)
            {
                klub.NazwaKlubu = txtNazwaUpdate.Text;
                klub.Adres = txtAdresUpdate.Text;
                klub.TelefonSluzbowy = txtTelefonUpdate.Text;
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano klub");

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
        }
        //Wracanie do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
