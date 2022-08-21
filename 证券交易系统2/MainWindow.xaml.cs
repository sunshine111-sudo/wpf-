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
using System.IO;
using System.Reflection;
using System.Globalization;
using MySqlConnector;
using System.Data;

namespace 证券交易系统2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<StockInfo> Data { get; set; }

        public MainWindow()
        {
            InitializeComponent();


        }
        String stockName= "600747 大连控股 ";
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;
        }
        private String connStr = "Server=localhost;Database=mysql;Uid=root;Pwd=root;";
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
         
            stockChart.Charts[0].Graphs[0].Title = stockName;
            stockChart.Charts[1].Graphs[0].Title = stockName;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            var res = new List<StockInfo>(10000); 
            MySqlCommand cmd = new MySqlCommand("select * from stock ", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
  
            while (reader.Read())
            {
                DateTime date =DateTime.Parse( reader.GetString("date"));
                Double open = reader.GetDouble("open");
                Double high = reader.GetDouble("high");
                Double low = reader.GetDouble("low");
                Double close =reader.GetDouble("close");
                Double volumn = reader.GetDouble("volumn");
                res.Add(
                          new StockInfo
                          {
                              date = date,
                              open = open,
                              high = high,
                              low = low,
                              close = close,
                              volume = volumn
                             
                          });
            }
            reader.Close();
            Data = res;
            stockSet1.ItemsSource = Data;
            
        
        }
   
    }
}
        
    
   
    