using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranApp_1
{
    public partial class MainForm : Form
    {
        ArrayList products = new ArrayList();
        public MainForm()
        {
            InitializeComponent();
            products.Add(new Product
            {
                Id = 1,
                Count = 43,
                Name = "Kabab",
                Price = 4,
                productCategory = ProductCategory.MainFoods
            });
            products.Add(new Product
            {
                Id = 2,
                Count = 41,
                Name = "Dolma",
                Price = 9.20M,
                productCategory = ProductCategory.MainFoods
            });
            products.Add(new Product
            {
                Id = 3,
                Count = 39,
                Name = "Shah Plov",
                Price = 11.50M,
                productCategory = ProductCategory.MainFoods
            });
            products.Add(new Product
            {
                Id = 4,
                Count = 40,
                Name = "Meat Soup",
                Price = 3.80M,
                productCategory = ProductCategory.Soups
            });
            products.Add(new Product
            {
                Id = 5,
                Count = 38,
                Name = "Lentil Soup",
                Price = 3.60M,
                productCategory = ProductCategory.Soups
            });
            products.Add(new Product
            {
                Id = 6,
                Count = 47,
                Name = "Caesar Salad",
                Price = 6.80M,
                productCategory = ProductCategory.Salad
            });
            products.Add(new Product
            {
                Id = 7,
                Count = 43,
                Name = "Mimosa Salad",
                Price = 4.60M,
                productCategory = ProductCategory.Salad
            });
            products.Add(new Product
            {
                Id = 8,
                Count = 45,
                Name = "Napoleon",
                Price = 4.40M,
                productCategory = ProductCategory.Deserts
            });
            products.Add(new Product
            {
                Id = 9,
                Count = 41,
                Name = "Cheesecake",
                Price = 5,
                productCategory = ProductCategory.Deserts
            });
            products.Add(new Product
            {
                Id = 10,
                Count = 96,
                Name = "Ayran",
                Price = 1.20M,
                productCategory = ProductCategory.Drinks
            });
            products.Add(new Product
            {
                Id = 11,
                Count = 100,
                Name = "Limonad",
                Price = 2,
                productCategory = ProductCategory.Drinks
            });

            Load_Categories();
        }

        private void Load_Categories()
        {
            string[] categoryNames = Enum.GetNames(typeof(ProductCategory));
            cmbx_categories.DataSource = categoryNames;
        }


        private void cmbx_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedFoodName = (sender as ComboBox).SelectedIndex.ToString();

            ArrayList appearingProducts = new ArrayList();
            foreach(Product p in products)
            {
                
                ProductCategory selectedCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), selectedFoodName);

                if (p.productCategory == selectedCategory)
                {
                    appearingProducts.Add(p);
                }
            }
            cmbx_products.DataSource = appearingProducts;
            cmbx_products.DisplayMember = "Name";
            
        }

        Product selectedProduct = new Product();

        private void cmbx_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)((sender as ComboBox).SelectedValue);
            txtx_Price.Text = selectedProduct.Price.ToString();
           
        }

        Basket basket = new Basket();

        private void btn_order_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txtx_count.Text);

            ProductItem productItem = new ProductItem
            {
                Count = count,
                Name = selectedProduct.Name,
                ProductId = selectedProduct.Id,
                TotalPrice = count * selectedProduct.Price
            };

            basket.ProductItems.Add(productItem);
            dgv_Basket.DataSource = null;
            dgv_Basket.DataSource = basket.ProductItems;

            lbl_totalPrice.Text = GetTotalPrice(basket.ProductItems).ToString();
        }

        private decimal GetTotalPrice(ArrayList arrayList)
        {
            decimal Price = 0;
            foreach(ProductItem pi in arrayList)
            {
                Price += pi.TotalPrice;
            }
            return Price;
        }
    }
}
