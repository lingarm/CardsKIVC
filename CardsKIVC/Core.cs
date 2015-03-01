using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace CardsKIVC
{
    public static class Core
    {
        public static void int_only(KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        public static void show_assoc(Dictionary<string, string> array)
        {
            string str = "";
            foreach (var item in array)
            {
                str += "key: " + item.Key + " value: " + item.Value + "\n";
            }
            MessageBox.Show(str);
        }
    }
}
