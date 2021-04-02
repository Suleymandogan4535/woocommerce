using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace woocommerce
{
    public partial class categoryform : Form
    {

        public categoryform()
        {
            InitializeComponent();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {

            home form1 = new home();
            form1.Show();
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string category_name = textBox5.Text;
            //string category_parent = comboBox1.SelectedItem.ToString();  //
            string category_desc = textBox7.Text;
            string view_type = comboBox2.SelectedItem.ToString();

            if (view_type == "Varsayılan") view_type = "default";
            else if (view_type == "Ürünler") view_type = "products";
            else if (view_type == "Alt Kategoriler") view_type = "subcategories";
            else view_type = "both";

            await Program.AddCategoryMethod(category_name, category_desc, view_type);

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            comboBox2.SelectedIndex = 0;
        }

        private void categoryform_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

