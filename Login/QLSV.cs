using Quan_ly_Sinh_Vien;
using Quan_ly_Sinh_Vien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }
        quanlydiemContext qld = new quanlydiemContext();
        private void bt_Them_Click(object sender, EventArgs e)
        {
            Sinhvien sv = qld.Sinhviens.Where(sv => sv.Masv.Equals(txt_MSSV)).SingleOrDefault();
            //Dl TextBox
            if (sv != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string gt = "";
                if (rdbNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nữ";
                string str_Hoten = txt_Hoten.Text;
                string str_MSSV = txt_MSSV.Text;
                string str_SDT = txt_SDT.Text;
                string str_Email = txt_Email.Text;
                string str_NgaySinh = txt_NgaySinh.Text;
                //Khoi tAO
                Sinhvien SinhVien = new Sinhvien()
                {
                    Masv = txt_MSSV.Text,
                    Tensv = txt_Hoten.Text,
                    Gioitinh = gt,
                    Ngaysinh = DateTime.ParseExact(dtpngaysinh.Text.Trim(), "dd-MM-yyyy", null),
                    Diachi = txt_DiaChi.Text,
                    Sdt = txt_SDT.Text,
                    Email = txt_Email.Text,

                };
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
