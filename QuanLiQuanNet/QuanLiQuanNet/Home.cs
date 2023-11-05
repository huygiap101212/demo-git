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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            string query = "EXEC dbo.USP_GetAccount @username";
            dgvInfoMayTram.DataSource = DataProvider.Instance.ExecuteQuery(query,new object[] {"Admin"});
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
