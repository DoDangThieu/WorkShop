using Login;
using Quan_ly_Sinh_Vien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_Sinh_Vien
{
    public partial class TrangChu : Form
    {
        private string _accountType;
        public TrangChu(string accountType)
        {
            InitializeComponent();
            this._accountType = accountType;
        }
        quanlydiemContext qld = new quanlydiemContext();

        public void loadform(object Form)
        {
            if (this.pn_main.Controls.Count > 0)
                this.pn_main.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pn_main.Controls.Add(f);
            this.pn_main.Tag = f;
            f.Show();
        }



        private void Close_menu_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Sinhvien_Click_1(object sender, EventArgs e)
        {
            loadform(new QLSV());
            //var cbUserName = (from cb in qld.Canbos
            //                  select new
            //                  {
            //                      cb.Tendn
            //                  }).FirstOrDefault();
            //if (cbUserName != null)
            //{
            //    bt_Sinhvien.Enabled = true;
            //    bt_GV.Enabled = true;
            //}
        }

        private void bt_GV_Click(object sender, EventArgs e)
        {
            loadform(new QLGV());
            //var gvUserName = (from gv in qld.Giaoviens
            //                  select new
            //                  {
            //                      gv.Tennd
            //                  }).FirstOrDefault();
            //if (gvUserName != null)
            //{
            //    bt_GV.Enabled = true;
            //    bt_Sinhvien.Enabled = true;
            //}
        }
        private void bt_qldsv_Click(object sender, EventArgs e)
        {
            loadform(new QLDSV());
            //var cbUserName = (from cb in qld.Canbos
            //                  select new
            //                  {
            //                      cb.Tendn
            //                  }).FirstOrDefault();
            //if (cbUserName != null)
            //{
            //    btn_qldsv.Enabled = false;
            //}
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (_accountType.Equals("canbo"))
            {
                btn_qldsv.Enabled = false;
            }else if (_accountType.Equals("giaovien"))
            {
                bt_GV.Enabled = false;
                bt_Sinhvien.Enabled = false;
            }
        }
    }
}
