using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_1
{
    public static class Helper
    {
        public static void LoadComboBox(ComboBox box, string sqlCode, string displayMember, string valueMember)
        {
            var bindingSource = new BindingSource();
            var dbManager = new DbManager();
            var table = dbManager.GetTableFromSql(sqlCode);
            bindingSource.DataSource = table;
            box.DisplayMember = displayMember;
            box.ValueMember = valueMember;
            box.DataSource = bindingSource;
        }
    }
}
