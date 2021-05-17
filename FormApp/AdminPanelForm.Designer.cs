
namespace FormApp
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ApproveBalance = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.btnApproveProduct = new System.Windows.Forms.Button();
            this.list_Id = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_UserId = new System.Windows.Forms.ListBox();
            this.lst_ApproveStatu = new System.Windows.Forms.ListBox();
            this.lst_UnitsInStock = new System.Windows.Forms.ListBox();
            this.lst_UnitPrice = new System.Windows.Forms.ListBox();
            this.lst_ProductName = new System.Windows.Forms.ListBox();
            this.lst_CategoryName = new System.Windows.Forms.ListBox();
            this.lst_CategoryId = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(7, 402);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 41);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ApproveBalance);
            this.groupBox1.Controls.Add(this.btn_list);
            this.groupBox1.Controls.Add(this.btnApproveProduct);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 489);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btn_ApproveBalance
            // 
            this.btn_ApproveBalance.Location = new System.Drawing.Point(0, 74);
            this.btn_ApproveBalance.Name = "btn_ApproveBalance";
            this.btn_ApproveBalance.Size = new System.Drawing.Size(199, 50);
            this.btn_ApproveBalance.TabIndex = 5;
            this.btn_ApproveBalance.Text = "Bakiye Onay";
            this.btn_ApproveBalance.UseVisualStyleBackColor = true;
            this.btn_ApproveBalance.Click += new System.EventHandler(this.btn_ApproveBalance_Click);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(88, 402);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(74, 41);
            this.btn_list.TabIndex = 4;
            this.btn_list.Text = "Listele";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btnApproveProduct
            // 
            this.btnApproveProduct.Location = new System.Drawing.Point(0, 28);
            this.btnApproveProduct.Name = "btnApproveProduct";
            this.btnApproveProduct.Size = new System.Drawing.Size(199, 40);
            this.btnApproveProduct.TabIndex = 3;
            this.btnApproveProduct.Text = "Ürün Onayla";
            this.btnApproveProduct.UseVisualStyleBackColor = true;
            this.btnApproveProduct.Click += new System.EventHandler(this.btnApproveProduct_Click);
            // 
            // list_Id
            // 
            this.list_Id.FormattingEnabled = true;
            this.list_Id.ItemHeight = 21;
            this.list_Id.Location = new System.Drawing.Point(68, 41);
            this.list_Id.Name = "list_Id";
            this.list_Id.Size = new System.Drawing.Size(93, 424);
            this.list_Id.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lst_UserId);
            this.groupBox2.Controls.Add(this.lst_ApproveStatu);
            this.groupBox2.Controls.Add(this.lst_UnitsInStock);
            this.groupBox2.Controls.Add(this.lst_UnitPrice);
            this.groupBox2.Controls.Add(this.lst_ProductName);
            this.groupBox2.Controls.Add(this.lst_CategoryName);
            this.groupBox2.Controls.Add(this.lst_CategoryId);
            this.groupBox2.Controls.Add(this.list_Id);
            this.groupBox2.Location = new System.Drawing.Point(211, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(993, 477);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(866, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Onay Durumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(729, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stok Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ürün Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ürün İsmi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kategori İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kategori Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kul. Id";
            // 
            // lst_UserId
            // 
            this.lst_UserId.FormattingEnabled = true;
            this.lst_UserId.ItemHeight = 21;
            this.lst_UserId.Location = new System.Drawing.Point(6, 41);
            this.lst_UserId.Name = "lst_UserId";
            this.lst_UserId.Size = new System.Drawing.Size(58, 424);
            this.lst_UserId.TabIndex = 10;
            // 
            // lst_ApproveStatu
            // 
            this.lst_ApproveStatu.FormattingEnabled = true;
            this.lst_ApproveStatu.ItemHeight = 21;
            this.lst_ApproveStatu.Location = new System.Drawing.Point(866, 41);
            this.lst_ApproveStatu.Name = "lst_ApproveStatu";
            this.lst_ApproveStatu.Size = new System.Drawing.Size(127, 424);
            this.lst_ApproveStatu.TabIndex = 9;
            // 
            // lst_UnitsInStock
            // 
            this.lst_UnitsInStock.FormattingEnabled = true;
            this.lst_UnitsInStock.ItemHeight = 21;
            this.lst_UnitsInStock.Location = new System.Drawing.Point(729, 41);
            this.lst_UnitsInStock.Name = "lst_UnitsInStock";
            this.lst_UnitsInStock.Size = new System.Drawing.Size(131, 424);
            this.lst_UnitsInStock.TabIndex = 8;
            // 
            // lst_UnitPrice
            // 
            this.lst_UnitPrice.FormattingEnabled = true;
            this.lst_UnitPrice.ItemHeight = 21;
            this.lst_UnitPrice.Location = new System.Drawing.Point(603, 41);
            this.lst_UnitPrice.Name = "lst_UnitPrice";
            this.lst_UnitPrice.Size = new System.Drawing.Size(120, 424);
            this.lst_UnitPrice.TabIndex = 7;
            // 
            // lst_ProductName
            // 
            this.lst_ProductName.FormattingEnabled = true;
            this.lst_ProductName.ItemHeight = 21;
            this.lst_ProductName.Location = new System.Drawing.Point(419, 41);
            this.lst_ProductName.Name = "lst_ProductName";
            this.lst_ProductName.Size = new System.Drawing.Size(178, 424);
            this.lst_ProductName.TabIndex = 6;
            // 
            // lst_CategoryName
            // 
            this.lst_CategoryName.FormattingEnabled = true;
            this.lst_CategoryName.ItemHeight = 21;
            this.lst_CategoryName.Location = new System.Drawing.Point(272, 41);
            this.lst_CategoryName.Name = "lst_CategoryName";
            this.lst_CategoryName.Size = new System.Drawing.Size(141, 424);
            this.lst_CategoryName.TabIndex = 5;
            // 
            // lst_CategoryId
            // 
            this.lst_CategoryId.FormattingEnabled = true;
            this.lst_CategoryId.ItemHeight = 21;
            this.lst_CategoryId.Location = new System.Drawing.Point(169, 41);
            this.lst_CategoryId.Name = "lst_CategoryId";
            this.lst_CategoryId.Size = new System.Drawing.Size(97, 424);
            this.lst_CategoryId.TabIndex = 4;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApproveProduct;
        private System.Windows.Forms.ListBox list_Id;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_ApproveBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_CategoryId;
        private System.Windows.Forms.ListBox lst_CategoryName;
        private System.Windows.Forms.ListBox lst_ProductName;
        private System.Windows.Forms.ListBox lst_UnitPrice;
        private System.Windows.Forms.ListBox lst_UnitsInStock;
        private System.Windows.Forms.ListBox lst_ApproveStatu;
        private System.Windows.Forms.ListBox lst_UserId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}