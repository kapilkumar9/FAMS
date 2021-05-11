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
    public partial class fishes : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader dr;
        public fishes()
        {
            InitializeComponent();
            save_button.Hide();
        }
        private void enableBox()
        {
            species_textBox2.Enabled = true;
            quan_textBox1.Enabled = true;
            age_textBox4.Enabled = true;
            zone_textBox5.Enabled = true;
        }
        private void disableBox()
        {
            species_textBox2.Enabled = false;
            quan_textBox1.Enabled = false;
            age_textBox4.Enabled = false;
            zone_textBox5.Enabled = false;
        }
        private void getMax()
        {
            int auto_id;
            con.Open();
            string syntax = "SELECT MAX(Id) FROM fish";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            auto_id = Int32.Parse(dr[0].ToString());
            con.Close();
            ++auto_id;
            id_textBox1.Text = auto_id.ToString();
        }

        private void fishes_Load(object sender, EventArgs e)
        {

        }

        private void id_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void species_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void zone_textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void quan_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addnew_button_Click(object sender, EventArgs e)
        {
            enableBox();
            getMax();
            species_textBox2.Text = "";
            quan_textBox1.Text = "";
            age_textBox4.Text = "";
            zone_textBox5.Text = "";
            save_button.Show();
            try
            {
                con.Open();
                string query = "INSERT INTO fish(Id, species, quantity, age, zone) VALUES (@Id, @species, @quantity, @age, @zone)";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id_textBox1.Text);
                cmd.Parameters.AddWithValue("@species", species_textBox2.Text);
                cmd.Parameters.AddWithValue("@quantity", quan_textBox1.Text);
                cmd.Parameters.AddWithValue("@age", age_textBox4.Text);
                cmd.Parameters.AddWithValue("@zone", zone_textBox5.Text);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                con.Close();
                MessageBox.Show("Sorry Your ID can't be dublicate");
                disableBox();
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            edit_button.Hide();
            enableBox();
            save_button.Show();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            edit_button.Show();

            disableBox();
            try
            {
                con.Open();
                string query = "UPDATE fish SET Id=@Id, species=@species, quantity=@quantity, age=@age, zone=@zone WHERE Id='" + id_textBox1.Text + "'";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id_textBox1.Text);
                cmd.Parameters.AddWithValue("@species", species_textBox2.Text);
                cmd.Parameters.AddWithValue("@quantity", quan_textBox1.Text);
                cmd.Parameters.AddWithValue("@age", age_textBox4.Text);
                cmd.Parameters.AddWithValue("@zone", zone_textBox5.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                con.Close();
                MessageBox.Show("Sorry You must enter new ID");
            }
            save_button.Hide();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM fish WHERE Id='" + id_textBox1.Text + "'";
            cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
            con.Close();
            id_textBox1.Text = "";
            species_textBox2.Text = "";
            quan_textBox1.Text = "";
            age_textBox4.Text = "";
            zone_textBox5.Text = "";
            disableBox();
        }


        private void logout_button_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            disableBox();
            try
            {
                con.Open();
                string query = "SELECT * FROM fish WHERE Id=" + id_textBox1.Text;
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                species_textBox2.Text = dr["species"].ToString();
                quan_textBox1.Text = dr["quantity"].ToString();
                age_textBox4.Text = dr["age"].ToString();
                zone_textBox5.Text = dr["zone"].ToString();
                con.Close();
            }
            catch
            {
                con.Close();
                MessageBox.Show("Records are not Found");
            }
        }
    }
}
