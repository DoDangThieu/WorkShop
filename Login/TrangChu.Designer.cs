namespace Quan_ly_Sinh_Vien
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            panel1 = new Panel();
            btn_qldsv = new Button();
            bt_GV = new Button();
            bt_Sinhvien = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button5 = new Button();
            panel3 = new Panel();
            Close_menu = new Button();
            pn_main = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(btn_qldsv);
            panel1.Controls.Add(bt_GV);
            panel1.Controls.Add(bt_Sinhvien);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 800);
            panel1.TabIndex = 0;
            // 
            // btn_qldsv
            // 
            btn_qldsv.BackColor = Color.CornflowerBlue;
            btn_qldsv.BackgroundImageLayout = ImageLayout.Zoom;
            btn_qldsv.FlatAppearance.BorderSize = 0;
            btn_qldsv.FlatStyle = FlatStyle.Flat;
            btn_qldsv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_qldsv.ForeColor = Color.White;
            btn_qldsv.Image = (Image)resources.GetObject("btn_qldsv.Image");
            btn_qldsv.ImageAlign = ContentAlignment.MiddleLeft;
            btn_qldsv.Location = new Point(0, 489);
            btn_qldsv.Name = "btn_qldsv";
            btn_qldsv.Size = new Size(253, 123);
            btn_qldsv.TabIndex = 3;
            btn_qldsv.Text = "   Quản Lý Điểm SV";
            btn_qldsv.UseVisualStyleBackColor = false;
            btn_qldsv.Click += bt_qldsv_Click;
            // 
            // bt_GV
            // 
            bt_GV.BackColor = Color.CornflowerBlue;
            bt_GV.BackgroundImageLayout = ImageLayout.Zoom;
            bt_GV.FlatAppearance.BorderSize = 0;
            bt_GV.FlatStyle = FlatStyle.Flat;
            bt_GV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_GV.ForeColor = Color.White;
            bt_GV.Image = (Image)resources.GetObject("bt_GV.Image");
            bt_GV.ImageAlign = ContentAlignment.MiddleLeft;
            bt_GV.Location = new Point(0, 358);
            bt_GV.Name = "bt_GV";
            bt_GV.Size = new Size(253, 125);
            bt_GV.TabIndex = 3;
            bt_GV.Text = "   Quản Lý Giáo Viên";
            bt_GV.UseVisualStyleBackColor = false;
            bt_GV.Click += bt_GV_Click;
            // 
            // bt_Sinhvien
            // 
            bt_Sinhvien.BackColor = Color.CornflowerBlue;
            bt_Sinhvien.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Sinhvien.FlatAppearance.BorderSize = 0;
            bt_Sinhvien.FlatStyle = FlatStyle.Flat;
            bt_Sinhvien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Sinhvien.ForeColor = Color.White;
            bt_Sinhvien.Image = (Image)resources.GetObject("bt_Sinhvien.Image");
            bt_Sinhvien.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Sinhvien.Location = new Point(0, 230);
            bt_Sinhvien.Name = "bt_Sinhvien";
            bt_Sinhvien.Size = new Size(253, 101);
            bt_Sinhvien.TabIndex = 3;
            bt_Sinhvien.Text = "   Quản Lý Sinh Viên";
            bt_Sinhvien.UseVisualStyleBackColor = false;
            bt_Sinhvien.Click += bt_Sinhvien_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(button5);
            panel2.Location = new Point(0, 733);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 67);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSkyBlue;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(256, 67);
            button5.TabIndex = 3;
            button5.Text = "     LogOut";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(Close_menu);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1401, 25);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // Close_menu
            // 
            Close_menu.Cursor = Cursors.Hand;
            Close_menu.FlatAppearance.BorderSize = 0;
            Close_menu.FlatStyle = FlatStyle.Flat;
            Close_menu.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Close_menu.ForeColor = Color.White;
            Close_menu.Location = new Point(1336, -2);
            Close_menu.Name = "Close_menu";
            Close_menu.Size = new Size(64, 27);
            Close_menu.TabIndex = 1;
            Close_menu.Text = "X";
            Close_menu.UseVisualStyleBackColor = true;
            Close_menu.Click += Close_menu_Click_1;
            // 
            // pn_main
            // 
            pn_main.Location = new Point(259, 31);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(1141, 766);
            pn_main.TabIndex = 4;
            pn_main.Paint += pn_main_Paint;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 800);
            Controls.Add(panel3);
            Controls.Add(pn_main);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChu";
            Load += TrangChu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button bt_Sinhvien;
        private Panel pn_main;
        private Button btn_qldsv;
        private Button bt_GV;
        private Button button5;
        private Button Close_menu;
    }
}