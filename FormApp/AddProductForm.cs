using Business.Concrete;
using Business.Constants;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormApp
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        internal CategoryManager categoryManager;
        internal ProductManager productManager;
        internal int userId;
        int choosenCategoryId;

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string message = "";
            CheckIsBoxEmpty(message, isError);
            Product productToAdd = new Product();
            FillObject(productToAdd);
            productManager.Add(productToAdd);
            CheckIfProductAdded(productToAdd);
        }
        private void CheckIsBoxEmpty(string message, bool isError)
        {
            string strProductName = txt_Name.Text;
            string strPrice = txt_Price.Text;
            string strStock = txt_Stock.Text;
            if (string.IsNullOrEmpty(strProductName))
            {
                message += " İsim ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strPrice))
            {
                message += " Fiyat ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strStock))
            {
                message += " Stok Adeti ";
                isError = true;
            }
            if (isError == true)
            {
                message += " boş bırakılamaz ";
                return;
            }
        }
        private void CheckIfProductAdded(Product productToAdd)
        {
            foreach (var p in productManager.GetList())
            {
                if (p == productToAdd)
                {
                    MessageBox.Show(Messages.AddedProduct);
                    this.Close();
                    break;
                }
            }
        }

        private void FillObject( Product productToAdd)
        {
            productToAdd.UserId = userId;
            productToAdd.CategoryId = choosenCategoryId;
            productToAdd.ProductName = txt_Name.Text;
            productToAdd.UnitPrice = Convert.ToDouble(txt_Price.Text);
            productToAdd.UnitsInStock = Convert.ToDouble(txt_Stock.Text);
            productToAdd.StockType = comboBox1.SelectedItem.ToString();
            productToAdd.Approve = false;
            productToAdd.IsForSale = true;
            
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            foreach (var category in categoryManager.GetList())
            {
                cmb_Categories.Items.Add(category.CategoryName);
            }
        }

        private void cmb_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Categories.SelectedIndex != -1)
            {
                choosenCategoryId = cmb_Categories.SelectedIndex + 1;
            }
        }
    }
}
