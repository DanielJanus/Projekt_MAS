using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy EquipmentUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania klasy MaszynyWKlubie
    public partial class EquipmentUpdateForm : Window
    {
        //Tworzenie połączenia z modelami oraz z bazą danych
        MASDBEntities db = new MASDBEntities();
        EquipmentClubGrid equipmentClubGrid = new EquipmentClubGrid();
        public EquipmentUpdateForm()
        {
            InitializeComponent();
        }
        //Główna metoda aktualizowania
        private void UpdateEquipment(object sender, RoutedEventArgs e)
        {
            {
                var num = (int.Parse(txtIdNumeruUpdate.Text));
                var query = from t in db.MaszynyWKlubie where t.NumerIdentyfikacyjny == num select t;

                foreach (MaszynyWKlubie maszynyWKlubie in query)
                {
                    maszynyWKlubie.Klub_IdKlub = int.Parse(txtIdKlubuUpdate.Text);
                    maszynyWKlubie.Nazwa = txtNazwaUpdate.Text;
                    maszynyWKlubie.Zastosowanie = txtZastosowanieUpdate.Text;
                    maszynyWKlubie.OstatniaDataKonserwacji = DateTime.Parse(txtOstatniaDataUpdate.Text);
                    maszynyWKlubie.ZaplanowanaDataKonserwacji = DateTime.Parse(txtZaplanowanaDataUpdate.Text);
                }
                //Próba zapisania
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Zaktualizowano wyposażenie do klubu");

                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
                }
                this.Close();
                equipmentClubGrid.Show();
            }
        }
        //Cofanie do okna głównego
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
