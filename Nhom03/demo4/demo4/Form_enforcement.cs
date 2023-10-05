using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace demo4
{
    public partial class Form_enforcement : Form
    {
        private int IDUser { get; set; }
        public Form_enforcement(int iDUser)
        {
            InitializeComponent();
            IDUser = iDUser;
        }

        private void Load_Imfor_User()
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.IMFOR_USERACCOUNTs.Where(r => r.IDUSER == IDUser).Select(r => r).FirstOrDefault();
                bLB_show_ManguoiQL.Text = temp.MANGUOIQL;
                bLb_show_TennguoiQL.Text = temp.TENNGUOIQL;
                bLb_show_Gender.Text = temp.GENDER;
                bLb_show_NgaySinh.Text = temp.NAMSINH.ToString();
                bLb_show_SDT.Text = temp.SDT;
                bLb_show_Email.Text = temp.EMAIL;
            }
        }
        private void Fisrt_input_User()
        {
            IMFOR_USERACCOUNT imfo = new IMFOR_USERACCOUNT();
            Random rd = new Random();
            int temp = rd.Next(100, 999);
            imfo.IDUSER = IDUser;
            imfo.MANGUOIQL = "UA" + temp.ToString();
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                foreach (var k in db.IMFOR_USERACCOUNTs)
                {
                    if (k.IDUSER == IDUser)
                    {
                        return;
                    }
                }
                db.IMFOR_USERACCOUNTs.InsertOnSubmit(imfo);
                db.SubmitChanges();
            }
        }
        private void Form_enforcement_Load(object sender, EventArgs e)
        {
            Page_Main.SetPage(0);
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp1 = db.USERACCOUNTs.Where(r => r.IDUSER == IDUser).Select(r => r.USERNAME).FirstOrDefault();
                bLB_Name1.Text = temp1;
            }
            Fisrt_input_User();
            Load_Imfor_User();
        }

        private void Btn_Imfor_User_Click(object sender, EventArgs e)
        {
            Page_Main.SetPage(0);
            Load_Imfor_User();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form_Start form = new Form_Start();
            form.Show();
            this.Hide();
        }

        private void Btn_edit_Imfor_User_Click(object sender, EventArgs e)
        {
            Page_Main.SetPage(1);
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp1 = db.IMFOR_USERACCOUNTs.Where(r => r.IDUSER == IDUser).Select(r => r.MANGUOIQL).FirstOrDefault();
                bLb_ManguoiQL.Text = temp1;
            }
        }

        private void btn_edit_IFUS_Click(object sender, EventArgs e)
        {
            using(QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var imfo = db.IMFOR_USERACCOUNTs.Where(r=>r.IDUSER==IDUser).Select(r => r).FirstOrDefault();
                imfo.TENNGUOIQL = txtinput_TennguoiQL.Text;
                if (Rbtn_GenderM.Checked) imfo.GENDER = "Nam";
                else imfo.GENDER = "Nữ";
                imfo.NAMSINH = bDP_inputNgaySinh.Value;
                imfo.SDT = txtinput_SDT.Text;
                imfo.EMAIL = txtinput_Email.Text;
                db.SubmitChanges();
                txtinput_TennguoiQL.Text  = txtinput_SDT.Text = txtinput_Email.Text = "";
            }
            Page_Main.SetPage(0);
            Load_Imfor_User();
        }
        private void Load_Kho() 
        {
            List<KHO> kho = new List<KHO>();
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                kho = db.KHOs.Select(r => r).ToList();
            }
            bLb_TenKho1.Text= kho[0].TENKHO ;
            bLb_DiaChiKho1.Text= kho[0].DIACHI;
            bLb_TenKho2.Text = kho[1].TENKHO;
            bLb_DiaChiKho2.Text = kho[1].DIACHI;
        }
        private void Btn_Kho_Click(object sender, EventArgs e)
        {
            Page_Main.SetPage(2);
            Load_Kho();
        }
        private void Load_VatLieu()
        {
            List<VATLIEU> lstVL = new List<VATLIEU>();
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                lstVL = db.VATLIEUs.Select(r => r).ToList();
            }
            bLb_VL1.Text = lstVL[0].TENVATLIEU;
            bLb_VL2.Text = lstVL[1].TENVATLIEU;
            bLb_VL3.Text = lstVL[2].TENVATLIEU;
            bLb_VL4.Text = lstVL[3].TENVATLIEU;
            bLb_VL5.Text = lstVL[4].TENVATLIEU;
            bLb_VL6.Text = lstVL[5].TENVATLIEU;   
        }
        private void Load_LVatLieu(BunifuLabel bLb)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var lstVL = db.VATLIEUs.Where(r=>r.TENVATLIEU==bLb.Text).Select(r => r).FirstOrDefault();
                bLb_TenLoai.Text = lstVL.TENVATLIEU;
                bLb_MaLoai.Text = lstVL.IDVATLIEU;
            }
        }
        private void btn_VatLieu_Click(object sender, EventArgs e)
        {
            Load_VatLieu();
            Page_Main.SetPage(3);
        }
        private void Load_LstVatLieu(BunifuLabel bLb)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var LstCTVatLieu = from m in db.CTVATLIEUs
                                   join r in db.VATLIEUs on m.IDVATLIEU equals r.IDVATLIEU
                                   where m.IDVATLIEU == bLb.Text
                                   select new {m.MAVATLIEU,m.TENVATLIEU,m.DONVI,m.GIA};
                DGV_DSVatLieu.DataSource = LstCTVatLieu;
            }
        }
        private void btn_showVL1_Click(object sender, EventArgs e)
        {
            Load_LVatLieu(bLb_VL1);
            Load_LstVatLieu(bLb_MaLoai);
            Page_Main.SetPage(4);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Load_LVatLieu(bLb_VL2);
            Load_LstVatLieu(bLb_MaLoai);
            Page_Main.SetPage(4);
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Load_LVatLieu(bLb_VL3);
            Load_LstVatLieu(bLb_MaLoai);
            Page_Main.SetPage(4);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Load_LVatLieu(bLb_VL4);
            Load_LstVatLieu(bLb_MaLoai);
            Page_Main.SetPage(4);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Load_LVatLieu(bLb_VL5);
            Load_LstVatLieu(bLb_MaLoai);
            Page_Main.SetPage(4);
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Load_LVatLieu(bLb_VL6);
            Load_LstVatLieu(bLb_MaLoai);
            Page_Main.SetPage(4);
        }

        private void bunifuPictureBox7_Click(object sender, EventArgs e)
        {
            Page_Main.SetPage(3);
        }

        private void btn_AddVatLieu_Click(object sender, EventArgs e)
        {
            Form_addItems form = new Form_addItems();
            form.ShowDialog();
        }

        private void bunifuPictureBox10_Click(object sender, EventArgs e)
        {
            Load_LstVatLieu(bLb_MaLoai);
        }

        private void btn_EditVatLieu_Click(object sender, EventArgs e)
        {
            Form_editItems form =  new Form_editItems(bLb_MaLoai);
            form.ShowDialog();
        }

        private void btn_DelVatLieu_Click(object sender, EventArgs e)
        {
            Form_delItems form = new Form_delItems(bLb_MaLoai);
            form.ShowDialog();
        }
        private void load_kho(BunifuLabel bLb)
        {
            bLb_TenKho.Text = bLb.Text;
            using(QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.KHOs.Where(r => r.TENKHO == bLb.Text).Select(r => r.IDKHO).FirstOrDefault();
                var temp1 = db.QLKHOs.Where(r => r.IDKHO == temp).Select(r => r);
                DGV_LstVatLieu.DataSource = temp1;
            }
        }
        private void btn_showkho1_Click(object sender, EventArgs e)
        {
            load_kho(bLb_TenKho1);
            Page_Main.SetPage(5);
        }

        private void btn_showkho2_Click(object sender, EventArgs e)
        {
            load_kho(bLb_TenKho2);
            Page_Main.SetPage(5);
        }

        private void bunifuPictureBox11_Click(object sender, EventArgs e)
        {
            Page_Main.SetPage(2);
        }

        private void bunifuPictureBox12_Click(object sender, EventArgs e)
        {
            Page_Main.SetPage(0);
        }

        private void btnThemSoLuong_Click(object sender, EventArgs e)
        {
            Form_editSlVL form = new Form_editSlVL(bLb_TenKho);
            form.ShowDialog();
        }

        private void bunifuPictureBox13_Click(object sender, EventArgs e)
        {
            load_kho(bLb_TenKho);
        }
        private void Load_BanHang()
        {
            Random rd = new Random();
            int num = rd.Next(100, 999);
            bLb_MaHD.Text = "HD" + num.ToString();
            bLb_LoaiHD.Text = "Xuất hàng";
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.KHOs.Select(r => r.IDKHO);
                cB_TenKho.DataSource = temp;
            }
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            Load_BanHang();

            Page_Main.SetPage(6);
        }
        private void LoadCell(DataGridViewCellEventArgs e)
        {
            if (DGV_lstSP.SelectedCells.Count == 0)
            {
                return;
            }
            else
            {
                DGV_lstSP.CurrentRow.Selected=true;
                bLb_MaVLHD.Text = DGV_lstSP.Rows[e.RowIndex].Cells["MAVALIEU"].Value.ToString();
                bLb_TenVLHD.Text = DGV_lstSP.Rows[e.RowIndex].Cells["TENVATLIEU"].Value.ToString();
            }    
        }
        private void Load_KhoBH()
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.QLKHOs.Where(r => r.IDKHO == cB_TenKho.Text ).Select(r => r);
                DGV_lstSP.DataSource = temp;
            }
        }
        private void cB_TenKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_KhoBH();
        }

        private void DGV_lstSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCell(e);
        }
        private void addHoaDon()
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var kt = db.HOADONs.Select(r => r.IDHOADON);
                foreach(var i in kt)
                {
                    if (i == bLb_MaHD.Text) return;
                }
                HOADON temp = new HOADON();
                temp.IDHOADON = bLb_MaHD.Text;
                temp.LOAIHOADON = false;
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
                CTHOADON temp = new CTHOADON();
                temp.IDHOADON = bLb_MaHD.Text;
                temp.IDKHO = cB_TenKho.Text;
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
            Load_KhoBH();
            txt_AddSLVL.Text = "";
        }

        private void bunifuPictureBox14_Click(object sender, EventArgs e)
        {
            Load_BanHang();
            txt_AddSLVL.Text = "";
        }
        private void Load_HoaDon(bool LoaiHD)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.HOADONs.Where(r => r.LOAIHOADON == LoaiHD).Select(r => r);
                DGV_showHD.DataSource = temp;
                DGV_showHD.Columns["LOAIHOADON"].Visible = false;
            }
        }
        private void btn_showLstHDB_Click(object sender, EventArgs e)
        {
            Load_HoaDon(true);
            Page_Main.SetPage(8);
        }

        private void btn_showLstHDN_Click(object sender, EventArgs e)
        {
            Load_HoaDon(false);
            Page_Main.SetPage(8);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Page_Main.SetPage(7);
        }

        private void bunifuPictureBox18_Click(object sender, EventArgs e)
        {
            bLbMahd.Text = "...";
            bLbLoaihd.Text = "...";
            Page_Main.SetPage(7);
        }
        private void LoadCellHD(DataGridViewCellEventArgs e)
        {
            if (DGV_showHD.SelectedCells.Count == 0)
            {
                return;
            }
            else
            {
                if(e.RowIndex > DGV_showHD.SelectedCells.Count+1)
                {
                    return;
                }
                DGV_showHD.CurrentRow.Selected = true;
                bLbMahd.Text = DGV_showHD.Rows[e.RowIndex].Cells["IDHOADON"].Value.ToString();
                if (DGV_showHD.Rows[e.RowIndex].Cells["LOAIHOADON"].Value.ToString() == "True")
                    bLbLoaihd.Text = "Nhập Hàng";
                else
                    bLbLoaihd.Text = "Xuất Hàng";
            }
        }
        private void DGV_showHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCellHD(e);
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_AddSLVL_TextChange(object sender, EventArgs e)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                if (txt_AddSLVL.Text == "")
                {
                    btnSubmit.Enabled = false;
                }
                else
                {
                    var sltk = db.QLKHOs.Where(r => r.IDKHO == cB_TenKho.Text && r.MAVALIEU == bLb_MaVLHD.Text).Select(r => r.SOLUONG).FirstOrDefault();
                    int slcb = int.Parse(txt_AddSLVL.Text);
                    if (slcb <= sltk)
                    {
                        btnSubmit.Enabled = true;
                    }
                    else
                    {
                        btnSubmit.Enabled = false;
                    }
                }
            }    

        }
    }
}
