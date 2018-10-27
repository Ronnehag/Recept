namespace Uppgift_1
{
    partial class FormMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBox_RecipeResults = new System.Windows.Forms.ListBox();
            this.gB_RecipeInformation = new System.Windows.Forms.GroupBox();
            this.lbl_CategoryNew = new System.Windows.Forms.Label();
            this.cb_CategoryDesc = new System.Windows.Forms.ComboBox();
            this.txt_RecipeTitle = new System.Windows.Forms.TextBox();
            this.txt_Ingredients = new System.Windows.Forms.TextBox();
            this.lbl_Ingredients = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_RecipeTitle = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btnSearchRecipe = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cB_Category = new System.Windows.Forms.ComboBox();
            this.txt_RecipeSearch = new System.Windows.Forms.TextBox();
            this.gB_SearchResult = new System.Windows.Forms.GroupBox();
            this.gB_RecipeInformation.SuspendLayout();
            this.gB_SearchResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBox_RecipeResults
            // 
            this.lBox_RecipeResults.FormattingEnabled = true;
            this.lBox_RecipeResults.ItemHeight = 20;
            this.lBox_RecipeResults.Location = new System.Drawing.Point(8, 107);
            this.lBox_RecipeResults.Name = "lBox_RecipeResults";
            this.lBox_RecipeResults.Size = new System.Drawing.Size(456, 244);
            this.lBox_RecipeResults.TabIndex = 0;
            this.lBox_RecipeResults.SelectedIndexChanged += new System.EventHandler(this.lBox_RecipeResults_SelectedIndexChanged);
            // 
            // gB_RecipeInformation
            // 
            this.gB_RecipeInformation.Controls.Add(this.lbl_CategoryNew);
            this.gB_RecipeInformation.Controls.Add(this.cb_CategoryDesc);
            this.gB_RecipeInformation.Controls.Add(this.txt_RecipeTitle);
            this.gB_RecipeInformation.Controls.Add(this.txt_Ingredients);
            this.gB_RecipeInformation.Controls.Add(this.lbl_Ingredients);
            this.gB_RecipeInformation.Controls.Add(this.lbl_Description);
            this.gB_RecipeInformation.Controls.Add(this.txt_Description);
            this.gB_RecipeInformation.Controls.Add(this.lbl_RecipeTitle);
            this.gB_RecipeInformation.Location = new System.Drawing.Point(648, 0);
            this.gB_RecipeInformation.Name = "gB_RecipeInformation";
            this.gB_RecipeInformation.Size = new System.Drawing.Size(422, 578);
            this.gB_RecipeInformation.TabIndex = 8;
            this.gB_RecipeInformation.TabStop = false;
            this.gB_RecipeInformation.Text = "Receptinformation";
            this.gB_RecipeInformation.UseCompatibleTextRendering = true;
            // 
            // lbl_CategoryNew
            // 
            this.lbl_CategoryNew.AutoSize = true;
            this.lbl_CategoryNew.Location = new System.Drawing.Point(44, 101);
            this.lbl_CategoryNew.Name = "lbl_CategoryNew";
            this.lbl_CategoryNew.Size = new System.Drawing.Size(72, 20);
            this.lbl_CategoryNew.TabIndex = 15;
            this.lbl_CategoryNew.Text = "Kategori:";
            // 
            // cb_CategoryDesc
            // 
            this.cb_CategoryDesc.FormattingEnabled = true;
            this.cb_CategoryDesc.Location = new System.Drawing.Point(122, 98);
            this.cb_CategoryDesc.Name = "cb_CategoryDesc";
            this.cb_CategoryDesc.Size = new System.Drawing.Size(238, 28);
            this.cb_CategoryDesc.TabIndex = 14;
            // 
            // txt_RecipeTitle
            // 
            this.txt_RecipeTitle.Location = new System.Drawing.Point(122, 48);
            this.txt_RecipeTitle.Name = "txt_RecipeTitle";
            this.txt_RecipeTitle.Size = new System.Drawing.Size(238, 26);
            this.txt_RecipeTitle.TabIndex = 7;
            // 
            // txt_Ingredients
            // 
            this.txt_Ingredients.Location = new System.Drawing.Point(122, 360);
            this.txt_Ingredients.Multiline = true;
            this.txt_Ingredients.Name = "txt_Ingredients";
            this.txt_Ingredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Ingredients.Size = new System.Drawing.Size(238, 186);
            this.txt_Ingredients.TabIndex = 5;
            // 
            // lbl_Ingredients
            // 
            this.lbl_Ingredients.AutoSize = true;
            this.lbl_Ingredients.Location = new System.Drawing.Point(14, 360);
            this.lbl_Ingredients.Name = "lbl_Ingredients";
            this.lbl_Ingredients.Size = new System.Drawing.Size(102, 20);
            this.lbl_Ingredients.TabIndex = 4;
            this.lbl_Ingredients.Text = "Ingredienser:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(22, 149);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(94, 20);
            this.lbl_Description.TabIndex = 3;
            this.lbl_Description.Text = "Beskrivning:";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(122, 149);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Description.Size = new System.Drawing.Size(238, 187);
            this.txt_Description.TabIndex = 2;
            // 
            // lbl_RecipeTitle
            // 
            this.lbl_RecipeTitle.AutoSize = true;
            this.lbl_RecipeTitle.Location = new System.Drawing.Point(74, 51);
            this.lbl_RecipeTitle.Name = "lbl_RecipeTitle";
            this.lbl_RecipeTitle.Size = new System.Drawing.Size(42, 20);
            this.lbl_RecipeTitle.TabIndex = 0;
            this.lbl_RecipeTitle.Text = "Titel:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(34, 28);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(42, 20);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Titel:";
            // 
            // btnSearchRecipe
            // 
            this.btnSearchRecipe.Location = new System.Drawing.Point(316, 25);
            this.btnSearchRecipe.Name = "btnSearchRecipe";
            this.btnSearchRecipe.Size = new System.Drawing.Size(148, 43);
            this.btnSearchRecipe.TabIndex = 6;
            this.btnSearchRecipe.Text = "Sök";
            this.btnSearchRecipe.UseVisualStyleBackColor = true;
            this.btnSearchRecipe.Click += new System.EventHandler(this.btnSearchRecipe_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(8, 357);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(148, 43);
            this.btn_New.TabIndex = 7;
            this.btn_New.Text = "Nytt recept";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(162, 357);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(148, 43);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Ta bort";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(316, 357);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(148, 43);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Ändra";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(4, 69);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(72, 20);
            this.lbl_Category.TabIndex = 11;
            this.lbl_Category.Text = "Kategori:";
            // 
            // cB_Category
            // 
            this.cB_Category.FormattingEnabled = true;
            this.cB_Category.Location = new System.Drawing.Point(82, 66);
            this.cB_Category.Name = "cB_Category";
            this.cB_Category.Size = new System.Drawing.Size(203, 28);
            this.cB_Category.TabIndex = 12;
            // 
            // txt_RecipeSearch
            // 
            this.txt_RecipeSearch.Location = new System.Drawing.Point(82, 25);
            this.txt_RecipeSearch.Name = "txt_RecipeSearch";
            this.txt_RecipeSearch.Size = new System.Drawing.Size(203, 26);
            this.txt_RecipeSearch.TabIndex = 13;
            // 
            // gB_SearchResult
            // 
            this.gB_SearchResult.Controls.Add(this.txt_RecipeSearch);
            this.gB_SearchResult.Controls.Add(this.cB_Category);
            this.gB_SearchResult.Controls.Add(this.lBox_RecipeResults);
            this.gB_SearchResult.Controls.Add(this.lbl_Category);
            this.gB_SearchResult.Controls.Add(this.btn_Update);
            this.gB_SearchResult.Controls.Add(this.btn_Delete);
            this.gB_SearchResult.Controls.Add(this.btn_New);
            this.gB_SearchResult.Controls.Add(this.btnSearchRecipe);
            this.gB_SearchResult.Controls.Add(this.lbl_Title);
            this.gB_SearchResult.Location = new System.Drawing.Point(0, 0);
            this.gB_SearchResult.Name = "gB_SearchResult";
            this.gB_SearchResult.Size = new System.Drawing.Size(642, 575);
            this.gB_SearchResult.TabIndex = 9;
            this.gB_SearchResult.TabStop = false;
            this.gB_SearchResult.Text = "Resultat";
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 581);
            this.Controls.Add(this.gB_SearchResult);
            this.Controls.Add(this.gB_RecipeInformation);
            this.Name = "FormMainWindow";
            this.Text = "Form1";
            this.gB_RecipeInformation.ResumeLayout(false);
            this.gB_RecipeInformation.PerformLayout();
            this.gB_SearchResult.ResumeLayout(false);
            this.gB_SearchResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lBox_RecipeResults;
        private System.Windows.Forms.GroupBox gB_RecipeInformation;
        private System.Windows.Forms.TextBox txt_RecipeTitle;
        private System.Windows.Forms.TextBox txt_Ingredients;
        private System.Windows.Forms.Label lbl_Ingredients;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_RecipeTitle;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btnSearchRecipe;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cB_Category;
        private System.Windows.Forms.TextBox txt_RecipeSearch;
        private System.Windows.Forms.GroupBox gB_SearchResult;
        private System.Windows.Forms.Label lbl_CategoryNew;
        private System.Windows.Forms.ComboBox cb_CategoryDesc;
    }
}

