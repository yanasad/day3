using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic.Logging;
using sadovnikovapractika.classes;
using sadovnikovapractika.windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace sadovnikovapractika
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

        private void registrac_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();

            reg.Show();

            this.Hide();
         
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        { 
           Environment.Exit(0);
        }

        private void vxod_Click(object sender, RoutedEventArgs e)
        {
            passw.Text = pwdPasswordBox.Password;
            var login = log.Text;
            var password = passw.Text;
            var context = new AppDbContext();
            var user = context.Users.SingleOrDefault(x => (x.Login == login || x.Email == login) && x.Password == password);
               if (user is null)
               {
                    MessageBox.Show("Такого пользователя не существует(");
                    return;
               }
               else
               { 
                MessageBox.Show("Вы успешно вошли в аккаунт!");
                int id = user.Id;
                Pusto vxod = new Pusto( id);
                vxod.Show();
                this.Hide();
               }
        }
        bool check = true;
        private void save_Click(object sender, RoutedEventArgs e)
        {
           

            if (check == true)
            {
                var text = pwdPasswordBox.Password;
                openn.Visibility = Visibility.Visible;
                save.Visibility = Visibility.Collapsed;
                pwdPasswordBox.Visibility = Visibility.Collapsed;
                passw.Visibility = Visibility.Visible;
                passw.Text = text;

                check = false;
            }
        }
        private void op(object sender, RoutedEventArgs e)
        {
              if (check == false)
            {
                var text = passw.Text;
                openn.Visibility = Visibility.Collapsed;
                save.Visibility = Visibility.Visible;
                passw.Visibility = Visibility.Collapsed;
                pwdPasswordBox.Visibility = Visibility.Visible;
                pwdPasswordBox.Password = text;
                check = true;
            }
        }
    }
}