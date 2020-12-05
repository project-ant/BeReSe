using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace BeReSe
{
    public partial class Form_Admin_MainMenu : Form
    {

        public void refresh_table_Service()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from db_berese.service;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                DataGridView_Service.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refresh_table_Member() 
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from rentalpro.db_customer;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                DataGridView_Member.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public Form_Admin_MainMenu()
        {
            InitializeComponent();
        }

        private void Button_Status_Click(object sender, EventArgs e)
        {
            Form_Service Form4 = new Form_Service();
            Form4.Show();
            this.Hide();
        }

        private void button_Member_Click(object sender, EventArgs e)
        {
            Form_Service Form15 = new Form_Service();
            Form15.Show();
            this.Hide();
        }

        private void Button_Service_Click(object sender, EventArgs e)
        {
            Form_Service Form3 = new Form_Service();
            Form3.Show();
            this.Hide();
        }

        private void DataGridView_Service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form_Admin_MainMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void DataGridView_Member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ask Mochi to automatically display the content when starting up
        }
    }
}
