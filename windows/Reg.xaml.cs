﻿using sadovnikovapractika.classes;
using sadovnikovapractika.windows;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sadovnikovapractika.windows
{
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void zarega_Click(object sender, RoutedEventArgs e)
        {
            var login = log.Text;
            var password = passw.Text;
            var Email = email.Text;
            var repitt = repit.Text;
            var context = new AppDbContext();
            var user_exists = context.Users.FirstOrDefault(x => x.Login == login);
            if (user_exists != null)
            {
                MessageBox.Show("Логин меняй, уже есть такой");
                return;
            }

            string s1 = Email;
            string s2 = "@";
            string s3 = ".";
            email.BorderBrush = Brushes.PeachPuff;
            repit.BorderBrush = Brushes.PeachPuff;
            passw.BorderBrush = Brushes.PeachPuff;
            log.BorderBrush = Brushes.PeachPuff;
            if (Email.Contains(s2) && Email.Contains(s3))
            {
                erremail.Text = "";
                if (login.Length > 1)
                {
                    errlog.Text = "";
                    if (password.Length >= 6 )
                    {
                        errpasswlenght.Text = "";
                        if (password.Any(Char.IsPunctuation))
                        {
                            errpassword.Text = "";
                            if (password == repitt)
                            {
                                errrepit.Text = ""; 
                                var user = new User { Login = login, Password = password, Email = Email };
                                context.Users.Add(user);
                                context.SaveChanges();
                                MessageBox.Show("теперь ты в тиме умников и умниц");

                                MainWindow mainWindow = new MainWindow();
                                mainWindow.Show();
                                this.Hide();
                            }
                           else
                           {
                                repit.BorderThickness = new Thickness(4);
                                repit.BorderBrush = Brushes.DarkRed;
                                
                                 errrepit.Text = "Повторный ввод пароля неверный";
                           }
                        }
                        else
                        {
                            passw.BorderThickness = new Thickness(4);
                            passw.BorderBrush = Brushes.DarkRed;

                            errpassword.Text = "Пароль не содержит спец.символы";
                        }
                    }
                    else
                    {
                       log.BorderThickness = new Thickness(4);
                        log.BorderBrush = Brushes.DarkRed;

                        errpasswlenght.Text = "Пароль не содержит в себе 6 и более символов";
                    }
                }
                else
                {
                    email.BorderBrush = Brushes.DarkRed;
                    log.BorderThickness = new Thickness(4);
                    log.BorderBrush = Brushes.DarkRed;

                    errlog.Text = "Логин уже занят";
                }
            }
            else
            {
                email.BorderThickness = new Thickness(4);
                email.BorderBrush = Brushes.DarkRed;

                erremail.Text = "Email должен содержать @ и .";
            }
        }
      
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
       
           MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

    
    }

}
