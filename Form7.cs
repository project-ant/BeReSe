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
    public partial class Form7_Profile : Form
    {
        public Form7_Profile()
        {
            InitializeComponent();
        }

        private void Button_Vehicle_Click(object sender, EventArgs e)
        {
            Form8_Vehicle Form8 = new Form8_Vehicle();
            Form8.Show();
            this.Hide();
        }

        private void Button_Address_Click(object sender, EventArgs e)
        {
            Form_User_MainMenu Form9 = new Form_User_MainMenu();
            Form9.Show();
            this.Hide();
        }
    }
}
