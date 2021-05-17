
namespace FormApp
{
    partial class ApproveBalanceForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBalance = new System.Windows.Forms.ListBox();
            this.lstId = new System.Windows.Forms.ListBox();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstBalance);
            this.groupBox1.Controls.Add(this.lstId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Onaylanacak\r\n Bakiye";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı\r\nId";
            // 
            // lstBalance
            // 
            this.lstBalance.FormattingEnabled = true;
            this.lstBalance.ItemHeight = 15;
            this.lstBalance.Location = new System.Drawing.Point(56, 48);
            this.lstBalance.Name = "lstBalance";
            this.lstBalance.Size = new System.Drawing.Size(66, 259);
            this.lstBalance.TabIndex = 1;
            // 
            // lstId
            // 
            this.lstId.FormattingEnabled = true;
            this.lstId.ItemHeight = 15;
            this.lstId.Location = new System.Drawing.Point(6, 48);
            this.lstId.Name = "lstId";
            this.lstId.Size = new System.Drawing.Size(45, 259);
            this.lstId.TabIndex = 0;
            this.lstId.SelectedIndexChanged += new System.EventHandler(this.lstId_SelectedIndexChanged);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Accept.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Accept.Location = new System.Drawing.Point(158, 23);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(103, 296);
            this.btn_Accept.TabIndex = 1;
            this.btn_Accept.Text = "Bakiye \r\nOnayla";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // ApproveBalanceForm
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 325);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ApproveBalanceForm";
            this.Text = "ApproveBalance";
            this.Load += new System.EventHandler(this.ApproveBalance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBalance;
        private System.Windows.Forms.ListBox lstId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Accept;
    }
}