using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShopApp.Forms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            category.Show();
            this.Close();
        }

        private void buttonBrands_Click(object sender, EventArgs e)
        {
            Brands brand = new Brands();
            brand.Show();
            this.Close();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.Show();
            this.Close();
        }
    }
}
