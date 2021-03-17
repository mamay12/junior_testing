using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace junior_test
{
    public partial class Form1 : Form
    {
        /*public variables to connection*/
       
        static string host = "localhost";
        static string database = "db";
        static string userDB = "root";
        static string password = "root";
        public static string connectionString = 
            "server=" + host + 
            ";Database=" + database + 
            ";User ID=" + userDB + 
            ";Password=" + password;
        /*sql query variable*/
        public string sql;
        public Form1()
        {
            InitializeComponent();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `enterprises`";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                data_panel_enterprises.DataSource = dt;

            }
        }

        private void data_panel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = data_panel_enterprises.Rows[e.RowIndex].Cells[0].Value.ToString();
            sql = "select a.country, a.region, a.district, a.type_of_settlement, a.name_of_settlement from `address` a " +
                        "join `enterprises_address` ea on  a.id = ea.address_id "+
                        "join `enterprises` e on ea.enterprise_id = e.id "+
                            $"where e.id = '{value}'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                data_panel_address.DataSource = dt;
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
