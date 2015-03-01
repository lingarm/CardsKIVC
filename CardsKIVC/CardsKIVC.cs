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
        db data = null;

        public CardsKIVC()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Normal;
            data = new db();
        }

        private void CardsKIVC_Load(object sender, EventArgs e)
        {
            CardsGridView.DataSource = data.select_from_dgv();
            data.select_from_dgv();
        }

        private void CardsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(CardsGridView.CurrentRow.Cells[0].Value.ToString());
            OneCard oneCard = new OneCard(id);
            oneCard.ShowDialog();
        }
    }
}