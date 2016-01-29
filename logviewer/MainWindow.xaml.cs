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

namespace logviewer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List < TraceItem > Items = new List<TraceItem>();
            Items.Add(new TraceItem() { Idx = 0, Time = DateTime.Now, UserId = 0x100, payLoad = new byte[]{ 0x1, 0x2, 0x3 } });
            Items.Add(new TraceItem() { Idx = 1, Time = DateTime.Now, UserId = 0x101, payLoad = new byte[] { 0x1, 0x2, 0x3 } });
            Items.Add(new TraceItem() { Idx = 2, Time = DateTime.Now, UserId = 0x102, payLoad = new byte[] { 0x1, 0x2, 0x3 } });
            Items.Add(new TraceItem() { Idx = 3, Time = DateTime.Now, UserId = 0x103, payLoad = new byte[] { 0x1, 0x2, 0x3 } });

            listView.ItemsSource = Items;
        }
    }
}
