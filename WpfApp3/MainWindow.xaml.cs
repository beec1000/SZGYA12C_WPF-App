using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnKesz_Click(object sender, RoutedEventArgs e)
        {
            
            if ((bool)feltetelekchb.IsChecked) 
            {
                f1lb.IsEnabled = true;
                f2cb.IsEnabled = true;
                f3chb.IsEnabled = true;
                f4rb.IsEnabled = true;
                f5tb.IsEnabled = true;
            }

            vlsz1.Content = ((ListBoxItem)f1lb.SelectedItem).Content;

            vlsz2.Content = ((ComboBoxItem)f2cb.SelectedItem).Content;

            vlsz3.Items.Clear();
            foreach (CheckBox i in f3chb.Children)
            {
                if ((bool)i.IsChecked)
                {
                    vlsz3.Items.Add(i.Content);
                }
            }

            foreach (RadioButton i in f4rb.Children)
            {
                if ((bool)i.IsChecked)
                {
                    vlsz4.Content = i.Content;
                }
                else
                {
                    vlsz4.Content = "";
                }
            }

            if (f5tb.Text == null)
            {
                vlsz5.Content = null;
            }
            else
            {
                vlsz5.Content = f5tb.Text;
            }

            MessageBox.Show($"Kedves {nevTB.Text}! Szeretné továbbítani eredményeit a(z) {emailTB.Text} email címére?", "Eredmények", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            
        }
    }
}