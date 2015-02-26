using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace CardsKIVC
{
    public partial class OneCard : Form
    {
        SqlConnection conn = null;
        SqlConnection conn2 = null;
        internal DataTable table = null;
        SqlDataAdapter adapter = null;
        string cs = null;

        public OneCard(int id)
        {
            InitializeComponent();


            cs = ConfigurationManager.ConnectionStrings["MyConnSQL"].ConnectionString;
            conn = conn2 = new SqlConnection(cs);
            string query = "SELECT * FROM work_place WHERE id = " + id;
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader;
            conn.Open();
            reader = comm.ExecuteReader();
            
            int sv = 100;

            if(reader.Read())
            {
                this.cabinet.Text = reader["cabinet"].ToString();
                this.username.Text = reader["username"].ToString();
                this.comp_inv.Text = reader["comp_inv"].ToString();
                this.monitor_inv.Text = reader["monitor_inv1"].ToString();
                this.UPC_inv.Text = reader["UPC_inv"].ToString();

                this.ext_info.Text = reader["ext_info"].ToString();
                
                sv = Convert.ToInt32(reader["building"]);
            }
            conn.Close();
            

            query = "SELECT * FROM building";
            comm = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            this.building.DataSource = ds.Tables[0];
            this.building.DisplayMember = "building";
            this.building.ValueMember = "id";
            this.building.SelectedValue = sv;

            //MessageBox.Show(this.building.SelectedValue.ToString());
        }

        private void cabinet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Core.int_only(e);
        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }
    }
}