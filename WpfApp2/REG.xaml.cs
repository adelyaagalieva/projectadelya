using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для REG.xaml
    /// </summary>
    public partial class REG : Window
    {
        private object status1;

        public object Status1 { get; private set; }

        public REG()
        {
            InitializeComponent();
        }

        private void textBox_Copy4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=school;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            
            string profile_user_secondname = secondname1.Text;
            string profile_user_firstname = firstname1.Text;
            string profile_user_middlename = middlename1.Text;
            string profile_user_telephone = telephone1.Text;
            string user_login = login1.Text;
            string user_password= password1.Text;
            int user_status = 1;



            MySqlCommand cmd = new MySqlCommand("insert into user_profile (profile_user_secondname ,profile_user_firstname, profile_user_middlename,profile_user_telephone," +
                
              "values( '" + user_login + "', '" + user_password + "'', '" + user_status + "');", connection);
            connection.Close();

          
            connection.Open();
        }

    }
}

