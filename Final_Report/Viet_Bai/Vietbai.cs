using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan.Vietbai
{
    public partial class Vietbai : UserControl
    {
        public Vietbai()
        {
            InitializeComponent();
        }
        private string TenNguoiDung;
        private string Id;

        public string ID
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string TenNguoiDungText
        {
            get
            {
                return TenNguoiDung;
            }
            set
            {
                TenNguoiDung = value;
            }
        }
        public Image AVT
        {
            get
            {
                return Avt.Image;
            }
            set
            {
                Avt.Image = value;
            }
        }

        private void AnhVideo_Click(object sender, EventArgs e)
        {
            FormDangBaiViet formDangBaiViet = new FormDangBaiViet();
            formDangBaiViet.ten = TenNguoiDung;
            formDangBaiViet.avt = AVT;
            formDangBaiViet.ID = ID;
            formDangBaiViet.ShowDialog();
        }

        private void TrucTiep_Click(object sender, EventArgs e)
        {
            FormDangBaiViet formDangBaiViet = new FormDangBaiViet();
            formDangBaiViet.ten = TenNguoiDung;
            formDangBaiViet.avt = AVT;
            formDangBaiViet.ID = ID;
            formDangBaiViet.ShowDialog();
        }

        private void CamXuc_Click(object sender, EventArgs e)
        {
            FormDangBaiViet formDangBaiViet = new FormDangBaiViet();
            formDangBaiViet.ten = TenNguoiDung;
            formDangBaiViet.avt = AVT;
            formDangBaiViet.ID = ID;
            formDangBaiViet.ShowDialog();
        }

        private void BaiVietMoi_Click(object sender, EventArgs e)
        {
            FormDangBaiViet formDangBaiViet = new FormDangBaiViet();
            formDangBaiViet.ten = TenNguoiDung;
            formDangBaiViet.avt = AVT;
            formDangBaiViet.ID = ID;
            formDangBaiViet.ShowDialog();
        }
    }
}
