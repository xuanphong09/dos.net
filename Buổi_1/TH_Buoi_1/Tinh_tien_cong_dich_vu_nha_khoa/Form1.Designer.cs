namespace Tinh_tien_cong_dich_vu_nha_khoa
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_tt = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_tt = new System.Windows.Forms.TextBox();
            this.chkLayCaoRang = new System.Windows.Forms.CheckBox();
            this.numHanRang = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkTayTrangRang = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBocRang = new System.Windows.Forms.CheckBox();
            this.numBeRang = new System.Windows.Forms.NumericUpDown();
            this.numBocRang = new System.Windows.Forms.NumericUpDown();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 85);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHONG KHÁM NHA KHOA HẢI ÂU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên khách hàng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 91);
            this.panel2.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(180, 33);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(399, 34);
            this.txt_name.TabIndex = 0;
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_name_Validating);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 319);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 495);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(712, 113);
            this.panel4.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tt);
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Controls.Add(this.btn_tt);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numBocRang);
            this.groupBox3.Controls.Add(this.numBeRang);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.chkBocRang);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.chkBeRang);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.chkHanRang);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.chkTayTrangRang);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numHanRang);
            this.groupBox3.Controls.Add(this.chkLayCaoRang);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 319);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dịch vụ tại phòng khám:";
            // 
            // btn_tt
            // 
            this.btn_tt.BackColor = System.Drawing.Color.Blue;
            this.btn_tt.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tt.Location = new System.Drawing.Point(72, 43);
            this.btn_tt.Name = "btn_tt";
            this.btn_tt.Size = new System.Drawing.Size(123, 36);
            this.btn_tt.TabIndex = 0;
            this.btn_tt.Text = "Tính tiền";
            this.btn_tt.UseVisualStyleBackColor = false;
            this.btn_tt.Click += new System.EventHandler(this.btn_tt_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(536, 43);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(123, 36);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_tt
            // 
            this.txt_tt.Location = new System.Drawing.Point(251, 45);
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.ReadOnly = true;
            this.txt_tt.Size = new System.Drawing.Size(229, 34);
            this.txt_tt.TabIndex = 1;
            // 
            // chkLayCaoRang
            // 
            this.chkLayCaoRang.AutoSize = true;
            this.chkLayCaoRang.Font = new System.Drawing.Font("Arial", 13F);
            this.chkLayCaoRang.Location = new System.Drawing.Point(49, 63);
            this.chkLayCaoRang.Name = "chkLayCaoRang";
            this.chkLayCaoRang.Size = new System.Drawing.Size(159, 29);
            this.chkLayCaoRang.TabIndex = 0;
            this.chkLayCaoRang.Text = "Lấy cao răng";
            this.chkLayCaoRang.UseVisualStyleBackColor = true;
            // 
            // numHanRang
            // 
            this.numHanRang.Font = new System.Drawing.Font("Arial", 12F);
            this.numHanRang.Location = new System.Drawing.Point(536, 153);
            this.numHanRang.Name = "numHanRang";
            this.numHanRang.Size = new System.Drawing.Size(81, 30);
            this.numHanRang.TabIndex = 1;
            this.numHanRang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "50.000đ/2 hàm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "100.000đ/2 hàm";
            // 
            // chkTayTrangRang
            // 
            this.chkTayTrangRang.AutoSize = true;
            this.chkTayTrangRang.Font = new System.Drawing.Font("Arial", 13F);
            this.chkTayTrangRang.Location = new System.Drawing.Point(49, 108);
            this.chkTayTrangRang.Name = "chkTayTrangRang";
            this.chkTayTrangRang.Size = new System.Drawing.Size(173, 29);
            this.chkTayTrangRang.TabIndex = 3;
            this.chkTayTrangRang.Text = "Tẩy trắng răng";
            this.chkTayTrangRang.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "100.000đ/1 răng";
            // 
            // chkHanRang
            // 
            this.chkHanRang.AutoSize = true;
            this.chkHanRang.Font = new System.Drawing.Font("Arial", 13F);
            this.chkHanRang.Location = new System.Drawing.Point(49, 153);
            this.chkHanRang.Name = "chkHanRang";
            this.chkHanRang.Size = new System.Drawing.Size(121, 29);
            this.chkHanRang.TabIndex = 5;
            this.chkHanRang.Text = "Hàn răng";
            this.chkHanRang.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "10.000đ/1 răng";
            // 
            // chkBeRang
            // 
            this.chkBeRang.AutoSize = true;
            this.chkBeRang.Font = new System.Drawing.Font("Arial", 13F);
            this.chkBeRang.Location = new System.Drawing.Point(49, 198);
            this.chkBeRang.Name = "chkBeRang";
            this.chkBeRang.Size = new System.Drawing.Size(109, 29);
            this.chkBeRang.TabIndex = 7;
            this.chkBeRang.Text = "Bẻ răng";
            this.chkBeRang.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "1.000.000đ/1 răng";
            // 
            // chkBocRang
            // 
            this.chkBocRang.AutoSize = true;
            this.chkBocRang.Font = new System.Drawing.Font("Arial", 13F);
            this.chkBocRang.Location = new System.Drawing.Point(49, 243);
            this.chkBocRang.Name = "chkBocRang";
            this.chkBocRang.Size = new System.Drawing.Size(121, 29);
            this.chkBocRang.TabIndex = 9;
            this.chkBocRang.Text = "Bọc răng";
            this.chkBocRang.UseVisualStyleBackColor = true;
            // 
            // numBeRang
            // 
            this.numBeRang.Font = new System.Drawing.Font("Arial", 12F);
            this.numBeRang.Location = new System.Drawing.Point(536, 198);
            this.numBeRang.Name = "numBeRang";
            this.numBeRang.Size = new System.Drawing.Size(81, 30);
            this.numBeRang.TabIndex = 11;
            this.numBeRang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBocRang
            // 
            this.numBocRang.Font = new System.Drawing.Font("Arial", 12F);
            this.numBocRang.Location = new System.Drawing.Point(536, 243);
            this.numBocRang.Name = "numBocRang";
            this.numBocRang.Size = new System.Drawing.Size(81, 30);
            this.numBocRang.TabIndex = 12;
            this.numBocRang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 608);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tt;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_tt;
        private System.Windows.Forms.CheckBox chkLayCaoRang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHanRang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkBocRang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkTayTrangRang;
        private System.Windows.Forms.NumericUpDown numBocRang;
        private System.Windows.Forms.NumericUpDown numBeRang;
        private System.Windows.Forms.ErrorProvider err;
    }
}

