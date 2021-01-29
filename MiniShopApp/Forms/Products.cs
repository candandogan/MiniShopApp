using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniShopApp.Data;
using MiniShopApp.Models;
using MiniShopApp.Services;

namespace MiniShopApp.Forms
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        miniShopDbContext db = new miniShopDbContext();
        ProductBussiness productBussiness = new ProductBussiness();
        private void getProducts() //This function has been defined to display the data in the database.
        {


            dataGridView1.DataSource = productBussiness.GetProduct();
        }
        private void buttonListProduct_Click(object sender, EventArgs e)
        {
            List<Product> product = db.Product.ToList();
            dataGridView1.DataSource = product;
        }


        //While adding products here, we did not control what we did in other forms.
        //Because there may be many products with the same name, with different brands and different categories.
        
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();


            if (string.IsNullOrEmpty(textBoxNameProduct.Text))
            {
                MessageBox.Show("ÜRÜN İSMİ BOŞ BIRAKILAMAZ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newProduct.ImageAdress = textBoxImageAddressProduct.Text;
                newProduct.Name = textBoxNameProduct.Text;
                newProduct.Rating = (double)Convert.ToDecimal(textBoxRatingProduct.Text);
                newProduct.Price = Convert.ToDecimal(textBoxPriceProduct.Text);
                newProduct.Discount = (double)Convert.ToDecimal(textBoxdiscountProduct.Text);
                newProduct.ProductInfos = textBoxInfoProduct.Text;
                newProduct.CategoryId = (int)Convert.ToDecimal(textBoxProductCategoryId.Text);
                newProduct.BrandsId = (int)Convert.ToDecimal(textBoxProductBrandId.Text);


                db.Product.Add(newProduct);
                int affectedRow = db.SaveChanges();
                if (affectedRow > 0)
                {
                    MessageBox.Show("ÜRÜN EKLENMESİ BAŞARILI!");
                    getProducts();
                }
                else
                {
                    MessageBox.Show("ÜRÜN EKLENMESİ BAŞARISIZ...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        Product selectedProduct = null;

        //ComboBox has been defined to list the data in the database.
        //The data to be processed is selected from this list.
        //After the data is selected, the update and delete buttons enable is become true.
        private void comboBoxListProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedProductId = (int)comboBoxListProducts.SelectedValue;
           
            var product = productBussiness.GetProductById(selectedProductId);

            selectedProduct = product;
            textBoxImageAddressProduct.Text = product.ImageAdress;
            textBoxNameProduct.Text = product.Name;
            textBoxRatingProduct.Text= Convert.ToString(product.Rating);
            textBoxPriceProduct.Text = Convert.ToString(product.Price);
            textBoxdiscountProduct.Text = Convert.ToString(product.Discount);
            textBoxInfoProduct.Text = product.ProductInfos;
            textBoxProductCategoryId.Text = Convert.ToString(product.CategoryId);
            textBoxProductBrandId.Text = Convert.ToString(product.BrandsId);


            buttonUpdateProduct.Enabled = true;
            buttonRemoveProduct.Enabled = true;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            getProductsToSelect();
        }
        private void getProductsToSelect()//This function has been defined to be able to list the data in the comboBox.
        {
            

            comboBoxListProducts.DataSource = db.Product.ToList();
            comboBoxListProducts.DisplayMember = "Name";
            comboBoxListProducts.ValueMember = "Id";
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {

            selectedProduct.ImageAdress = textBoxImageAddressProduct.Text;
            selectedProduct.Name = textBoxNameProduct.Text;
            selectedProduct.Rating = (double)Convert.ToDecimal(textBoxRatingProduct.Text);
            selectedProduct.Price = Convert.ToDecimal(textBoxPriceProduct.Text);
            selectedProduct.Discount = (double)Convert.ToDecimal(textBoxdiscountProduct.Text);
            selectedProduct.ProductInfos = textBoxInfoProduct.Text;
            selectedProduct.CategoryId = (int)Convert.ToDecimal(textBoxProductCategoryId.Text);
            selectedProduct.BrandsId = (int)Convert.ToDecimal(textBoxProductBrandId.Text);


            productBussiness.Edit(selectedProduct);
            getProducts();
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            productBussiness.Remove(selectedProduct);
            getProducts();
        }

        private void buttonBackToHomepage_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Close();
        }
    }
}
