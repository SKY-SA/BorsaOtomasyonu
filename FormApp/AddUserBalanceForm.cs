using Business.Constants;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormApp
{
    public partial class AddUserBalanceForm : Form
    {
        public AddUserBalanceForm()
        {
            InitializeComponent();
        }
        internal User user;
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            user.AddBalance = Convert.ToDouble(textBox1.Text);
            //Eklenen bakiyenin admin formunda onaylanacak bakiyeler arasında gözükmesi için
            user.BalanceApprove = false;
            MessageBox.Show(user.AddBalance.ToString()  +" TL \n" + Messages.AddedBalance);
            this.Close();
            
        }

        private void AddUserBalance_Load(object sender, EventArgs e)
        {
            btn_Accept.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_Accept.Enabled = true;
        }
    }
}
