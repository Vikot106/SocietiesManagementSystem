using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataMan;
using DBMan;

namespace ManagementApp
{
    public partial class userMod : Form
    {
        IDataDao dd = new DataDaoImpl();
        public userMod()
        {
            InitializeComponent();
        }

        private void reg_Click_1(object sender, EventArgs e) {
            User u = new User();
            u.Uname = uname.Text;
            u.Sid = sid.Text;
            u.Age = age.Text;
            u.Phone = phone.Text;
            u.Depart = depart.Text;
            if (dd.modUserA(u,sid.Text)) {
                MessageBox.Show("修改成功！");
            }
            else {
                MessageBox.Show("修改失败！");
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
