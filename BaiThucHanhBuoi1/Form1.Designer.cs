namespace BaiThucHanhBuoi1
{
    partial class v
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblBanNhap = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtBanNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(176, 76);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(148, 25);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Nhập tên của bạn";
            this.lblTen.UseCompatibleTextRendering = true;
            // 
            // lblBanNhap
            // 
            this.lblBanNhap.AutoSize = true;
            this.lblBanNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanNhap.Location = new System.Drawing.Point(196, 178);
            this.lblBanNhap.Name = "lblBanNhap";
            this.lblBanNhap.Size = new System.Drawing.Size(128, 20);
            this.lblBanNhap.TabIndex = 1;
            this.lblBanNhap.Text = "Tên Bạn Nhập";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(355, 76);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(222, 22);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // txtBanNhap
            // 
            this.txtBanNhap.Location = new System.Drawing.Point(355, 178);
            this.txtBanNhap.Name = "txtBanNhap";
            this.txtBanNhap.Size = new System.Drawing.Size(222, 22);
            this.txtBanNhap.TabIndex = 3;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(398, 124);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(82, 35);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaoChep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoChep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaoChep.Location = new System.Drawing.Point(495, 124);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(82, 35);
            this.btnSaoChep.TabIndex = 5;
            this.btnSaoChep.Text = "Sao chép";
            this.btnSaoChep.UseVisualStyleBackColor = false;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtBanNhap);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblBanNhap);
            this.Controls.Add(this.lblTen);
            this.Name = "v";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblBanNhap;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtBanNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnSaoChep;
    }
}

