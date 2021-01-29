
namespace MiniShopApp.Forms
{
    partial class Brands
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
            this.buttonRemoveBrand = new System.Windows.Forms.Button();
            this.buttonUpdateBrand = new System.Windows.Forms.Button();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.comboBoxListBrands = new System.Windows.Forms.ComboBox();
            this.textBoxBrandName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonRemoveBrand);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdateBrand);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddBrand);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxListBrands);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxBrandName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
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
            this.buttonBackToHomepage.Location = new System.Drawing.Point(13, 355);
            this.buttonBackToHomepage.Name = "buttonBackToHomepage";
            this.buttonBackToHomepage.Size = new System.Drawing.Size(246, 64);
            this.buttonBackToHomepage.TabIndex = 8;
            this.buttonBackToHomepage.Text = "Anasayfaya Dön";
            this.buttonBackToHomepage.UseVisualStyleBackColor = false;
            this.buttonBackToHomepage.Click += new System.EventHandler(this.buttonBackToHomepage_Click);
            // 
            // buttonRemoveBrand
            // 
            this.buttonRemoveBrand.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonRemoveBrand.Enabled = false;
            this.buttonRemoveBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRemoveBrand.Location = new System.Drawing.Point(13, 275);
            this.buttonRemoveBrand.Name = "buttonRemoveBrand";
            this.buttonRemoveBrand.Size = new System.Drawing.Size(246, 41);
            this.buttonRemoveBrand.TabIndex = 6;
            this.buttonRemoveBrand.Text = "Marka Sil";
            this.buttonRemoveBrand.UseVisualStyleBackColor = false;
            this.buttonRemoveBrand.Click += new System.EventHandler(this.buttonRemoveBrand_Click);
            // 
            // buttonUpdateBrand
            // 
            this.buttonUpdateBrand.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateBrand.Enabled = false;
            this.buttonUpdateBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdateBrand.Location = new System.Drawing.Point(13, 230);
            this.buttonUpdateBrand.Name = "buttonUpdateBrand";
            this.buttonUpdateBrand.Size = new System.Drawing.Size(246, 39);
            this.buttonUpdateBrand.TabIndex = 5;
            this.buttonUpdateBrand.Text = "Marka Güncelle";
            this.buttonUpdateBrand.UseVisualStyleBackColor = false;
            this.buttonUpdateBrand.Click += new System.EventHandler(this.buttonUpdateBrand_Click);
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddBrand.Location = new System.Drawing.Point(13, 183);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(246, 41);
            this.buttonAddBrand.TabIndex = 4;
            this.buttonAddBrand.Text = "Marka Ekle";
            this.buttonAddBrand.UseVisualStyleBackColor = false;
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // comboBoxListBrands
            // 
            this.comboBoxListBrands.FormattingEnabled = true;
            this.comboBoxListBrands.Location = new System.Drawing.Point(10, 89);
            this.comboBoxListBrands.Name = "comboBoxListBrands";
            this.comboBoxListBrands.Size = new System.Drawing.Size(249, 21);
            this.comboBoxListBrands.TabIndex = 3;
            this.comboBoxListBrands.SelectionChangeCommitted += new System.EventHandler(this.comboBoxListBrands_SelectionChangeCommitted);
            // 
            // textBoxBrandName
            // 
            this.textBoxBrandName.Location = new System.Drawing.Point(108, 135);
            this.textBoxBrandName.Name = "textBoxBrandName";
            this.textBoxBrandName.Size = new System.Drawing.Size(151, 20);
            this.textBoxBrandName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka Adı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "MARKALARI LİSTELE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Brands";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARKALAR";
            this.Load += new System.EventHandler(this.Brands_Load);
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
        private System.Windows.Forms.Button buttonRemoveBrand;
        private System.Windows.Forms.Button buttonUpdateBrand;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.ComboBox comboBoxListBrands;
        private System.Windows.Forms.TextBox textBoxBrandName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBackToHomepage;
    }
}