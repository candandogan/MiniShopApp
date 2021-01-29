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
    public partial class Brands : Form
    {
        public Brands()
        {
            InitializeComponent();
        }
        miniShopDbContext db = new miniShopDbContext();
        BrandBussiness brandBussiness = new BrandBussiness();
        private void getBrands() //This function has been defined to display the data in the database.
        {


            dataGridView1.DataSource = brandBussiness.GetBrands();
        }
        private void button1_Click(object sender, EventArgs e) //display the data in the database
        {
            List<Brand> brand = db.Brands.ToList();
            dataGridView1.DataSource = brand;
        }
        Brand selectedBrand = null;

        //ComboBox has been defined to list the data in the database.
        //The data to be processed is selected from this list.
        //After the data is selected, the update and delete buttons enable is become true.
        private void comboBoxListBrands_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedBrandId = (int)comboBoxListBrands.SelectedValue;
           
            var brand = brandBussiness.GetBrandById(selectedBrandId);

            selectedBrand = brand;
            textBoxBrandName.Text = brand.Name;
            
            buttonUpdateBrand.Enabled = true;
            buttonRemoveBrand.Enabled = true;
        }

        
        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            selectedBrand.Name = textBoxBrandName.Text;
            
            brandBussiness.Edit(selectedBrand);
            getBrands();
        }

        private void Brands_Load(object sender, EventArgs e)
        {
            getBrandsToSelect();
        }
        private void getBrandsToSelect() //This function has been defined to be able to list the data in the comboBox.
        {

            comboBoxListBrands.DataSource = db.Brands.ToList();
            comboBoxListBrands.DisplayMember = "Name";
            comboBoxListBrands.ValueMember = "Id";
        }

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            Brand newBrand = new Brand();

            
            if (string.IsNullOrEmpty(textBoxBrandName.Text))
            {
                MessageBox.Show("MARKANIN İSMİ BOŞ BIRAKILAMAZ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                //This method compares the brand name taken from the textBox with the brand names in the database. 
                //If you already have a brand name, it will prevent you from adding another.
                var IsBrandExist = db.Brands.Where(x => x.Name == textBoxBrandName.Text).FirstOrDefault();


                if (IsBrandExist != null)
                {
                    MessageBox.Show("BU MARKA MEVCUT BU NEDENLE EKLENEMEZ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    newBrand.Name = textBoxBrandName.Text;
                    


                    db.Brands.Add(newBrand);
                    int affectedRow = db.SaveChanges();
                    if (affectedRow > 0)
                    {
                        MessageBox.Show("MARKA EKLENMESİ BAŞARILI!");
                        getBrands();
                    }
                    else
                    {
                        MessageBox.Show("MARKA EKLENMESİ BAŞARISIZ...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonBackToHomepage_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Close();
        }

        private void buttonRemoveBrand_Click(object sender, EventArgs e)
        {
            //This method compares the identity of the brand to be deleted with the brand identities in the products database.
            //If there is a product with the identity of the brand to be deleted, the brand cannot be deleted.
            var BrandHasProduct = db.Product.Where(x => x.BrandsId == selectedBrand.Id).FirstOrDefault();

            if (BrandHasProduct != null)
            {
                MessageBox.Show("BU MARKANIN İÇİNDE ÜRÜN MEVCUT BU NEDENLE SİLİNEMEZ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                brandBussiness.Remove(selectedBrand);
                MessageBox.Show("MARKA SİLİNDİ.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getBrands();
            }
        }

        private void buttonUpdateBrand_Click(object sender, EventArgs e)
        {
            selectedBrand.Name = textBoxBrandName.Text;
            brandBussiness.Edit(selectedBrand);
            getBrands();
        }
    }
}
