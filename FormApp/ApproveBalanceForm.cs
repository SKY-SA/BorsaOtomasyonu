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
    public partial class ApproveBalanceForm : Form
    {
        internal UserManager userManager;
        int choosenUserId;

        public ApproveBalanceForm()
        {
            InitializeComponent();
        }

        private void ApproveBalance_Load(object sender, EventArgs e)
        {
            ListOfBalanceToApproveList();
        }

        private void ListOfBalanceToApproveList()
        {
            lstId.Items.Clear();
            lstBalance.Items.Clear();
            foreach (var user in userManager.GetList())
            {
                if (user.BalanceApprove == false)
                {
                    lstId.Items.Add(user.UserId);
                    lstBalance.Items.Add(user.AddBalance);
                }
            }
            btn_Accept.Enabled = false;
        }

        private void lstId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //choosenUserId = 0;
            if(lstId.SelectedIndex != -1)
            {
                choosenUserId = Convert.ToInt32(lstId.SelectedItem.ToString());
                btn_Accept.Enabled = true;
            }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            foreach (var user in userManager.GetList())
            {
                if(user.UserId == choosenUserId)
                {
                    user.Balance += user.AddBalance;
                    user.AddBalance = 0;
                    user.BalanceApprove = true;
                    MessageBox.Show("Bakiye Onaylama başarılı bir şekilde yapılmıştır.");
                }
            }
            ListOfBalanceToApproveList();
        }
    }
}
