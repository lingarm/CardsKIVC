using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace CardsKIVC
{
    public class db
    {
        SqlConnection conn = null;
        internal DataTable table = null;
        SqlDataAdapter adapter = null;
        string cs = ConfigurationManager.ConnectionStrings["MyConnSQL"].ConnectionString;

        /* Конструктор */
        
        /* Подключиться к базе данных */
        protected void db_connect()
        {
            
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
        protected bool select_card()
        {
            return true;
        }

        /*  Select из базы поля для DataGridView */
        protected bool select_from_dgv(int id)
        {
            string query = "SELECT * FROM work_place WHERE id = " + id;

            return true;
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