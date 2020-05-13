using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaraMcDonagh_S00185883
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.PhoneDetails
                        select p;

            lbxPhones.ItemsSource = query.ToList();
        }

        private void lbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Check the selected phone
            Phone selectedPhone = lbxPhones.SelectedItem as Phone;
            if (selectedPhone != null)
            {
                //Selecting a phone will show the price for that phone on the right. (10 marks)

                txtbxPrice.Text = selectedPhone.Price.ToString();
                //Display the phone image when the phone is selected. (10 marks)
                //BitmapImage bitmap = new BitmapImage();
                //bitmap.BeginInit();
                //bitmap.UriSource = new Uri(selectedPhone.Phone_Image);

            }
        }
    }
}
