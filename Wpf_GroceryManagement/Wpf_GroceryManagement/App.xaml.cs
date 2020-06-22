using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_GroceryManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    //    public static ObservableCollection<Grocery> _groceries;y
    //    Random rnd = new Random(Guid.NewGuid().GetHashCode());
    //    public App() { }
         
    //    private void Application_Startup(Object sender, StartupEventArgs e)
    //    {
    //        _groceries = Stock.ReadXML<ObservableCollection<Grocery>>("grocery.xml");
    //        if(_groceries == null)
    //        {
    //            _groceries = new ObservableCollection<Grocery>();
    //        }
    //    }

    //    private ObservableCollection<Grocery>

    //        GenerateGroceries(int cnt)
    //    {
    //        List<string> product = new List<string> { "Milk", "Musli", "Cookie", "Body Lotion", "Shampoo", "Deodrant"};
    //        List<string> company = new List<string> { "GutesLand", "Kellogs", "Biscoteria", "Dove", "Alpecin", "Axe"};

    //        var lst = new ObservableCollection<Grocery>();
    //        cnt = 6; 
    //        for (int i = 0; i < cnt; i++)

    //        {
     //           int pNo = rnd.Next(product.Count);
     //           int cNo = rnd.Next(company.Count);
     //           
     //           lst.Add(new Grocery{ prodName = product[pNo],  
     //               prod_id = Math.Abs(Guid.NewGuid().GetHashCode()).ToString()});
     //       }

     //       return lst;
     //   }

     //   private void Application_Exit(object sender, ExitEventArgs e)
     //   {
     //       Stock.WriteXML<ObservableCollection<Grocery>>(_groceries, "grocery.xml");
     //   }

    }
}
