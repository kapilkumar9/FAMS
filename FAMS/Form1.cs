using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FAMS
{
    public partial class Form1 : Form
    {
        String pswd;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            getdata();
            if (pswd == password.Text)
            {
                Dashboard form = new Dashboard();
                form.Show();
                this.Hide();
                //MessageBox.Show("Login Successful!");
            }
            else
            {
                username.Text = "";
                password.Text = "";
                MessageBox.Show("Invalid User Name or Password...\n\tTRY AGAIN!");
            }

        }
        private void getdata()
        {
            try
            {
                con.Open();
                String query = "SELECT Pswd FROM Login WHERE Username='" + username.Text + "'";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                pswd = dr["Pswd"].ToString();
                con.Close();
            }
            catch
            {
                con.Close();
                pswd = "";
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(password.PasswordChar=='*')
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }
    }
}
