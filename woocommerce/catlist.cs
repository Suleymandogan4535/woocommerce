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
    public partial class catlist : Form
    {
        public catlist()
        {
            InitializeComponent();
        }

        private async void catlist_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            var product_cat = await Program.GetWooCommerceCategories();

            var parents = product_cat.Where(p => p.parent == 0);

            foreach (var c in parents)
            {
                treeView1.Nodes.Add(c.name, c.name);
            }


            var children = product_cat.Where(p => p.parent ==1);

            foreach (var b in children)
            {
                int prod_id = (b.parent.GetValueOrDefault());

                var parent_name = await Program.GetWooCommerceSubCategories(prod_id);

                int index = treeView1.Nodes.IndexOfKey(parent_name);
                treeView1.Nodes[index].Nodes.Add(b.name, b.name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home form1 = new home();
            form1.Show();
            this.Close();
        }
    }
}
