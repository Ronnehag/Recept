using System;
using System.Windows.Forms;
using Uppgift_1.Data;
using Uppgift_1.Model;

namespace Uppgift_1
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
            Helper.LoadComboBox(cB_Category, "SELECT CategoryID, CategoryName FROM Category", "CategoryName", "CategoryID");
            cB_Category.SelectedIndex = -1;
        }

        private void UpdateListBox()
        {
            if (cB_Category.SelectedIndex == -1 && string.IsNullOrWhiteSpace(txt_RecipeSearch.Text)) return;

            var repo = new RecipeRepository();
            lBox_RecipeResults.Items.Clear();

            var title = txt_RecipeSearch.Text.Trim();

            if (cB_Category.SelectedIndex == -1 && !string.IsNullOrWhiteSpace(title))
            {
                var result = repo.GetRecipesByTitle(title);
                foreach (var recipe in result)
                {
                    lBox_RecipeResults.ValueMember = "RecipeId";
                    lBox_RecipeResults.DisplayMember = "Title";
                    lBox_RecipeResults.Items.Add(recipe);
                }
            }
            else if (string.IsNullOrWhiteSpace(title))
            {
                var category = int.Parse(cB_Category.SelectedValue.ToString());
                var result = repo.GetRecipesByCategory(category);
                foreach (var recipe in result)
                {
                    lBox_RecipeResults.ValueMember = "RecipeId";
                    lBox_RecipeResults.DisplayMember = "Title";
                    lBox_RecipeResults.Items.Add(recipe);
                }
            }
            else
            {
                var category = int.Parse(cB_Category.SelectedValue.ToString());
                var result = repo.GetRecipesByTitleAndCategory(category, title);
                foreach (var recipe in result)
                {
                    lBox_RecipeResults.ValueMember = "RecipeId";
                    lBox_RecipeResults.DisplayMember = "Title";
                    lBox_RecipeResults.Items.Add(recipe);
                }
            }

        }

        private void UpdateDescription()
        {
            ResetDescription();
            if (lBox_RecipeResults.SelectedIndex == -1) return;
            Helper.LoadComboBox(cb_CategoryDesc, "SELECT CategoryID, CategoryName FROM Category", "CategoryName", "CategoryID");
            cb_CategoryDesc.DropDownStyle = ComboBoxStyle.DropDownList;
            var value = (Recipe)lBox_RecipeResults.SelectedItem;
            txt_RecipeTitle.Text = value.Title;
            txt_Description.Text = value.Description;
            txt_Ingredients.Text = value.Ingredients;
            cb_CategoryDesc.SelectedValue = value.CategoryId;
        }

        private void ResetDescription()
        {
            txt_RecipeTitle.Clear();
            txt_Description.Clear();
            txt_Ingredients.Clear();
            cb_CategoryDesc.DropDownStyle = ComboBoxStyle.DropDown;
            cb_CategoryDesc.ResetText();
        }

        private void btnSearchRecipe_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void lBox_RecipeResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDescription();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            var frm = new FormNewRecipe();
            frm.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lBox_RecipeResults.SelectedIndex == -1) return;
            var value = (Recipe)lBox_RecipeResults.SelectedItem;

            var repo = new RecipeRepository();
            repo.DeleteRecipe(value.RecipeId);
            UpdateListBox();
            UpdateDescription();
            ResetDescription();

            MessageBox.Show("Receptet borttaget!");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (lBox_RecipeResults.SelectedIndex == -1) return;
            if (string.IsNullOrWhiteSpace(txt_RecipeTitle.Text))
            {
                MessageBox.Show("Du måste ange en titel");
                return;
            }

            var recipe = (Recipe) lBox_RecipeResults.SelectedItem;
            var repo = new RecipeRepository();

            recipe.Title = txt_RecipeTitle.Text;
            recipe.Ingredients = txt_Ingredients.Text;
            recipe.CategoryId = int.Parse(cb_CategoryDesc.SelectedValue.ToString());
            recipe.Description = txt_Description.Text;
            repo.UpdateRecipe(recipe);

            MessageBox.Show("Receptet är uppdaterat!");
        }
    }
}
