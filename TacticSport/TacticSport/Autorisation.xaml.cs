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

namespace TacticSport
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Autorisation : Window
    {
        public Autorisation()
        {
            InitializeComponent();
        }

        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            var reg = new Registration();
            reg.ShowDialog();
        }

        private void ButtonSign_Click(object sender, RoutedEventArgs e)
        {
            var main = new Main();
            main.ShowDialog();
        }
    }
}
