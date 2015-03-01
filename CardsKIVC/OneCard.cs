using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CardsKIVC
{
    public partial class OneCard : Form
    {
        db data = null;
        Dictionary<string, string> array = new Dictionary<string, string>();

        public OneCard(int id)
        {
            InitializeComponent();
            
            //EnableControls(false);
            data = new db();
            
            array = data.select_card(id);

            this.cabinet.Text = array["cabinet"].ToString();
            this.username.Text = array["username"].ToString();
            this.id.Text = array["id"].ToString();

            this.comp_inv.Text = array["comp_inv"].ToString();
            this.motherboard.Text = array["motherboard"].ToString();

            this.monitor1.Text = array["monitor1"].ToString();
            this.monitor_inv1.Text = array["monitor_inv1"].ToString();
            //this.printer1.Text = array["printer1"].ToString();
            this.printer_inv1.Text = array["printer_inv1"].ToString();
            //this.UPC1.Text = array["UPC1"].ToString();
            this.UPC_inv1.Text = array["UPC_inv1"].ToString();

            this.ext_info.Text = array["ext_info"].ToString();


            setCombo();
            
            

            /*DataSet ds = new DataSet();
            ds = data.select_from_combo("building");
            this.building.DataSource = ds.Tables[0];
            this.building.DisplayMember = "building";
            this.building.ValueMember = "id";
            this.building.SelectedValue = Convert.ToInt32(array["building"]);*/
            
        }
        /* Заполнить все комбобоксы */
        public void setCombo()
        {
            DataSet ds = new DataSet();
            string name = "";
            string str = "";
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(GroupBox) && c.Name == "groupBox1")
                {
                    str += "c: " + c.Name + "\n";
                    foreach (Control j in c.Controls)
                    {
                        if (j.GetType() == typeof(ComboBox))
                        {
                            str += "j: " + j.Name + "\n";
                            MessageBox.Show("j: " + j.Name + "\n");
                            name = j.Name;
                            ds = data.select_from_combo(name);
                            this.building.DataSource = ds.Tables[0];
                            this.building.DisplayMember = name;
                            this.building.ValueMember = "id";
                            this.building.SelectedValue = Convert.ToInt32(array[name]);
                        }
                    }
                }

            }
            MessageBox.Show(str);
        }

        public void EnableControls(bool status)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() != typeof(Button))
                    c.Enabled = status;
            }
        }

        private void cabinet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Core.int_only(e);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            this.edit.Text = "Сохранить";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}