using Business.Concrete;
using Entities.Concrete;
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
    public partial class UserPanelForm : Form
    {
        public UserPanelForm()
        {
            InitializeComponent();
        }
        internal CategoryManager categoryManager;
        internal UserManager userManager;
        internal ProductManager productManager;
        internal User user;

        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            MainLoginForm mainLogin = new MainLoginForm();
            mainLogin.Show();
            this.Close();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            CheckUserType();
            UserInfoFiilToLabel();
            ListOfProducts();
        }

        private void CheckUserType()
        {
            // kullanıcının alıcı mı satıcı mı olduğunu belirleyip ona göre özelliklerin açık olması için yapılan kontrol
            if (user.IsaJustReceiver == true)
                btn_AddProduct.Visible = false;
            if (user.IsaJustSeller == true)
                btn_AddAmount.Visible = false;
        }

        private void UserInfoFiilToLabel()
        {
            lbl_FirstName.Text = user.FirstName;
            lbl_LastName.Text = user.LastName;
            lbl_Identity.Text = user.IdentityNumber;
            lbl_UserName.Text = user.UserName;
            lbl_Password.Text = user.Password;
            lbl_Email.Text = user.Email;
            lbl_PhoneNumb.Text = "0" + user.PhoneNumber;
            lbl_Amount.Text = user.Balance.ToString() + " TL";
            lbl_Adress.Text = user.Adress;
        }

        private void btn_ProductList_Click(object sender, EventArgs e)
        {
            ListOfProducts();

        }

        private void ListOfProducts()
        {
            string strProductStatus = ""; // Ürün onay süreci ekrana basmak için kullanılan değişken
            ClearTheLists();
            string categoryName = "";
            foreach (var product in productManager.GetList())
            {
                if (product.Approve == true)
                    strProductStatus = "Onaylandı";
                else
                    strProductStatus = "Onay Sürecinde";
                // Eğer ürün alınmış ise 
                if (product.IsForSale == false)
                    strProductStatus = "";
                // Ayrı bir varlık sınıfı olan kategori sınıfından kategori ismini çekmek için 
                foreach (var pDto in productManager.GetDetailsByCategoryId( categoryManager.GetList() ))
                {
                    if (pDto.CategoryId == product.CategoryId)
                        categoryName = pDto.CategoryName; 
                }
                // Burada kullanıcının kendisine ait olan ürünlerin listelenmesi 
                if (product.UserId == user.UserId)
                {

                    lst_UserId.Items.Add(product.UserId);
                    list_Id.Items.Add(product.ProductId);
                    lst_CategoryId.Items.Add(product.CategoryId);
                    lst_CategoryName.Items.Add(categoryName);
                    lst_ProductName.Items.Add(product.ProductName);
                    lst_UnitPrice.Items.Add(product.UnitPrice + "   TL");
                    lst_UnitsInStock.Items.Add(product.UnitsInStock + "    " + product.StockType);
                    lst_ApproveStatu.Items.Add(strProductStatus);
                }
            }
           
        }

        private void ClearTheLists()
        {
            // Listbox'ların içlerinin temizlenmesi
            lst_UserId.Items.Clear();
            list_Id.Items.Clear();
            lst_CategoryId.Items.Clear();
            lst_CategoryName.Items.Clear();
            lst_ProductName.Items.Clear();
            lst_UnitPrice.Items.Clear();
            lst_UnitsInStock.Items.Clear();
            lst_ApproveStatu.Items.Clear();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.userId = user.UserId;
            addProductForm.productManager = productManager;
            addProductForm.categoryManager = categoryManager;
            addProductForm.Show();
        }

        private void btn_AddAmount_Click(object sender, EventArgs e)
        {
            AddUserBalanceForm addUserBalance = new AddUserBalanceForm();
            
            addUserBalance.user = user;
            addUserBalance.Show();
        }

        private void btn_Market_Click(object sender, EventArgs e)
        {
            MarketForm marketForm = new MarketForm();
            marketForm.productManager = productManager;
            marketForm.userManager = userManager;
            marketForm.categoryManager = categoryManager;
            marketForm.user = user;
            
            marketForm.Show();
            this.Hide();
        }

    }
}
