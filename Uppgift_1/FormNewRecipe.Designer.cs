namespace Uppgift_1
{
    partial class FormNewRecipe
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
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HowTo = new System.Windows.Forms.TextBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Ingredients = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cB_Category = new System.Windows.Forms.ComboBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(170, 62);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(214, 26);
            this.txt_Title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori:";
            // 
            // txt_HowTo
            // 
            this.txt_HowTo.Location = new System.Drawing.Point(470, 65);
            this.txt_HowTo.Multiline = true;
            this.txt_HowTo.Name = "txt_HowTo";
            this.txt_HowTo.Size = new System.Drawing.Size(388, 313);
            this.txt_HowTo.TabIndex = 7;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(466, 42);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(94, 20);
            this.lbl_Info.TabIndex = 6;
            this.lbl_Info.Text = "Beskrivning:";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Save.Location = new System.Drawing.Point(723, 384);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(135, 56);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Spara";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Ingredients
            // 
            this.txt_Ingredients.Location = new System.Drawing.Point(170, 165);
            this.txt_Ingredients.Multiline = true;
            this.txt_Ingredients.Name = "txt_Ingredients";
            this.txt_Ingredients.Size = new System.Drawing.Size(266, 93);
            this.txt_Ingredients.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingredienser:";
            // 
            // cB_Category
            // 
            this.cB_Category.FormattingEnabled = true;
            this.cB_Category.Location = new System.Drawing.Point(170, 114);
            this.cB_Category.Name = "cB_Category";
            this.cB_Category.Size = new System.Drawing.Size(214, 28);
            this.cB_Category.TabIndex = 11;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(470, 384);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(135, 56);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.Text = "Stäng";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // FormNewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 514);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.cB_Category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Ingredients);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_HowTo);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Title);
            this.Name = "FormNewRecipe";
            this.Text = "FrmNewRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HowTo;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Ingredients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cB_Category;
        private System.Windows.Forms.Button btn_Close;
    }
}