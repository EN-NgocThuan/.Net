using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo4
{
    public partial class Form_editSlVL : Form
    {
        BunifuLabel bLb { get; set; }
        public Form_editSlVL(BunifuLabel blb)
        {
            InitializeComponent();
            bLb = blb;
        }
        private void Load_data()
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.KHOs.Where(r => r.TENKHO == bLb.Text).Select(r => r.IDKHO).FirstOrDefault();
                var temp1 = db.QLKHOs.Where(r => r.IDKHO == temp).Select(r => r.MAVALIEU);
                cBLoai.DataSource = temp1;
            }
        }
        private void Form_editSlVL_Load(object sender, EventArgs e)
        {
            Load_data();
        }
        private void addHoaDon()
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                HOADON temp = new HOADON();
                temp.IDHOADON = bLb_MaHD.Text;
                temp.LOAIHOADON = true;
                temp.NGAYTAO = DateTime.Now;
                temp.TONGTIEN = 0;
                db.HOADONs.InsertOnSubmit(temp);
                db.SubmitChanges();
            }
        }
        private void addCTHoaDon()
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var IDKho = db.KHOs.Where(r => r.TENKHO == bLb.Text).Select(r => r.IDKHO).FirstOrDefault();
                CTHOADON temp = new CTHOADON();
                temp.IDHOADON = bLb_MaHD.Text;
                temp.IDKHO = IDKho;
                temp.MAVALIEU = bLb_MaVLHD.Text;
                temp.TENVATLIEU = bLb_TenVLHD.Text;
                temp.SOLUONG = int.Parse(txt_AddSLVL.Text);
                temp.THANHTIEN = temp.SOLUONG * (db.CTVATLIEUs.Where(r => r.MAVATLIEU == temp.MAVALIEU).Select(r => r.GIA).FirstOrDefault());
                db.CTHOADONs.InsertOnSubmit(temp);
                db.SubmitChanges();
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            addHoaDon();
            addCTHoaDon();
            this.Close();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var IDKho = db.KHOs.Where(r => r.TENKHO == bLb.Text).Select(r => r.IDKHO).FirstOrDefault();
                QLKHO temp1 = db.QLKHOs.Where(r => r.MAVALIEU == cBLoai.Text && r.IDKHO == IDKho).Select(r => r).FirstOrDefault();
                bLb_TenVL.Text = temp1.TENVATLIEU;
                bLb_DonVi.Text = temp1.DONVI;
                bLb_SoLuong.Text = temp1.SOLUONG.ToString();
                Random rd = new Random();
                int num = rd.Next(100, 999);
                bLb_MaHD.Text = "HD" + num.ToString();
                bLb_LoaiHD.Text = "Nhập hàng";
                bLb_MaVLHD.Text =cBLoai.Text;
                bLb_TenVLHD.Text = temp1.TENVATLIEU;
            }
        }

        private void cBox_VLCanNhap_CheckedChanged(object sender, EventArgs e)
        {
            if(cBox_VLCanNhap.Checked)
            {
                using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
                {
                    var temp = db.KHOs.Where(r => r.TENKHO == bLb.Text).Select(r => r.IDKHO).FirstOrDefault(); 
                    var temp1 = db.QLKHOs.Where(r => r.IDKHO == temp && r.SOLUONG <= 50).Select(r => r.MAVALIEU);
                    cBLoai.DataSource = temp1;
                }
            }    
            else
            {
                Load_data();
            }    
        }

    }
}
