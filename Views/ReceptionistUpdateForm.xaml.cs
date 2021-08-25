using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ReceptionistUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania recepcjonisty
    public partial class ReceptionistUpdateForm : Window
    {
        MASDBEntities db = new MASDBEntities();

        public ReceptionistUpdateForm()
        {
            InitializeComponent();
        }
        //Metoda główna aktualizowania
        private void UpdateReceptionist(object sender, RoutedEventArgs e)
        {
            var IdReceptionist = (int.Parse(txtIdRecepcjonistyUpdate.Text));
            var IdEmployee = (int.Parse(txtIdPracownikaUpdate.Text));

            var query = from t in db.Recepcjonista where t.IdRecepcjonista == IdReceptionist && t.Pracownik_IdPracownik == IdEmployee select t;

            foreach (Recepcjonista recepcjonista in query)
            {
                recepcjonista.IloscWykonanychRezerwacji = int.Parse(txtIloscRezerwacjiUpdate.Text);
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano trenera");

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