
namespace FormApp
{
    partial class ApproveProductForm
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
            this.btnApproveProduct = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.lst_ProductId = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApproveProduct
            // 
            this.btnApproveProduct.Location = new System.Drawing.Point(864, 495);
            this.btnApproveProduct.Name = "btnApproveProduct";
            this.btnApproveProduct.Size = new System.Drawing.Size(141, 45);
            this.btnApproveProduct.TabIndex = 1;
            this.btnApproveProduct.Text = "Ürünü Onayla";
            this.btnApproveProduct.UseVisualStyleBackColor = true;
            this.btnApproveProduct.Click += new System.EventHandler(this.btnApproveProduct_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 495);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(141, 45);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Önceki Sayfaya Git";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_List
            // 
            this.btn_List.Location = new System.Drawing.Point(717, 495);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(141, 45);
            this.btn_List.TabIndex = 3;
            this.btn_List.Text = "Ürünleri Listele";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lst_UserId);
            this.groupBox1.Controls.Add(this.lst_ApproveStatu);
            this.groupBox1.Controls.Add(this.lst_UnitsInStock);
            this.groupBox1.Controls.Add(this.lst_UnitPrice);
            this.groupBox1.Controls.Add(this.lst_ProductName);
            this.groupBox1.Controls.Add(this.lst_CategoryName);
            this.groupBox1.Controls.Add(this.lst_CategoryId);
            this.groupBox1.Controls.Add(this.lst_ProductId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 477);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(866, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Onay Durumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(729, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stok Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ürün Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ürün İsmi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kategori İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kategori Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kul. Id";
            // 
            // lst_UserId
            // 
            this.lst_UserId.FormattingEnabled = true;
            this.lst_UserId.ItemHeight = 15;
            this.lst_UserId.Location = new System.Drawing.Point(6, 41);
            this.lst_UserId.Name = "lst_UserId";
            this.lst_UserId.Size = new System.Drawing.Size(58, 424);
            this.lst_UserId.TabIndex = 10;
            // 
            // lst_ApproveStatu
            // 
            this.lst_ApproveStatu.FormattingEnabled = true;
            this.lst_ApproveStatu.ItemHeight = 15;
            this.lst_ApproveStatu.Location = new System.Drawing.Point(866, 41);
            this.lst_ApproveStatu.Name = "lst_ApproveStatu";
            this.lst_ApproveStatu.Size = new System.Drawing.Size(127, 424);
            this.lst_ApproveStatu.TabIndex = 9;
            // 
            // lst_UnitsInStock
            // 
            this.lst_UnitsInStock.FormattingEnabled = true;
            this.lst_UnitsInStock.ItemHeight = 15;
            this.lst_UnitsInStock.Location = new System.Drawing.Point(729, 41);
            this.lst_UnitsInStock.Name = "lst_UnitsInStock";
            this.lst_UnitsInStock.Size = new System.Drawing.Size(131, 424);
            this.lst_UnitsInStock.TabIndex = 8;
            // 
            // lst_UnitPrice
            // 
            this.lst_UnitPrice.FormattingEnabled = true;
            this.lst_UnitPrice.ItemHeight = 15;
            this.lst_UnitPrice.Location = new System.Drawing.Point(603, 41);
            this.lst_UnitPrice.Name = "lst_UnitPrice";
            this.lst_UnitPrice.Size = new System.Drawing.Size(120, 424);
            this.lst_UnitPrice.TabIndex = 7;
            // 
            // lst_ProductName
            // 
            this.lst_ProductName.FormattingEnabled = true;
            this.lst_ProductName.ItemHeight = 15;
            this.lst_ProductName.Location = new System.Drawing.Point(419, 41);
            this.lst_ProductName.Name = "lst_ProductName";
            this.lst_ProductName.Size = new System.Drawing.Size(178, 424);
            this.lst_ProductName.TabIndex = 6;
            // 
            // lst_CategoryName
            // 
            this.lst_CategoryName.FormattingEnabled = true;
            this.lst_CategoryName.ItemHeight = 15;
            this.lst_CategoryName.Location = new System.Drawing.Point(272, 41);
            this.lst_CategoryName.Name = "lst_CategoryName";
            this.lst_CategoryName.Size = new System.Drawing.Size(141, 424);
            this.lst_CategoryName.TabIndex = 5;
            // 
            // lst_CategoryId
            // 
            this.lst_CategoryId.FormattingEnabled = true;
            this.lst_CategoryId.ItemHeight = 15;
            this.lst_CategoryId.Location = new System.Drawing.Point(169, 41);
            this.lst_CategoryId.Name = "lst_CategoryId";
            this.lst_CategoryId.Size = new System.Drawing.Size(97, 424);
            this.lst_CategoryId.TabIndex = 4;
            // 
            // lst_ProductId
            // 
            this.lst_ProductId.FormattingEnabled = true;
            this.lst_ProductId.ItemHeight = 15;
            this.lst_ProductId.Location = new System.Drawing.Point(68, 41);
            this.lst_ProductId.Name = "lst_ProductId";
            this.lst_ProductId.Size = new System.Drawing.Size(93, 424);
            this.lst_ProductId.TabIndex = 3;
            this.lst_ProductId.SelectedIndexChanged += new System.EventHandler(this.lst_ProductId_SelectedIndexChanged);
            // 
            // ApproveProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btnApproveProduct);
            this.Name = "ApproveProductForm";
            this.Text = "Listele";
            this.Load += new System.EventHandler(this.ApproveProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApproveProduct;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_UserId;
        private System.Windows.Forms.ListBox lst_ApproveStatu;
        private System.Windows.Forms.ListBox lst_UnitsInStock;
        private System.Windows.Forms.ListBox lst_UnitPrice;
        private System.Windows.Forms.ListBox lst_ProductName;
        private System.Windows.Forms.ListBox lst_CategoryName;
        private System.Windows.Forms.ListBox lst_CategoryId;
        private System.Windows.Forms.ListBox lst_ProductId;
    }
}