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
    public partial class tagform : Form
    {
        

        public tagform()
        {
            InitializeComponent();
        }

        private async void addtagbutton_Click(object sender, EventArgs e)
        {
            string tagName = tagname.Text;
            string tagDescep = tagdesc.Text;
            await Program.AddTag(tagName, tagDescep);
            tagname.Clear();
            tagdesc.Clear();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            home form1 = new home();
            form1.Show();
            this.Close();

        }

        private void tagform_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
