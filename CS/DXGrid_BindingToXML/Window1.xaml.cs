using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Data;

namespace DXGrid_BindingToXML {
    #region #1
    public partial class Window1 : Window {
        static string path = @"..\..\Contacts.xml";
        public Window1() {
            InitializeComponent();
            grid.DataSource = GetDataFromXML();
        }
        private DataTable GetDataFromXML() {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            return ds.Tables[0];
        }
        private void PostDataToXML() {
            ((DataTable)grid.DataSource).DataSet.WriteXml(path);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            PostDataToXML();
            MessageBox.Show("Changes have been successfully saved to an XML file.", "Info");
        }
    }
    #endregion #1
}
