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
using WpfApp10.Command;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RelayCommand MessageCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            MessageCommand = new RelayCommand(Display);
        }
        public void Display(object text=null)
        {
            MessageBox.Show("Hello Guys,We have gift for you");
        }
    }
}
