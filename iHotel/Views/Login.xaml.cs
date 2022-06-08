using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace iHotel.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon= new SqlConnection(@"Data Source=DESKTOP-38UGVDL; Initial Catalog=Hotel; Integrated Security=True;");
            try
            {
                if(sqlCon.State==System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT count(1) FROM [User] WHERE username=@username AND password=@password";
                SqlCommand sqlCmd=new SqlCommand(query,sqlCon);
                sqlCmd.CommandType=System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Password);
                int count=Convert.ToInt32(sqlCmd.ExecuteScalar());
                if(count==1)
                {
                    if (txtUsername.Text == "admin")
                    {
                        MainWindow dashboard = new MainWindow();
                        dashboard.Show();
                        this.Close();
                    }else if(txtUsername.Text=="client")
                    {
                        ClientView dashboard = new ClientView();
                        dashboard.Show();
                        this.Close();
                    }else if(txtUsername.Text=="employee")
                    {
                        EmployeeView dashboard = new EmployeeView();
                        dashboard.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
