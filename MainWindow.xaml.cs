using Microsoft.Identity.Client;
using p4projekt3.Model;
using p4projekt3.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace p4projekt3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public KierowcaViewModel Kierowca { get; set; }
        public AutobusViewModel Autobus { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        // private void Button_Click_kierowca(object sender, RoutedEventArgs e)
        // {
        //     KierowcaModel kierowca = new KierowcaModel()
        //     {
        //         FirstName = ImieTextBox.Text,
        //         LastName = NazwiskoTextBox.Text,
        //         Nr_tel = int.Parse(NrTelTextBox.Text),
        //         Adres = AdresTextBox.Text,
        //         Data_ur = Data_urTextBox.SelectedDate.Value
        //     };
        //
        //     using (var dbContext = new WorkDBContext())
        //     {
        //         dbContext.Kierowca.Add(kierowca);
        //         dbContext.SaveChanges();
        //     }
        //
        //     ImieTextBox.Text = string.Empty;
        //     NazwiskoTextBox.Text = string.Empty;
        //     NrTelTextBox.Text = string.Empty;
        //     AdresTextBox.Text = string.Empty;
        //     Data_urTextBox.SelectedDate = null;
        //
        //     MessageBox.Show("Kierowca został dodany.");
        // }
        //
        // private void Button_Click_autobus(object sender, TextChangedEventArgs e)
        // {
        //     AutobusModel autobus = new AutobusModel()
        //     {
        //         Nr_rejestracji = Nr_rejestracjiTextBox.Text,
        //         Model = ModelTextBox.Text,
        //         Marka = MarkaTextBox.Text,
        //         Rocznik = RocznikDatePicker.Text
        //     };
        //
        //
        //
        //     using (var dbContext = new WorkDBContext())
        //     {
        //         dbContext.Autobus.Add(autobus);
        //         dbContext.SaveChanges();
        //     }
        //     Nr_rejestracjiTextBox.Text = string.Empty;
        //     ModelTextBox.Text = string.Empty;
        //     MarkaTextBox.Text = string.Empty;
        //     RocznikDatePicker.SelectedDate = null;
        //     KierowcyListBox.SelectedItems.Clear();
        //
        //     MessageBox.Show("Autobus został dodany.");
        // }

    }
}
