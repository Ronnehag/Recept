using System.Windows.Forms;

namespace Uppgift_1
{
    public static class Helper
    {
        public static void LoadComboBox(ComboBox box, string sqlCode, string displayMember, string valueMember)
        {
            var bindingSource = new BindingSource();
            var dbManager = new DbManager(sqlCode);
            var table = dbManager.GetTableFromSql();
            bindingSource.DataSource = table;
            box.DisplayMember = displayMember;
            box.ValueMember = valueMember;
            box.DataSource = bindingSource;
        }
    }
}
