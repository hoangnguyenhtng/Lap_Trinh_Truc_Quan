using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHoa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chatLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (!CheckExistForm("Form1"))
            {
                Form1 frm = new Form1();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            } else
            {
                ActiveForm("Form1");
            }
            */
        }
        // kiểm tra sự tồn tại của form

        bool CheckExistForm(string formName)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if(frm.Name == formName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // active 1 form
        void ActiveForm(string formName)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == formName)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        bool CheckExistForm(string formName)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == formName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("form1"))
            {
                Form1 frm = new Form1();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                ActiveForm("Form1");
            }
        }
    }
}
