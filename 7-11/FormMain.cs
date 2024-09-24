using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormSale formsale = new FormSale();
            formsale.MdiParent = this;
            formsale.Dock = DockStyle.Fill;
            formsale.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormUser formuser = new FormUser();
            formuser.MdiParent = this;
            formuser.Dock = DockStyle.Fill;
            formuser.Show();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormProduct formproduct = new FormProduct();
            formproduct.MdiParent = this;
            formproduct.Dock = DockStyle.Fill;
            formproduct.Show();
        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormProductType formproducttype = new FormProductType();
            formproducttype.MdiParent = this;
            formproducttype.Dock = DockStyle.Fill;
            formproducttype.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dfsfdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
