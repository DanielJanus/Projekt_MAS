using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy TrainingUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania treningu
    public partial class TrainingUpdateForm : Window
    {
        //Łączenie się z modelami
        MASDBEntities db = new MASDBEntities();

        public TrainingUpdateForm()
        {
            InitializeComponent();
        }
        //Aktualizowanie danych treningu
        private void UpdateTraining(object sender, RoutedEventArgs e)
        {

            var num = (int.Parse(txtIdTreningUpdate.Text));
            //Szukanie treningu
            var query = from t in db.Trening where t.IdTrening == num select t;
            //Aktualizowanie treningu
            foreach(Trening trening in query)
            {
                trening.TypTreningu_IdTypTreningu = int.Parse(txtIdTypUpdate.Text);
                trening.Recepcjonista_IdRecepcjonista = int.Parse(txtIdRecepcjonistaUpdate.Text);
                trening.Trener_IdTrener = int.Parse(txtIdTrenerUpdate.Text);
                trening.Nazwa = txtNazwaUpdate.Text;
                trening.Rodzaj = txtRodzajUpdate.Text;
                trening.Rezerwacja = bool.Parse(txtRezerwacjaUpdate.Text);
            }
            //Próba zapisu
            try
            {
                db.SaveChanges();
            }catch(Exception a)
            {
                Console.WriteLine(a);
            }
            this.Close();
            MessageBox.Show("Zaktualizowano trening");
        }
        //Powrót do poprzedniego widoku
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
