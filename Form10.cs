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
    public partial class Form_Bengkel_MainMenu : Form
    {
        public Form_Bengkel_MainMenu()
        {
            InitializeComponent();
        }

        private void Button_List_Click(object sender, EventArgs e)
        {

        }

        private void Button_Available_Click(object sender, EventArgs e)
        {
            PictureBox_Green.Visible = true;
            PictureBox_Red.Visible = false;
        }

        private void Button_Not_Available_Click(object sender, EventArgs e)
        {
            PictureBox_Green.Visible = false;
            PictureBox_Red.Visible = true;
        }
    }
}
