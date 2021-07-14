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

namespace Income_Expense
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you sure ?");
            int I = int.Parse(Income.Text);
            int E = int.Parse(Expense.Text);
            int X = (I - E);
            int W = int.Parse(Wish_List.Text);
            Collect_Money.Text = ("" + (W / X));
        }
    }
}
