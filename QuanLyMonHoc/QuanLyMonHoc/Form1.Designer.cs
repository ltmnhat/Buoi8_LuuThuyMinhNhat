namespace QuanLyMonHoc
{
    partial class Form1
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
            this.lbmamh = new System.Windows.Forms.Label();
            this.lbtenmh = new System.Windows.Forms.Label();
            this.txtMaMh = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbmamh
            // 
            this.lbmamh.AutoSize = true;
            this.lbmamh.Location = new System.Drawing.Point(30, 45);
            this.lbmamh.Name = "lbmamh";
            this.lbmamh.Size = new System.Drawing.Size(42, 13);
            this.lbmamh.TabIndex = 0;
            this.lbmamh.Text = "Ma MH";
            // 
            // lbtenmh
            // 
            this.lbtenmh.AutoSize = true;
            this.lbtenmh.Location = new System.Drawing.Point(30, 75);
            this.lbtenmh.Name = "lbtenmh";
            this.lbtenmh.Size = new System.Drawing.Size(46, 13);
            this.lbtenmh.TabIndex = 1;
            this.lbtenmh.Text = "Ten MH";
            // 
            // txtMaMh
            // 
            this.txtMaMh.Location = new System.Drawing.Point(92, 45);
            this.txtMaMh.Name = "txtMaMh";
            this.txtMaMh.Size = new System.Drawing.Size(244, 20);
            this.txtMaMh.TabIndex = 2;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(92, 72);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(244, 20);
            this.txtTenMH.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(36, 148);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(147, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(252, 148);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMh);
            this.Controls.Add(this.lbtenmh);
            this.Controls.Add(this.lbmamh);
            this.Name = "Form1";
            this.Text = "Quan Ly Mon Hoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmamh;
        private System.Windows.Forms.Label lbtenmh;
        private System.Windows.Forms.TextBox txtMaMh;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}

