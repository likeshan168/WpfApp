using System;
using System.Activities;
using System.Activities.XamlIntegration;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] bs = utf8.GetBytes(this.textBox.Text);
            MemoryStream ms = new MemoryStream(bs);
            Activity activity = ActivityXamlServices.Load(ms);
            WorkflowApplication instance = new WorkflowApplication(activity);
            instance.Run();
        }
    }
}
