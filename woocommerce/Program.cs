using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v2;
using WooCommerceNET.WooCommerce.v2.Extension;

namespace woocommerce
{
    
    static class Program
    {

        /// <summary>
        /// RestAPI("url + /wp-json/wc/v2", "customerkey", "customersecret"); 
        /// Please Check!!!
        /// </summary>

        static RestAPI rest = new RestAPI("http://localhost/woocommercetest/wp-json/wc/v2", "ck_bf624cb514b8fa652f24cc596adb61240367bd69", "cs_47c2fe9d6c78c7e1023215ffea2fe802cf498cef"); 
        static WCObject wc = new WCObject(rest);

        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());
        }
        


        public static async Task AddProductMethod(string name, string desc, decimal price,decimal sprice)
        {
            string nme = name;

            

            await Task.Run(async () =>
            {

                Product p = new Product()
                {
                    name = nme,
                    description = desc,
                    regular_price = price,
                    sale_price= sprice,
                    
                };
                await wc.Product.Add(p);
            });
        }  //Add New Product Method

        public static async Task AddCategoryMethod(string name, string desc,string displaytype)
        {
            string nme = name;

            await Task.Run(async () =>
            {

                ProductCategory c = new ProductCategory()
                {
                    name = nme,
                    description = desc,
                    display = displaytype,

                };
                await wc.Category.Add(c);
            });
        }  // Add New Category Method


        public static async Task<List<ProductCategory>> GetWooCommerceCategories()
        {
           
            try
            {
                var prod_cats = await wc.Category.GetAll();
                return prod_cats;
            }
            catch
            { }

            return new List<ProductCategory>();
        }  //List Category Method 

        public static async Task<string> GetWooCommerceSubCategories(int id)
        {

          
            var prod_cats = await wc.Category.Get(id);
            var name = prod_cats.name;

            return name;

        }  // List Subcategory Method (Only parent==1)

        public static async Task AddTag(string name, string desc)
        {
            string nme = name;

            await Task.Run(async () =>
            {
                ProductTag t = new ProductTag()
                {
                    name = nme,
                    description = desc,

                };
                await wc.Tag.Add(t);
            });
        }  // Add New Tag Method 

        public static async Task<List<ProductTag>> GetProductTag()
        {

            try
            {
                var prod_cats = await wc.Tag.GetAll();
                return prod_cats;
            }
            catch
            { }

            return new List<ProductTag>();
        }  /// List Tag Method !!! Not Tried !!!

    }
}

