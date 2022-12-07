using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManHinhChinh
{
    public partial class QuanLyPhongTro : Form
    {
        public QuanLyPhongTro()
        {
            InitializeComponent();
        }

        private void dskt_Click(object sender, EventArgs e)
        {
            if (!CheckExits("DanhSachKT"))
            {
                DanhSachKT fr = new DanhSachKT();
                fr.MdiParent = this;
                fr.Name = "DanhSachKT";
                fr.Show();
            }
            else
                ActiveForm("DanhSachKT");
        }
        private bool CheckExits(string name)
        {
            bool check = false;
            foreach(Form fr in this.MdiChildren)
            {
                if(fr.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveForm(string name)
        {
            foreach(Form fr in this.MdiChildren)
            {
                if(fr.Name == name)
                {
                    fr.Activate();
                    break;
                }
            }
        }

        private void DanhSachPhong_Click(object sender, EventArgs e)
        {
            if (!CheckExits("DanhSachPhong"))
            {
                DanhSachPhong fr = new DanhSachPhong();
                fr.MdiParent = this;
                fr.Name = "DanhSachPhong";
                fr.Show();
            }
            else
                ActiveForm("DanhSachPhong");
        }

        private void HoaDon_Click(object sender, EventArgs e)
        {
            if (!CheckExits("HoaDonPhong"))
            {
                HoaDonPhong fr = new HoaDonPhong();
                fr.MdiParent = this;
                fr.Name = "HoaDonPhong";
                fr.Show();
            }
            else
                ActiveForm("HoaDonPhong");
        }

        private void HopDong_Click(object sender, EventArgs e)
        {
            if (!CheckExits("HopDongKT"))
            {
                HopDongKT fr = new HopDongKT();
                fr.MdiParent = this;
                fr.Name = "HopDongKT";
                fr.Show();
            }
            else
                ActiveForm("HopDongKT");
        }

        private void TraPhong_Click(object sender, EventArgs e)
        {
            if (!CheckExits("TraPhongKT"))
            {
                TraPhongKT fr = new TraPhongKT();
                fr.MdiParent = this;
                fr.Name = "TraPhongKT";
                fr.Show();
            }
            else
                ActiveForm("TraPhongKT");
        }

        private void DanhSachThietBi_Click(object sender, EventArgs e)
        {
            if (!CheckExits("DanhSachTB"))
            {
                DanhSachTB fr = new DanhSachTB();
                fr.MdiParent = this;
                fr.Name = "DanhSachTB";
                fr.Show();
            }
            else
                ActiveForm("DanhSachTB");
        }
    }
}
