
namespace MiniShopApp.Forms
{
    partial class Products
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
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductBrandId = new System.Windows.Forms.TextBox();
            this.textBoxProductCategoryId = new System.Windows.Forms.TextBox();
            this.textBoxdiscountProduct = new System.Windows.Forms.TextBox();
            this.textBoxPriceProduct = new System.Windows.Forms.TextBox();
            this.textBoxRatingProduct = new System.Windows.Forms.TextBox();
            this.textBoxInfoProduct = new System.Windows.Forms.TextBox();
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.textBoxImageAddressProduct = new System.Windows.Forms.TextBox();
            this.comboBoxListProducts = new System.Windows.Forms.ComboBox();
            this.buttonListProduct = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonRemoveProduct);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddProduct);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdateProduct);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProductBrandId);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProductCategoryId);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxdiscountProduct);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPriceProduct);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxRatingProduct);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxInfoProduct);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNameProduct);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxImageAddressProduct);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxListProducts);
            this.splitContainer1.Panel1.Controls.Add(this.buttonListProduct);
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
            this.buttonBackToHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBackToHomepage.Location = new System.Drawing.Point(3, 402);
            this.buttonBackToHomepage.Name = "buttonBackToHomepage";
            this.buttonBackToHomepage.Size = new System.Drawing.Size(253, 34);
            this.buttonBackToHomepage.TabIndex = 20;
            this.buttonBackToHomepage.Text = "Anasayfaya Dön";
            this.buttonBackToHomepage.UseVisualStyleBackColor = false;
            this.buttonBackToHomepage.Click += new System.EventHandler(this.buttonBackToHomepage_Click);
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonRemoveProduct.Enabled = false;
            this.buttonRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRemoveProduct.Location = new System.Drawing.Point(6, 343);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(253, 23);
            this.buttonRemoveProduct.TabIndex = 19;
            this.buttonRemoveProduct.Text = "Ürün Sil";
            this.buttonRemoveProduct.UseVisualStyleBackColor = false;
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddProduct.Location = new System.Drawing.Point(6, 285);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(253, 23);
            this.buttonAddProduct.TabIndex = 18;
            this.buttonAddProduct.Text = "Ürün Ekle";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ürün Resim Adresi";
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateProduct.Enabled = false;
            this.buttonUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdateProduct.Location = new System.Drawing.Point(6, 314);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(253, 23);
            this.buttonUpdateProduct.TabIndex = 21;
            this.buttonUpdateProduct.Text = "Ürün Güncelle";
            this.buttonUpdateProduct.UseVisualStyleBackColor = false;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ürün Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ürünün Puanı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürün Marka Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ürün Kategori Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ürünün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "İndirim Miktarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün Bilgisi";
            // 
            // textBoxProductBrandId
            // 
            this.textBoxProductBrandId.Location = new System.Drawing.Point(102, 252);
            this.textBoxProductBrandId.Name = "textBoxProductBrandId";
            this.textBoxProductBrandId.Size = new System.Drawing.Size(157, 20);
            this.textBoxProductBrandId.TabIndex = 9;
            // 
            // textBoxProductCategoryId
            // 
            this.textBoxProductCategoryId.Location = new System.Drawing.Point(102, 226);
            this.textBoxProductCategoryId.Name = "textBoxProductCategoryId";
            this.textBoxProductCategoryId.Size = new System.Drawing.Size(157, 20);
            this.textBoxProductCategoryId.TabIndex = 8;
            // 
            // textBoxdiscountProduct
            // 
            this.textBoxdiscountProduct.Location = new System.Drawing.Point(102, 174);
            this.textBoxdiscountProduct.Name = "textBoxdiscountProduct";
            this.textBoxdiscountProduct.Size = new System.Drawing.Size(157, 20);
            this.textBoxdiscountProduct.TabIndex = 7;
            // 
            // textBoxPriceProduct
            // 
            this.textBoxPriceProduct.Location = new System.Drawing.Point(102, 148);
            this.textBoxPriceProduct.Name = "textBoxPriceProduct";
            this.textBoxPriceProduct.Size = new System.Drawing.Size(157, 20);
            this.textBoxPriceProduct.TabIndex = 6;
            // 
            // textBoxRatingProduct
            // 
            this.textBoxRatingProduct.Location = new System.Drawing.Point(102, 122);
            this.textBoxRatingProduct.Name = "textBoxRatingProduct";
            this.textBoxRatingProduct.Size = new System.Drawing.Size(157, 20);
            this.textBoxRatingProduct.TabIndex = 5;
            // 
            // textBoxInfoProduct
            // 
            this.textBoxInfoProduct.Location = new System.Drawing.Point(102, 200);
            this.textBoxInfoProduct.Multiline = true;
            this.textBoxInfoProduct.Name = "textBoxInfoProduct";
            this.textBoxInfoProduct.Size = new System.Drawing.Size(157, 20);
            this.textBoxInfoProduct.TabIndex = 4;
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.Location = new System.Drawing.Point(102, 96);
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(157, 20);
            this.textBoxNameProduct.TabIndex = 3;
            // 
            // textBoxImageAddressProduct
            // 
            this.textBoxImageAddressProduct.Location = new System.Drawing.Point(102, 70);
            this.textBoxImageAddressProduct.Name = "textBoxImageAddressProduct";
            this.textBoxImageAddressProduct.Size = new System.Drawing.Size(157, 20);
            this.textBoxImageAddressProduct.TabIndex = 2;
            // 
            // comboBoxListProducts
            // 
            this.comboBoxListProducts.FormattingEnabled = true;
            this.comboBoxListProducts.Location = new System.Drawing.Point(3, 43);
            this.comboBoxListProducts.Name = "comboBoxListProducts";
            this.comboBoxListProducts.Size = new System.Drawing.Size(256, 21);
            this.comboBoxListProducts.TabIndex = 1;
            this.comboBoxListProducts.SelectionChangeCommitted += new System.EventHandler(this.comboBoxListProducts_SelectionChangeCommitted);
            // 
            // buttonListProduct
            // 
            this.buttonListProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonListProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListProduct.Location = new System.Drawing.Point(3, 3);
            this.buttonListProduct.Name = "buttonListProduct";
            this.buttonListProduct.Size = new System.Drawing.Size(256, 34);
            this.buttonListProduct.TabIndex = 0;
            this.buttonListProduct.Text = "ÜRÜNLERİ LİSTELE";
            this.buttonListProduct.UseVisualStyleBackColor = false;
            this.buttonListProduct.Click += new System.EventHandler(this.buttonListProduct_Click);
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
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.Products_Load);
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
        private System.Windows.Forms.ComboBox comboBoxListProducts;
        private System.Windows.Forms.Button buttonListProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductBrandId;
        private System.Windows.Forms.TextBox textBoxProductCategoryId;
        private System.Windows.Forms.TextBox textBoxdiscountProduct;
        private System.Windows.Forms.TextBox textBoxPriceProduct;
        private System.Windows.Forms.TextBox textBoxRatingProduct;
        private System.Windows.Forms.TextBox textBoxInfoProduct;
        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.TextBox textBoxImageAddressProduct;
        private System.Windows.Forms.Button buttonBackToHomepage;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonUpdateProduct;
    }
}