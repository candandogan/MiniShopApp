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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        miniShopDbContext db = new miniShopDbContext();
        CategoryBussiness categoryBussiness = new CategoryBussiness();
        private void getCategories() //This function has been defined to display the data in the database.
        {


            dataGridView1.DataSource = categoryBussiness.GetCategories();
        }
        private void buttonListCategories_Click(object sender, EventArgs e)
        {
            
            List<Category> category = db.Categories.ToList();
            dataGridView1.DataSource = category;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category();

            
            if (string.IsNullOrEmpty(textBoxCategoryName.Text))
            {
                MessageBox.Show("KATEGORİ İSMİ BOŞ BIRAKILAMAZ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //This method compares the category name taken from the textBox with the category names in the database. 
                //If you already have a category name, it will prevent you from adding another.
                var IsCategoryExist = db.Categories.Where(x => x.Name == textBoxCategoryName.Text).FirstOrDefault();


                if (IsCategoryExist != null)
                {
                    MessageBox.Show("BU KATEGORİ MEVCUT BU NEDENLE EKLENEMEZ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    newCategory.Name = textBoxCategoryName.Text;
                    newCategory.Description = textBoxCategoryDescription.Text;


                    db.Categories.Add(newCategory);
                        int affectedRow = db.SaveChanges();
                        if (affectedRow > 0)
                        {
                            MessageBox.Show("KATEGORİ EKLENMESİ BAŞARILI!");
                            getCategories();
                        }
                        else
                        {
                            MessageBox.Show("KATEGORİ EKLENMESİ BAŞARISIZ...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    }
                }

            }
        private void getCategoriesToSelect()//This function has been defined to be able to list the data in the comboBox.
        {

            comboBoxCategories.DataSource = db.Categories.ToList();
            comboBoxCategories.DisplayMember = "Name";
            comboBoxCategories.ValueMember = "Id";
        }
        Category selectedCategory = null;

        //ComboBox has been defined to list the data in the database.
        //The data to be processed is selected from this list.
        //After the data is selected, the update and delete buttons enable is become true.
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBoxCategories.SelectedValue;
           
            var category = categoryBussiness.GetCategoryById(selectedCategoryId);

            selectedCategory = category;
            textBoxCategoryName.Text = category.Name;
            textBoxCategoryDescription.Text = category.Description;
            buttonUpdateCategory.Enabled = true;
            buttonRemoveCategory.Enabled = true;
        }

        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            selectedCategory.Name = textBoxCategoryName.Text;
            selectedCategory.Description = textBoxCategoryDescription.Text;
            categoryBussiness.Edit(selectedCategory);
            getCategories();
        }

        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            //This method compares the identity of the category to be deleted with the category identities in the products database.
            //If there is a product with the identity of the category to be deleted, the category cannot be deleted.
            var CategoryHasProduct = db.Product.Where(x => x.CategoryId == selectedCategory.Id).FirstOrDefault();

            if (CategoryHasProduct != null)
            {
                MessageBox.Show("BU KATEGORİNİN İÇİNDE ÜRÜN MEVCUT BU NEDENLE SİLİNEMEZ!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                categoryBussiness.Remove(selectedCategory);
                MessageBox.Show("KATEGORİ SİLİNDİ.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getCategories();
            }
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            getCategoriesToSelect();
        }

        

        private void buttonBackToHomepage_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Close();
        }
    }
}
