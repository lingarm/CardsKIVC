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
    public partial class CardsKIVC : Form
    {
        SqlConnection conn = null;
        internal DataTable table = null;
        SqlDataAdapter adapter = null;
        string cs = null;

        public CardsKIVC()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            //Container.Width = this.Width;
            //Container.Height = this.Height;

            cs = ConfigurationManager.ConnectionStrings["MyConnSQL"].ConnectionString;
            conn = new SqlConnection(cs);
        }

        private void CardsKIVC_Load(object sender, EventArgs e)
        {
            try
            {
                table = new DataTable();
                adapter = new SqlDataAdapter("exec ViewCards", conn);
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
                adapter.Fill(table);
                CardsGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CardsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(CardsGridView.CurrentRow.Cells[0].Value.ToString());
            OneCard oneCard = new OneCard(id);
            //MessageBox.Show(id.ToString());
            oneCard.ShowDialog();


            
            //MessageBox.Show("CellDoubleClick \n" + e.RowIndex +"\n" + e.ColumnIndex);
        }
    }
}
