using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_GroceryManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        ObservableCollection<Grocery> groceries;
        int groceryCnt;
        //DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

           // App._groceries = GenerateGroceries(6);
            //groceryCnt = App._groceries.Count();
            
        }

        private ObservableCollection<Grocery> GenerateGroceries(int cnt)
            {
                List<string> product = new List<string> { "Milk", "Musli", "Cookie", "Body Lotion", "Shampoo", "Deodrant" };
               List<string> company = new List<string> { "GutesLand", "Kellogs", "Biscoteria", "Dove", "Alpecin", "Axe" };

                var lst = new ObservableCollection<Grocery>();

                for (int i = 0; i < cnt; i++)

                {
                    int pNo = rnd.Next(product.Count);
                   // int cNo = rnd.Next(company.Count);

                    lst.Add(new Grocery
                    {
                        prodName = product[pNo],
                        prod_id = Math.Abs(Guid.NewGuid().GetHashCode()).ToString()
                    });
                }

                return lst;
            }

        private void Window_Loaded(Object sender, RoutedEventArgs e)
        {
           groceries = Stock.ReadXML<ObservableCollection<Grocery>>("GroceryList.xml");
            if (groceries == null)
            {
                groceries = new ObservableCollection<Grocery>();
                groceries = GenerateGroceries(20);
            }
            Lbx_Grocery.ItemsSource = groceries;
        }


        

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();
            var lst = from s in groceries where s.prodName.ToLower().Contains(filter) select s;
            Lbx_Grocery.ItemsSource = lst;
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Grocery groc = new Grocery
            {
                prodName = "Edit",
                prod_id = Math.Abs(Guid.NewGuid().GetHashCode()).ToString()
            };

            groceries.Add(groc);
            Lbx_Grocery.SelectedItem = groc;
            Lbx_Grocery.ScrollIntoView(groc);

        }
       
        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var itm = Lbx_Grocery.SelectedItem;
            if (itm == null)
            {
                MessageBox.Show("Please select an item to be deleted first..!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var toDelete = itm as Grocery;

            var res = MessageBox.Show($"Are you sure to delete {toDelete.prodName} ?", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (res == MessageBoxResult.OK)
                groceries.Remove(toDelete);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
                Stock.WriteXML<ObservableCollection<Grocery>>(groceries, "GroceryList.xml");
        }

        private void Lbx_Grocery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
