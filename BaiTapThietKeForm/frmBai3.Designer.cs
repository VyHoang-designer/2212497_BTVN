namespace BaiTapThietKeForm
{
    partial class frmBai3
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
            this.lblTu = new System.Windows.Forms.Label();
            this.lblNgia = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtTV = new System.Windows.Forms.TextBox();
            this.btnThemTU = new System.Windows.Forms.Button();
            this.lblDS = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(67, 61);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(51, 16);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ mới:";
            // 
            // lblNgia
            // 
            this.lblNgia.AutoSize = true;
            this.lblNgia.Location = new System.Drawing.Point(21, 102);
            this.lblNgia.Name = "lblNgia";
            this.lblNgia.Size = new System.Drawing.Size(97, 16);
            this.lblNgia.TabIndex = 1;
            this.lblNgia.Text = "Ngĩa tiếng việt:";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(136, 61);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(133, 22);
            this.txtTu.TabIndex = 0;
            // 
            // txtTV
            // 
            this.txtTV.Location = new System.Drawing.Point(136, 102);
            this.txtTV.Name = "txtTV";
            this.txtTV.Size = new System.Drawing.Size(170, 22);
            this.txtTV.TabIndex = 1;
            // 
            // btnThemTU
            // 
            this.btnThemTU.Location = new System.Drawing.Point(145, 143);
            this.btnThemTU.Name = "btnThemTU";
            this.btnThemTU.Size = new System.Drawing.Size(113, 36);
            this.btnThemTU.TabIndex = 2;
            this.btnThemTU.Text = "Thêm từ mới";
            this.btnThemTU.UseVisualStyleBackColor = true;
            this.btnThemTU.Click += new System.EventHandler(this.btnThemTU_Click);
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDS.Location = new System.Drawing.Point(128, 194);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(141, 20);
            this.lblDS.TabIndex = 5;
            this.lblDS.Text = "Danh sách từ mới";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(84, 233);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 164);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nghĩa của từ";
            // 
            // txtNghia
            // 
            this.txtNghia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNghia.Location = new System.Drawing.Point(428, 233);
            this.txtNghia.Multiline = true;
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.ReadOnly = true;
            this.txtNghia.Size = new System.Drawing.Size(236, 180);
            this.txtNghia.TabIndex = 8;
            this.txtNghia.TextChanged += new System.EventHandler(this.txtNghia_TextChanged);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDS);
            this.Controls.Add(this.btnThemTU);
            this.Controls.Add(this.txtTV);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.lblNgia);
            this.Controls.Add(this.lblTu);
            this.Name = "frmBai3";
            this.Text = "Từ điển Anh-Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblNgia;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtTV;
        private System.Windows.Forms.Button btnThemTU;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNghia;
    }
}