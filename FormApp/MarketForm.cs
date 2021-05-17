using Business.Concrete;
using Business.Constants;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class MarketForm : Form
    {
        internal ProductManager productManager;
        internal UserManager userManager;
        internal CategoryManager categoryManager;
        internal User user;
        User SellerUser = new User();
        Product productToBuy = new Product();
        Product product = new Product();
        int choosenProductId;
       
        double demandQuantity;
        bool IsSucces;

        public MarketForm()
        {
            InitializeComponent();
        }
     
        private void MarketForm_Load(object sender, EventArgs e)
        {
            GetListOfProduct();
            CheckUserType();
        }


        private void CheckUserType()
        {
            if (user.IsaJustSeller == true)
            {
                btn_Buy.Visible = false;
                txt_DemandStock.Visible = false;
            }
            if (user.IsaJustReceiver == true)
            {
                btn_AddProduct.Visible = false;
                btn_Buy.Visible = false;
            }
        }

        private void GetListOfProduct()
        {
            ClearTheLists();

            foreach (var product in productManager.GetDetailsByCategoryId(categoryManager.GetList()))
            {
                if ((product.Approve == true) && (product.IsForSale == true) && (product.UserId != user.UserId))
                {
                    lst_UserId.Items.Add(product.UserId);
                    list_Id.Items.Add(product.ProductId);
                    lst_CategoryId.Items.Add(product.CategoryId);
                    lst_CategoryName.Items.Add(product.CategoryName);
                    lst_ProductName.Items.Add(product.ProductName);
                    lst_UnitPrice.Items.Add(product.UnitPrice + " TL");
                    lst_UnitsInStock.Items.Add(product.UnitsInStock + " " + product.StockType);
                }
            }

        }

        private void ClearTheLists()
        {
            lst_UserId.Items.Clear();
            list_Id.Items.Clear();
            lst_CategoryId.Items.Clear();
            lst_CategoryName.Items.Clear();
            lst_ProductName.Items.Clear();
            lst_UnitPrice.Items.Clear();
            lst_UnitsInStock.Items.Clear();
        }
        
        private void btn_Buy_Click(object sender, EventArgs e)
        {            
            string message = "";
            foreach (var p in productManager.GetList() )
            {
                if (p.ProductId == choosenProductId)
                {
                    product = p; // Tamamının alınması durumunda kullanılacak değişkenin adresini atama
                    productToBuy.UserId = p.UserId; // eğer stoğun tamamını almıyorsa kullanılacak değişken atamaları yapma
                    productToBuy.ProductId = p.ProductId;
                    productToBuy.ProductName = p.ProductName;
                    productToBuy.StockType = p.StockType;
                    productToBuy.UnitPrice = p.UnitPrice;
                    productToBuy.UnitsInStock = p.UnitsInStock;
                }

            }
            if (txt_DemandStock.Text != "")
            {
                demandQuantity = Convert.ToDouble(txt_DemandStock.Text);


                // Satan kullanıcın verilerine erişmek için 
                foreach (var user in userManager.GetList())
                {
                    if (user.UserId == productToBuy.UserId)
                        SellerUser = user;
                }
                //Ürünün tamamı satın alınmış ise
                if ((user.Balance >= productToBuy.UnitPrice * demandQuantity) && (demandQuantity <= productToBuy.UnitsInStock) && (demandQuantity == productToBuy.UnitsInStock))
                {
                    product.UserId = user.UserId;
                    user.Balance -= product.UnitPrice * demandQuantity;
                    SellerUser.Balance += product.UnitPrice * demandQuantity;
                    product.Approve = false;
                    product.IsForSale = false;
                    IsSucces = true;
                }
                // Ürünün tamamı satın alınmamış ise
                if ((user.Balance >= productToBuy.UnitPrice * demandQuantity) && (demandQuantity <= productToBuy.UnitsInStock) && (demandQuantity < productToBuy.UnitsInStock))
                {
                    product.UnitsInStock -= demandQuantity;
                    productToBuy.UserId = user.UserId;
                    productToBuy.UnitsInStock = demandQuantity;
                    productToBuy.UnitsInStock = demandQuantity;
                    user.Balance -= productToBuy.UnitPrice * demandQuantity;
                    SellerUser.Balance += productToBuy.UnitPrice * demandQuantity;
                    productToBuy.Approve = false;
                    productToBuy.IsForSale = false;
                    productManager.Add(productToBuy);
                    IsSucces = true;
                }
                // Eğer Bakiye yetersiz ise
                if ((user.Balance < productToBuy.UnitPrice * demandQuantity) && (demandQuantity <= productToBuy.UnitsInStock))
                {
                   // message += " Yetersiz bakiye";
                    message += Messages.InsufficientBalance;
                    txt_DemandStock.Focus();
                    GetListOfProduct();
                    IsSucces = false;

                }
                // Eğer Ürün stoğu yeterli miktarda yok ise
                if ((user.Balance < productToBuy.UnitPrice * demandQuantity) && (demandQuantity > productToBuy.UnitsInStock))
                {
                   // message += " İstediğiniz kadar ürün bulunmamaktadır";
                    message += Messages.InsufficientStock;
                    txt_DemandStock.Focus();
                    GetListOfProduct();
                    IsSucces = false;

                }
                // İşlemin başarılı olup olmadığını kontrol etmek için
                if (IsSucces == true)
                {
                    MessageBox.Show(Messages.SuccessedSale);
                    txt_DemandStock.Focus();
                    GetListOfProduct();
                    return;
                }
                else
                {
                    MessageBox.Show(Messages.FailedSale + message);
                    txt_DemandStock.Focus();
                    GetListOfProduct();
                    return;
                }


            }
            else
            {
                txt_DemandStock.Visible = true;
                txt_DemandStock.Focus();
                MessageBox.Show("Kaç " + product.StockType + " alacağınızı giriniz.");
            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.productManager = productManager;
            addProductForm.userId = user.UserId;
            addProductForm.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UserPanelForm userPanel = new UserPanelForm();
            userPanel.userManager = userManager;
            userPanel.productManager = productManager;
            userPanel.categoryManager = categoryManager;
            userPanel.user = user;
            
            this.Close();
            userPanel.Show();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            GetListOfProduct();
        }

        private void list_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Id.SelectedIndex != -1)
            {
                if ((user.IsaJustSeller == true) && (user.IsaJustReceiver == false))
                    btn_Buy.Visible = false;

                btn_Buy.Visible = true;
                btn_Buy.Enabled = true;

                //txt_DemandStock.Visible = true;
                //txt_DemandStock.Enabled = true;

                choosenProductId = Convert.ToInt32(list_Id.SelectedItem.ToString());
            }
        }
    }
}
