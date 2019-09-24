using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection cn;
        string data = "";
        string data2 = "";
        string data3 = "";
        public MainWindow()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WorkPlace11.accdb");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string query = "select* from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            
            while (read.Read()){
                data += read[0].ToString() + "\n";
                data2 += read[1].ToString() + "\n";
                data3 += read[2].ToString() + "\n";
            }

            DataBox.Text = data + data2;
            cn.Close();
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) // Didn't remove to avoid build issues.
        {
            
        
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string query = "select* from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                data += read[0].ToString() + "\n";
                data2 += read[1].ToString() + "\n";
                data3 += read[2].ToString() + "\n";
            }

            DataBox.Text = data + data2;
            cn.Close();

        }
    }
}
