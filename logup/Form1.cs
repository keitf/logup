using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin")
            {
                if (txtpassword.Text=="admin")
                {
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("密码错误！", "警告！",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("账号错误！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
