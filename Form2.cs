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
    public partial class Form_Admin_MainMenu : Form
    {
        public Form_Admin_MainMenu()
        {
            InitializeComponent();
        }

        private void Button_Status_Click(object sender, EventArgs e)
        {

        }

        private void button_Member_Click(object sender, EventArgs e)
        {

        }

        private void Button_Service_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_Service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refresh_table();

            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label_id_customer.Text = row.Cells["id_transaksi"].Value.ToString();
                label_nama_Customer.Text = row.Cells["nama"].Value.ToString();
                label_kendaraan.Text = row.Cells["jenis_model"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
