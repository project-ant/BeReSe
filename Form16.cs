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
    public partial class Form16_ : Form
    {
        public Form16_()
        {
            InitializeComponent();
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            Form7_Profile Form7 = new Form7_Profile();
            Form7.Show();
            this.Hide();
        }

        private void Button_MainMenu_Click(object sender, EventArgs e)
        {
            Form_User_MainMenu Form6 = new Form_User_MainMenu();
            Form6.Show();
            this.Hide();
        }
    }
}
