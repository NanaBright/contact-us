using System.Windows;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contact_Us
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // mysql connection
        MySqlConnection connection = new MySqlConnection("server=localhost;user id = root; database=contact");
        

        public MainWindow()
        {

            InitializeComponent();


        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            string q = "INSERT INTO `info`(`firstname`, `surname`, `gender`, `phonenumber`, `email`) VALUES ('"+ firstname.Text +"','"+ surname.Text +"','"+Gender.SelectedItem+"',"+ phonenumber.Text +",'"+ email.Text +"')";
            MySqlCommand cmd = new MySqlCommand(q, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Submitted");
            connection.Close();

        }

    }
    



}
