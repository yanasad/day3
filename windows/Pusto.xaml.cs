using Microsoft.VisualBasic.Logging;
using sadovnikovapractika.classes;
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
using System.Windows.Shapes;

namespace sadovnikovapractika.windows
{
    /// <summary>
    /// Логика взаимодействия для Pusto.xaml
    /// </summary>
    public partial class Pusto : Window
    {
        public Pusto(int id)
        {
            InitializeComponent();
          
            int h = id;
            var context = new AppDbContext();
            var user = context.Users.SingleOrDefault(x => x.Id == id);
            string l = user.Login;
            kkk.Text = "Здравствуйте, " + l;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);    
        }

        private void pystonaz_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
