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

namespace egazmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dane dane = new Dane();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = dane;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dane.Paczka == true)
            {
                fota.Source = new BitmapImage(new Uri(@"E:\visual studio\egazmin\egazmin\paczka.jpg"));
                cena.Content = "Cena: 10 zł";
            }
            else if (dane.Pocztowka == true)
            {
                fota.Source = new BitmapImage(new Uri(@"E:\visual studio\egazmin\egazmin\pocztówka.png"));
                cena.Content = "Cena: 1 zł";
            }
            else if (dane.List == true)
            {
                fota.Source = new BitmapImage(new Uri(@"E:\visual studio\egazmin\egazmin\list.jpg"));
                cena.Content = "Cena: 1,5 zł";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int numericValue;
            bool isNumber = int.TryParse(dane.KodPocztowy, out numericValue);

            if (dane.KodPocztowy.Length > 5 || dane.KodPocztowy.Length < 5 || dane.KodPocztowy == null)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if(isNumber == false)
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
        }
    }
}