using System;
using System.Windows.Forms;
using Uppgift_1.Data;
using Uppgift_1.Model;

namespace Uppgift_1
{
    public partial class FormNewRecipe : Form
    {
        public FormNewRecipe()
        {
            InitializeComponent();
            Helper.LoadComboBox(cB_Category,
                "SELECT CategoryID, CategoryName FROM CATEGORY", "CategoryName", "CategoryID");
            cB_Category.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var title = txt_Title.Text;
            var category = int.Parse(cB_Category.SelectedValue.ToString());
            var ingredients = txt_Ingredients.Text;
            var howTo = txt_HowTo.Text;
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Ett recept måste ha en titel.",
                    "Titel saknas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var recipe = new Recipe
            {
                Title = title,
                CategoryId = category,
                Ingredients = ingredients,
                Description = howTo
            };
            var repo = new RecipeRepository();
            repo.SaveRecipe(recipe);
            MessageBox.Show("Receptet är sparat!");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
