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
    public partial class Form_editItems : Form
    {
        BunifuLabel values { get; set; }
        public Form_editItems(BunifuLabel value)
        {
            InitializeComponent();
            values = value;
        }
        private void Load_MaVL()
        {

            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.CTVATLIEUs.Where(r => r.IDVATLIEU == values.Text).Select(r => r.MAVATLIEU);
                cBLoai.DataSource = temp;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.CTVATLIEUs.Where(r =>r.MAVATLIEU == cBLoai.Text).Select(r => r).FirstOrDefault();
                temp.TENVATLIEU = txt_TenVL.Text;
                temp.GIA = int.Parse(txt_Gia.Text);
                temp.DONVI = txtDonVi.Text;
                db.SubmitChanges();
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo");
            }
            this.Close();   
        }

        private void Form_editItems_Load(object sender, EventArgs e)
        {
            Load_MaVL();
        }

        private void cBLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                CTVATLIEU temp1 = db.CTVATLIEUs.Where(r => r.MAVATLIEU == cBLoai.Text).Select(r => r).FirstOrDefault();
                txt_TenVL.Text = temp1.TENVATLIEU;
                txt_Gia.Text = temp1.GIA.ToString();
                txtDonVi.Text = temp1.DONVI;
            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
