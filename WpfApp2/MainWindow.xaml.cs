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
using System.Data;
using MySql.Data.MySqlClient;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int status_id = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            string connectionString = "Server=localhost;DATABASE=school;UID=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("select * from authorization where user_login='" + user_name.Text + "' and user_password='" + user_password.Password + "' and user_status_id = " + status_id + ";", connection);
            //connection.Open();
            //DataTable sc = new DataTable();
            //sc.Load(cmd.ExecuteReader());
            //connection.Close();
            //MainMenuWindow mainMenuWindow = new MainMenuWindow();
            //mainMenuWindow.mainMenu.DataContext = sc;
            //this.Close();
            //  mainMenuWindow.Show();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                if (status_id == 1)
                {
                    //   MySqlCommand cmd = new MySqlCommand("select * from user_profile where user_login='" + user_name.Text + "' and user_password='" + user_password.Password + "';", connection);
                    cmd.CommandType = CommandType.Text;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {

                        MainMenuWindow mainMenuWindow = new MainMenuWindow();
                        mainMenuWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароль или логин неверный!");
                    }

                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {

                        Window2 mainMenuWindow2 = new Window2();
                        mainMenuWindow2.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароль или логин неверный!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }
            finally
            {
                connection.Close();
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            REG newForm = new REG();
            
            newForm.Show();
        }

        private void button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            status_id = 1;
        }

        private void radioButton_Copy_Checked(object sender, RoutedEventArgs e)
        {
            status_id = 2;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            REG2 newForm = new REG2();

            newForm.Show();
        }
    }
}

