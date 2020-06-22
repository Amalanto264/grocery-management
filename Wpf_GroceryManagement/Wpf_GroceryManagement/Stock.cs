using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Wpf_GroceryManagement
{
   public class Stock
    {
        public static void WriteXML<T>(T data, string file)
        {
            try
            {
                XmlSerializer sr = new
                    XmlSerializer(typeof(T));

                FileStream stream;

                stream = new FileStream(file, FileMode.Create);
                sr.Serialize(stream, data);
                stream.Close();
                //Making sure that file is closed and does'nt cause any issue while deleting
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Error");
                throw;
            }
        }

        public static T ReadXML<T>(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    //(T) cast it
                    return (T)
                        serializer.Deserialize(sr);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Error");
                return default(T);
            }
        }

    }
}
