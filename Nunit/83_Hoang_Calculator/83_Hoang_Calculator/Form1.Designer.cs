namespace _83_Hoang_Calculator
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
            this.txt_1_83 = new System.Windows.Forms.TextBox();
            this.txt_2_83 = new System.Windows.Forms.TextBox();
            this.txt_kq_83 = new System.Windows.Forms.TextBox();
            this.lb_1_83 = new System.Windows.Forms.Label();
            this.lb_2_83 = new System.Windows.Forms.Label();
            this.lb_kq_83 = new System.Windows.Forms.Label();
            this.btn_Cong_83 = new System.Windows.Forms.Button();
            this.btn_Tru_83 = new System.Windows.Forms.Button();
            this.btn_Nhan_83 = new System.Windows.Forms.Button();
            this.btn_Chia_83 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_1_83
            // 
            this.txt_1_83.Location = new System.Drawing.Point(171, 32);
            this.txt_1_83.Multiline = true;
            this.txt_1_83.Name = "txt_1_83";
            this.txt_1_83.Size = new System.Drawing.Size(100, 20);
            this.txt_1_83.TabIndex = 0;
            // 
            // txt_2_83
            // 
            this.txt_2_83.Location = new System.Drawing.Point(171, 69);
            this.txt_2_83.Multiline = true;
            this.txt_2_83.Name = "txt_2_83";
            this.txt_2_83.Size = new System.Drawing.Size(100, 20);
            this.txt_2_83.TabIndex = 1;
            // 
            // txt_kq_83
            // 
            this.txt_kq_83.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_kq_83.Location = new System.Drawing.Point(171, 107);
            this.txt_kq_83.Multiline = true;
            this.txt_kq_83.Name = "txt_kq_83";
            this.txt_kq_83.ReadOnly = true;
            this.txt_kq_83.Size = new System.Drawing.Size(100, 20);
            this.txt_kq_83.TabIndex = 2;
            // 
            // lb_1_83
            // 
            this.lb_1_83.AutoSize = true;
            this.lb_1_83.Location = new System.Drawing.Point(116, 32);
            this.lb_1_83.Name = "lb_1_83";
            this.lb_1_83.Size = new System.Drawing.Size(29, 13);
            this.lb_1_83.TabIndex = 3;
            this.lb_1_83.Text = "Số 1";
            this.lb_1_83.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_2_83
            // 
            this.lb_2_83.AutoSize = true;
            this.lb_2_83.Location = new System.Drawing.Point(116, 69);
            this.lb_2_83.Name = "lb_2_83";
            this.lb_2_83.Size = new System.Drawing.Size(29, 13);
            this.lb_2_83.TabIndex = 4;
            this.lb_2_83.Text = "Số 2";
            // 
            // lb_kq_83
            // 
            this.lb_kq_83.AutoSize = true;
            this.lb_kq_83.Location = new System.Drawing.Point(116, 107);
            this.lb_kq_83.Name = "lb_kq_83";
            this.lb_kq_83.Size = new System.Drawing.Size(44, 13);
            this.lb_kq_83.TabIndex = 5;
            this.lb_kq_83.Text = "Kết quả";
            // 
            // btn_Cong_83
            // 
            this.btn_Cong_83.Location = new System.Drawing.Point(70, 162);
            this.btn_Cong_83.Name = "btn_Cong_83";
            this.btn_Cong_83.Size = new System.Drawing.Size(75, 23);
            this.btn_Cong_83.TabIndex = 6;
            this.btn_Cong_83.Text = "Cộng";
            this.btn_Cong_83.UseVisualStyleBackColor = true;
            this.btn_Cong_83.Click += new System.EventHandler(this.btn_Cong_83_Click);
            // 
            // btn_Tru_83
            // 
            this.btn_Tru_83.Location = new System.Drawing.Point(151, 162);
            this.btn_Tru_83.Name = "btn_Tru_83";
            this.btn_Tru_83.Size = new System.Drawing.Size(75, 23);
            this.btn_Tru_83.TabIndex = 7;
            this.btn_Tru_83.Text = "Trừ";
            this.btn_Tru_83.UseVisualStyleBackColor = true;
            this.btn_Tru_83.Click += new System.EventHandler(this.btn_Tru_83_Click);
            // 
            // btn_Nhan_83
            // 
            this.btn_Nhan_83.Location = new System.Drawing.Point(232, 162);
            this.btn_Nhan_83.Name = "btn_Nhan_83";
            this.btn_Nhan_83.Size = new System.Drawing.Size(75, 23);
            this.btn_Nhan_83.TabIndex = 8;
            this.btn_Nhan_83.Text = "Nhân";
            this.btn_Nhan_83.UseVisualStyleBackColor = true;
            this.btn_Nhan_83.Click += new System.EventHandler(this.btn_Nhan_83_Click);
            // 
            // btn_Chia_83
            // 
            this.btn_Chia_83.Location = new System.Drawing.Point(313, 162);
            this.btn_Chia_83.Name = "btn_Chia_83";
            this.btn_Chia_83.Size = new System.Drawing.Size(75, 23);
            this.btn_Chia_83.TabIndex = 9;
            this.btn_Chia_83.Text = "Chia";
            this.btn_Chia_83.UseVisualStyleBackColor = true;
            this.btn_Chia_83.Click += new System.EventHandler(this.btn_Chia_83_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 245);
            this.Controls.Add(this.btn_Chia_83);
            this.Controls.Add(this.btn_Nhan_83);
            this.Controls.Add(this.btn_Tru_83);
            this.Controls.Add(this.btn_Cong_83);
            this.Controls.Add(this.lb_kq_83);
            this.Controls.Add(this.lb_2_83);
            this.Controls.Add(this.lb_1_83);
            this.Controls.Add(this.txt_kq_83);
            this.Controls.Add(this.txt_2_83);
            this.Controls.Add(this.txt_1_83);
            this.Name = "Form1";
            this.Text = "83_Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1_83;
        private System.Windows.Forms.TextBox txt_2_83;
        private System.Windows.Forms.TextBox txt_kq_83;
        private System.Windows.Forms.Label lb_1_83;
        private System.Windows.Forms.Label lb_2_83;
        private System.Windows.Forms.Label lb_kq_83;
        private System.Windows.Forms.Button btn_Cong_83;
        private System.Windows.Forms.Button btn_Tru_83;
        private System.Windows.Forms.Button btn_Nhan_83;
        private System.Windows.Forms.Button btn_Chia_83;
    }
}

