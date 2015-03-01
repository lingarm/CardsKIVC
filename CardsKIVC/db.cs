using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CardsKIVC
{
    public class db
    {
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        string cs = "";

        /* Конструктор */
        public db()
        {
            cs = ConfigurationManager.ConnectionStrings["MyConnSQL"].ConnectionString;
            conn = new SqlConnection(cs);
        }

        /* Insert новую карточку */
        protected bool insert_card()
        {
            return true;
        }
        
        /* Update существующую карточку */
        protected bool update_card()
        {
            return true;
        }

        /*  Select из базы карточку */
        public Dictionary<string, string> select_card(int id)
        {
            string query = "SELECT * FROM work_place WHERE id = " + id;
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader;
            conn.Open();
            reader = comm.ExecuteReader();
            reader.Read();
            Object[] values = new Object[reader.FieldCount];
            int fieldCount = reader.GetValues(values);
            var array = new Dictionary<string, string>();
            for (int i = 0; i < fieldCount; i++)
            {
                array.Add(reader.GetName(i), values[i].ToString());
            }
            conn.Close();
            return array;
        }

        /* Select для combobox */
        public DataSet select_from_combo(string table)
        {
            string query = "SELECT * FROM " + table;
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }

        /*  Select из базы поля для DataGridView */
        public DataTable select_from_dgv()
        {
            DataTable table = new DataTable();
            table = new DataTable();
            
            adapter = new SqlDataAdapter("exec ViewCards", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            adapter.Fill(table);
            return table;
        }

        /*  Select из базы карточки под выборку */
        protected bool select_cards()
        {
            return true;
        }
        /* Delete карточку */
        protected bool delete_card(int id)
        {
            return true;
        }
    }
}