
namespace MiniShopApp.Forms
{
    partial class Categories
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBackToHomepage = new System.Windows.Forms.Button();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.textBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListCategories = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonBackToHomepage);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRemoveCategory);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdateCategory);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxCategories);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddCategory);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCategoryDescription);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCategoryName);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonListCategories);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonBackToHomepage
            // 
            this.buttonBackToHomepage.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonBackToHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBackToHomepage.Location = new System.Drawing.Point(21, 392);
            this.buttonBackToHomepage.Name = "buttonBackToHomepage";
            this.buttonBackToHomepage.Size = new System.Drawing.Size(225, 44);
            this.buttonBackToHomepage.TabIndex = 10;
            this.buttonBackToHomepage.Text = "Anasayfaya Dön";
            this.buttonBackToHomepage.UseVisualStyleBackColor = false;
            this.buttonBackToHomepage.Click += new System.EventHandler(this.buttonBackToHomepage_Click);
            // 
            // buttonRemoveCategory
            // 
            this.buttonRemoveCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonRemoveCategory.Enabled = false;
            this.buttonRemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRemoveCategory.Location = new System.Drawing.Point(21, 337);
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.Size = new System.Drawing.Size(225, 36);
            this.buttonRemoveCategory.TabIndex = 9;
            this.buttonRemoveCategory.Text = "Kategori Sil";
            this.buttonRemoveCategory.UseVisualStyleBackColor = false;
            this.buttonRemoveCategory.Click += new System.EventHandler(this.buttonRemoveCategory_Click);
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateCategory.Enabled = false;
            this.buttonUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdateCategory.Location = new System.Drawing.Point(21, 299);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(225, 32);
            this.buttonUpdateCategory.TabIndex = 8;
            this.buttonUpdateCategory.Text = "Kategori Güncelle";
            this.buttonUpdateCategory.UseVisualStyleBackColor = false;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(10, 89);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(236, 21);
            this.comboBoxCategories.TabIndex = 7;
            this.comboBoxCategories.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddCategory.Location = new System.Drawing.Point(21, 261);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(225, 32);
            this.buttonAddCategory.TabIndex = 6;
            this.buttonAddCategory.Text = "Kategori Ekle";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(94, 174);
            this.textBoxCategoryDescription.Multiline = true;
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(152, 81);
            this.textBoxCategoryDescription.TabIndex = 5;
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(94, 132);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(152, 20);
            this.textBoxCategoryName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı";
            // 
            // buttonListCategories
            // 
            this.buttonListCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonListCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListCategories.Location = new System.Drawing.Point(10, 10);
            this.buttonListCategories.Name = "buttonListCategories";
            this.buttonListCategories.Size = new System.Drawing.Size(236, 58);
            this.buttonListCategories.TabIndex = 1;
            this.buttonListCategories.Text = "KATEGORİLERİ LİSTELE";
            this.buttonListCategories.UseVisualStyleBackColor = false;
            this.buttonListCategories.Click += new System.EventHandler(this.buttonListCategories_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KATEGORİLER";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonListCategories;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.TextBox textBoxCategoryDescription;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Button buttonRemoveCategory;
        private System.Windows.Forms.Button buttonUpdateCategory;
        private System.Windows.Forms.Button buttonBackToHomepage;
    }
}