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
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
        }
        private void btnRegister1_Click(object sender, EventArgs e)
        {
            Page_Login_Register.SetPage(1);
        }
        private void btnRegister2_Click(object sender, EventArgs e)
        {
            if(check_input(txtUsername_Register)|| check_input(txtPassword_Register)|| check_input(txtCPassword_Register))
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "lỗi");
            }
            else
            {
                using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
                {
                    foreach (var k in db.USERACCOUNTs)
                    {
                        if (txtUsername_Register.Text == k.USERNAME)
                        {
                            MessageBox.Show("User name đã tồn tại!");
                            txtUsername_Register.Text = "";
                            return;
                        }
                    }
                    if (txtPassword_Register.Text == txtCPassword_Register.Text)
                    {
                        USERACCOUNT temp = new USERACCOUNT();
                        temp.USERNAME = txtUsername_Register.Text;
                        temp.USERPASSWORD = txtPassword_Register.Text;
                        db.USERACCOUNTs.InsertOnSubmit(temp);
                        db.SubmitChanges();
                        MessageBox.Show("Register thành công");
                        txtPassword_Register.Text = txtCPassword_Register.Text = txtUsername_Register.Text = "";
                        Page_Login_Register.SetPage(0);
                    }
                    else
                    {
                        MessageBox.Show("Comfirm Password không trùng khớp", "lỗi");
                    }
                }
            }
        }
        private bool check_input(BunifuTextBox txtx)
        {
            if(txtx.Text == "")
            {
                return true;
            }
            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (check_input(txtUsername_login))
            {
                MessageBox.Show("Chưa nhập user name", "lỗi");
            }
            else if (check_input(txtPassword_login))
            {
                MessageBox.Show("Chưa nhập password!", "lỗi");
            }
            else
            {
                using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
                {
                    foreach (var k in db.USERACCOUNTs)
                    {
                        if (txtUsername_login.Text == k.USERNAME && txtPassword_login.Text == k.USERPASSWORD)
                        {
                            txtUsername_login.Text = txtPassword_login.Text = "";
                            Form_enforcement form = new Form_enforcement(k.IDUSER);
                            form.Show();
                            this.Hide();
                        }
                    }
                }
            }  
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form_enforcement form = new Form_enforcement(1);
            form.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
