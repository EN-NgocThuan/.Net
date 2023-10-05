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
    public partial class Form_addItems : Form
    {
        public Form_addItems()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Load_Loai()
        {
            using(QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.VATLIEUs.Select(r => r.TENVATLIEU);
                cBLoai.DataSource=temp;
            }
        }
        private void Form_addItems_Load(object sender, EventArgs e)
        {
            Load_Loai();
        }
        private void cBLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rd = new Random();
            int temp = rd.Next(100, 999);
            if (cBLoai.Text == "Thép xây dựng")
                bLb_MaVL.Text = "TH" + temp.ToString();
            else if (cBLoai.Text == "Cát xây dựng")
                bLb_MaVL.Text = "CA" + temp.ToString();
            else if (cBLoai.Text == "Đá xây dựng")
                bLb_MaVL.Text = "DA" + temp.ToString();
            else if (cBLoai.Text == "Gạch xây dựng")
                bLb_MaVL.Text = "GA" + temp.ToString();
            else if (cBLoai.Text == "Xi Măng")
                bLb_MaVL.Text = "XM" + temp.ToString();
            else
                bLb_MaVL.Text = "TO" + temp.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                CTVATLIEU temp = new CTVATLIEU();
                temp.MAVATLIEU = bLb_MaVL.Text;
                temp.IDVATLIEU = db.VATLIEUs.Where(r=>r.TENVATLIEU == cBLoai.Text).Select(r=>r.IDVATLIEU).FirstOrDefault();
                temp.TENVATLIEU = txt_TenVL.Text;
                temp.GIA = int.Parse(txt_Gia.Text);
                temp.DONVI = txtDonVi.Text;
                db.CTVATLIEUs.InsertOnSubmit(temp);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công","Thông báo");
                this.Close();
            }
        }
    }
}
