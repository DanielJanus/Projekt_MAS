using MAS_Implementacja.Models;
using System;
using System.Linq;
using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy InstructorUpdateForm.xaml
    /// </summary>
    // Formularz aktualizowania informacji o instruktorze
    public partial class InstructorUpdateForm : Window
    {
        MASDBEntities db = new MASDBEntities();

        public InstructorUpdateForm()
        {
            InitializeComponent();
        }
        //Aktualizowanie instruktora
        private void UpdateInstructor(object sender, RoutedEventArgs e)
        {
            var IdInstructor = (int.Parse(txtIdInstruktoraUpdate.Text));
            var IdEmployee = (int.Parse(txtIdPracownikUpdate.Text));
            //Szukanie instruktora
            var query = from t in db.Instruktor where t.IdInstruktor == IdInstructor && t.Pracownik_IdPracownik == IdEmployee select t;

            try
            {
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano instruktora");

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
