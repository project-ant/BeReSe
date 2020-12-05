using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeReSe
{
    public partial class Form_User_MainMenu : Form
    {
        public Form_User_MainMenu()
        {
            InitializeComponent();
        }

        private void Button_Account_Click(object sender, EventArgs e)
        {
            Form7_Profile Form7 = new Form7_Profile();
            Form7.Show();
            this.Hide();
        }

        private void Button_Request_Click(object sender, EventArgs e)
        {
            Form16_ Form16 = new Form16_();
            Form16.Show();
            this.Hide();
        }

        /*private void Button_History_Click(object sender, EventArgs e)
        {
            Form_User_MainMenu Form2 = new Form_User_MainMenu();
            Form2.Show();
            this.Hide();
        }*/

        private void Button_Search_Click(object sender, EventArgs e)
        {
           
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            Form7_Profile Form7 = new Form7_Profile();
            Form7.Show();
            this.Hide();
        }
    }
}
