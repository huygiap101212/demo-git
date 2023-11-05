using QuanLiQuanNet.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanNet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtTaiKhoan.Text;
            string PassWord = txtMatKhau.Text;
            if (CheckLogin(UserName, PassWord))
            {
                QuanLy f = new QuanLy();
                this.Hide();
                f.Show();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản mật khẩu");
            }
        }
        bool CheckLogin(string username , string password)
        {
            return AccountDAO.Instance.CheckLogin(username, password);
        }
    }
}
