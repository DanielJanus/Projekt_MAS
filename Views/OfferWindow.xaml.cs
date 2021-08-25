using System.Windows;

namespace MAS_Implementacja.Views
{
    /// <summary>
    /// Logika interakcji dla klasy OfferWindow.xaml
    /// </summary>
    // Okno z ofertami dla klienta
    public partial class OfferWindow : Window
    {
        NewClientAddForm newClientAddForm = new NewClientAddForm();

        public OfferWindow()
        {
            InitializeComponent();
        }
        //Przekierowanie do strony głównej
        private void OpenMainPage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Przekierowanie do formularza dodawania nowego klienta
        private void MoveToReducedAddForm(object sender, RoutedEventArgs e)
        {
            this.Close();
            newClientAddForm.Show();
        }
        //Przekierowanie do formularza dodawania nowego klienta
        private void MoveToStudentAddForm(object sender, RoutedEventArgs e)
        {
            this.Close();
            newClientAddForm.Show();
        }
        //Przekierowanie do formularza dodawania nowego klienta
        private void ShowNormalAddForm(object sender, RoutedEventArgs e)
        {
            this.Close();
            newClientAddForm.Show();
        }
        //Powrót do strony głównej
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
