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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Body.Controls.Add(childForm);
            pnl_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void AddControls(Form frm)
        {
            pnl_Body.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            pnl_Body.Controls.Add(frm);
            frm.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WareHouse());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product());
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Receipt());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statistic());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Employees());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Payment());
        }
    }
}
