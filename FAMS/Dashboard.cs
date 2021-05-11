using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAMS
{
    public partial class Dashboard : Form
    {
        Form1 obj = new Form1();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void fishes_button_Click(object sender, EventArgs e)
        {
            fishes fishes = new fishes();
            fishes.Show();
            this.Close();
        }

        private void diver_button_Click(object sender, EventArgs e)
        {
            diver diver = new diver();
            diver.Show();
            this.Close();
        }

        private void staff_button_Click(object sender, EventArgs e)
        {
            staff staff = new staff();
            staff.Show();
            this.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
            obj.Show();
        }
    }
}
