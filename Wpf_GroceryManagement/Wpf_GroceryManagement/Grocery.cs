using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_GroceryManagement
{
    public class Grocery : INotifyPropertyChanged
    {
        public string prodName { get; set; }
        public string prod_id { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        // public string name { get { return $"{prodName}"; } }
        public string prod_name { get; set; }
        public string Myproperty { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        }
}
