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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Button_MainMenu_Click(object sender, EventArgs e)
        {
            Form_Admin_MainMenu Form2 = new Form_Admin_MainMenu();
            Form2.Show();
            this.Hide();
        }
    }
}
