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
using MySql.Data.MySqlClient;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connection = @"server=localhost;database=dota2;uid=root;password=root";
            string userLogin= user_login.Text;
            string userPassword = user_pwd.Password.ToString();
            int statusId = 2;
            MySqlConnection mySql = new MySqlConnection(connection);
            string insertUserCommand = "insert into users(user_login, " +
                "user_password, user_status) "+
                "values" +
                "('" + userLogin + 
                "','" + userPassword + 
                "'," + statusId + ");";
            MySqlCommand command = new MySqlCommand(insertUserCommand, mySql);
            MessageBox.Show("Поздравляю! Вы успешно зарегистрировались!");
            mySql.Open();
            command.ExecuteReader();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
