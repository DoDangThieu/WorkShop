namespace Quan_ly_Sinh_Vien
{
    partial class lt_SinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lt_SinhVien));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            lb_MSSV = new Label();
            lb_Hoten = new Label();
            lb_SDT = new Label();
            lb_Email = new Label();
            lb_NgaySinh = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 35);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 2;
            label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 12);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 3;
            label2.Text = "Họ Và Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(99, 52);
            label3.Name = "label3";
            label3.Size = new Size(31, 17);
            label3.TabIndex = 4;
            label3.Text = "SĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(224, 52);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(99, 69);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 9;
            label6.Text = "Ngày sinh";
            // 
            // lb_MSSV
            // 
            lb_MSSV.AutoSize = true;
            lb_MSSV.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_MSSV.Location = new Point(189, 35);
            lb_MSSV.Name = "lb_MSSV";
            lb_MSSV.Size = new Size(59, 17);
            lb_MSSV.TabIndex = 2;
            lb_MSSV.Text = "PH45001";
            // 
            // lb_Hoten
            // 
            lb_Hoten.AutoSize = true;
            lb_Hoten.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Hoten.Location = new Point(191, 12);
            lb_Hoten.Name = "lb_Hoten";
            lb_Hoten.Size = new Size(123, 23);
            lb_Hoten.TabIndex = 3;
            lb_Hoten.Text = "Nguyễn Văn A";
            // 
            // lb_SDT
            // 
            lb_SDT.AutoSize = true;
            lb_SDT.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_SDT.Location = new Point(134, 52);
            lb_SDT.Name = "lb_SDT";
            lb_SDT.Size = new Size(78, 17);
            lb_SDT.TabIndex = 4;
            lb_SDT.Text = "0123456789";
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Email.Location = new Point(269, 52);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(150, 17);
            lb_Email.TabIndex = 6;
            lb_Email.Text = "anvph45001@gmail.com";
            // 
            // lb_NgaySinh
            // 
            lb_NgaySinh.AutoSize = true;
            lb_NgaySinh.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_NgaySinh.Location = new Point(171, 69);
            lb_NgaySinh.Name = "lb_NgaySinh";
            lb_NgaySinh.Size = new Size(74, 17);
            lb_NgaySinh.TabIndex = 9;
            lb_NgaySinh.Text = "01/01/2000";
            // 
            // lt_SinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(687, 103);
            Controls.Add(lb_NgaySinh);
            Controls.Add(label6);
            Controls.Add(lb_Email);
            Controls.Add(label4);
            Controls.Add(lb_SDT);
            Controls.Add(label3);
            Controls.Add(lb_Hoten);
            Controls.Add(label2);
            Controls.Add(lb_MSSV);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "lt_SinhVien";
            Text = "lt_SinhVien";
            Load += lt_SinhVien_Load;
            MouseEnter += lt_SinhVien_MouseEnter;
            MouseLeave += lt_SinhVien_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label lb_MSSV;
        private Label lb_Hoten;
        private Label lb_SDT;
        private Label lb_Email;
        private Label lb_NgaySinh;
    }
}