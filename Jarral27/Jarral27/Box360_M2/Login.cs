using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box360_M2
{
    public partial class frmLogin : Form
    {
        private SqlConnection connection;
        private string connectString = "Data Source=146.230.177.46;Initial Catalog = GroupWst13; Persist Security Info=True;User ID = GroupWst13; Password=kqf42";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnC_Login_Click(object sender, EventArgs e)
        {
            string username = txtC_Username.Text; 
            string password = txtC_Password.Text;

            string query = "SELECT COUNT(*) FROM Client WHERE ClientID = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password",password);

            int result = (int)command.ExecuteScalar();

            if(result > 0)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open(); 
        }

        private void btnM_Login_Click(object sender, EventArgs e)
        {
            string username = txtM_Username.Text;
            string password = txtM_Password.Text;

            string query = "SELECT COUNT(*) FROM Manager WHERE ManagerID = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            int result = (int)command.ExecuteScalar();

            if (result > 0)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void txtC_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ManageClass frmClass = new ManageClass();
            // frmClass.Show();

            Supplier frmSupplier = new Supplier();
            frmSupplier.Show();
        }
    }
}
