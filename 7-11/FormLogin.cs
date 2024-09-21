using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_11
{
    public partial class FormLogin : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=344_14;Initial Catalog=7-11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
                            
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from users where user_name = '" + t_username.Text + "' AND user_password = '" + t_password.Text + "'", conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FormMain fromMain = new FormMain();
                fromMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void t_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_username_Enter(object sender, EventArgs e)
        {
            t_username.Text = string.Empty;

        }

        private void p_password_Enter(object sender, EventArgs e)
        {
            t_password.Text = string.Empty;
        }

        private void t_username_Enter(object sender, EventArgs e)
        {
           //t_username.Text=String.Empty;
        }
    }
}
