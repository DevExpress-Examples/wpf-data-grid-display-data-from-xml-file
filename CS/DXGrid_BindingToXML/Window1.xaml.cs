using System.Windows;
using System.Data;

namespace DXGrid_BindingToXML {
  
    public partial class Window1 : Window {
        static string path = @"..\..\Contacts.xml";
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = GetDataFromXML();
        }
        private DataTable GetDataFromXML() {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            return ds.Tables[0];
        }
        private void PostDataToXML() {
            ((DataTable)grid.ItemsSource).DataSet.WriteXml(path);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            PostDataToXML();
            MessageBox.Show("Changes have been successfully saved to an XML file.", "Info");
        }
    }
   
}
