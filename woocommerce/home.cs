using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET;
using WooCommerceNET.Base;
using WooCommerceNET.WooCommerce.v2;
using WooCommerceNET.WooCommerce.v2.Extension;




namespace woocommerce
{
    public partial class home : Form
    {
        
        public home()
        {
            InitializeComponent();
        }
        
        // Ürün Ekleme Butonu
        private async void Addproduct_Click(object sender, EventArgs e)
        {
            
            string prodname = productnametext.Text;
            string desc = descprodtext.Text;
            decimal regular_price = Convert.ToDecimal(textBox4.Text);
            decimal sale_price = Convert.ToDecimal(textBox1.Text);
            await Program.AddProductMethod(prodname, desc, regular_price, sale_price);
            
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        

        private void etiketlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tagform tagfrm = new tagform();
            tagfrm.Show();
            this.Hide();
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryform catfrm = new categoryform();
            catfrm.Show();
            this.Close();
        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryform catfrm = new categoryform();
            catfrm.Show();
            this.Close();
        }
    }
}

