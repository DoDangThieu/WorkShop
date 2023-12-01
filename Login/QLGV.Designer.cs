namespace Quan_ly_Sinh_Vien
{
    partial class QLGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLGV));
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            rdbNu = new RadioButton();
            rdbnam = new RadioButton();
            txt_DiaChi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            lbGioiTinh = new Label();
            txt_Email = new TextBox();
            label4 = new Label();
            txt_SDT = new TextBox();
            label3 = new Label();
            txt_Hoten = new TextBox();
            label2 = new Label();
            txt_MSSV = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            button2 = new Button();
            pic_GV = new PictureBox();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            bt_Them = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_GV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1141, 760);
            splitContainer1.SplitterDistance = 378;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(rdbNu);
            groupBox2.Controls.Add(rdbnam);
            groupBox2.Controls.Add(txt_DiaChi);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lbGioiTinh);
            groupBox2.Controls.Add(txt_Email);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_SDT);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_Hoten);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_MSSV);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 565);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Giáo Viên";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.AppStarting;
            dateTimePicker1.CustomFormat = "dd/MM/yy";
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(98, 291);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(198, 253);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(60, 32);
            rdbNu.TabIndex = 15;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbnam
            // 
            rdbnam.AutoSize = true;
            rdbnam.Location = new Point(107, 253);
            rdbnam.Name = "rdbnam";
            rdbnam.Size = new Size(75, 32);
            rdbnam.TabIndex = 14;
            rdbnam.TabStop = true;
            rdbnam.Text = "Nam";
            rdbnam.UseVisualStyleBackColor = true;
            rdbnam.CheckedChanged += rdbnam_CheckedChanged;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(7, 359);
            txt_DiaChi.Multiline = true;
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.PlaceholderText = "Hà Nội ...";
            txt_DiaChi.Size = new Size(333, 177);
            txt_DiaChi.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(8, 333);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 9;
            label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 291);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 8;
            label6.Text = "Ngày sinh";
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbGioiTinh.Location = new Point(7, 254);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(81, 25);
            lbGioiTinh.TabIndex = 7;
            lbGioiTinh.Text = "Giới Tính";
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Email.Location = new Point(148, 212);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(192, 30);
            txt_Email.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(148, 187);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // txt_SDT
            // 
            txt_SDT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SDT.Location = new Point(6, 212);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(131, 30);
            txt_SDT.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 187);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 3;
            label3.Text = "SĐT";
            // 
            // txt_Hoten
            // 
            txt_Hoten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Hoten.Location = new Point(7, 147);
            txt_Hoten.Name = "txt_Hoten";
            txt_Hoten.Size = new Size(333, 34);
            txt_Hoten.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 110);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 2;
            label2.Text = "Họ Và Tên";
            // 
            // txt_MSSV
            // 
            txt_MSSV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MSSV.Location = new Point(8, 73);
            txt_MSSV.Name = "txt_MSSV";
            txt_MSSV.Size = new Size(332, 34);
            txt_MSSV.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 30);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã Giáo Viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(pic_GV);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 172);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ảnh Đại Diện";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(134, 61);
            label8.Name = "label8";
            label8.Size = new Size(139, 23);
            label8.TabIndex = 11;
            label8.Text = "Ảnh Đại Diện GV";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(134, 87);
            button2.Name = "button2";
            button2.Size = new Size(212, 49);
            button2.TabIndex = 1;
            button2.Text = "Chọn Ảnh";
            button2.UseVisualStyleBackColor = false;
            // 
            // pic_GV
            // 
            pic_GV.Image = (Image)resources.GetObject("pic_GV.Image");
            pic_GV.Location = new Point(6, 33);
            pic_GV.Name = "pic_GV";
            pic_GV.Size = new Size(122, 133);
            pic_GV.SizeMode = PictureBoxSizeMode.Zoom;
            pic_GV.TabIndex = 0;
            pic_GV.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(bt_Them);
            panel1.Location = new Point(-8, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 75);
            panel1.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 151, 178);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(603, 19);
            button6.Name = "button6";
            button6.Size = new Size(151, 41);
            button6.TabIndex = 15;
            button6.Text = "SAVE ";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 222, 89);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(409, 19);
            button5.Name = "button5";
            button5.Size = new Size(151, 41);
            button5.TabIndex = 14;
            button5.Text = "UPDATE";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 87, 87);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(218, 19);
            button4.Name = "button4";
            button4.Size = new Size(151, 41);
            button4.TabIndex = 13;
            button4.Text = "Xóa GV";
            button4.UseVisualStyleBackColor = false;
            // 
            // bt_Them
            // 
            bt_Them.BackColor = Color.FromArgb(0, 191, 99);
            bt_Them.FlatAppearance.BorderSize = 0;
            bt_Them.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            bt_Them.FlatStyle = FlatStyle.Flat;
            bt_Them.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Them.ForeColor = Color.White;
            bt_Them.Image = (Image)resources.GetObject("bt_Them.Image");
            bt_Them.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Them.Location = new Point(17, 19);
            bt_Them.Name = "bt_Them";
            bt_Them.Size = new Size(151, 41);
            bt_Them.TabIndex = 12;
            bt_Them.Text = "ADD GV";
            bt_Them.UseVisualStyleBackColor = false;
            // 
            // QLGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 760);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QLGV";
            Text = "QLGV";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_GV).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private RadioButton rdbNu;
        private RadioButton rdbnam;
        private TextBox txt_DiaChi;
        private Label label7;
        private Label label6;
        private Label lbGioiTinh;
        private TextBox txt_Email;
        private Label label4;
        private TextBox txt_SDT;
        private Label label3;
        private TextBox txt_Hoten;
        private Label label2;
        private TextBox txt_MSSV;
        private Label label1;
        private GroupBox groupBox1;
        private Label label8;
        private Button button2;
        private PictureBox pic_GV;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button bt_Them;
    }
}