using System.Windows;

namespace MyWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string age = AgeTextBox.Text;
            MessageBox.Show($"Name: {name}, Age: {age}", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
