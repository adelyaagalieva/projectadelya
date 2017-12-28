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
    /// Логика взаимодействия для REG2.xaml
    /// </summary>
    public partial class REG2 : Window
    {
        public REG2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=school;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string work_user_secondname = secondname2.Text;
            string work_user_firstname = firstname2.Text;
            string work_direction_user = direction2.Text;
            string work_user_year_experience = year_experience2.Text;
            string work_user_price = price2.Text;
            string user_login = login2.Text;
            string user_password = password2.Text;
            int user_status = 2;

            MySqlCommand cmd = new MySqlCommand("insert into user_work (work_user_secondname ,work_user_firstname, work_direction_user,work_user_year_experience,work_user_price" 
                 +
                "values( '" + user_login + "', '" + user_password + "', '" + user_status + "');", connection);
          
             connection.Close();
             connection.Open();
           
            



        

    }
}
}

        
    

