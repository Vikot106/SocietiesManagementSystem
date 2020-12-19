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
    public partial class register : Form
    {
        IDataDao dd = new DataDaoImpl();
        public register()
        {
            InitializeComponent();
        }

        private void reg_Click_1(object sender, EventArgs e) {
            User u = new User();
            u.Uname = uname.Text;
            u.Sid = sid.Text;
            u.Gender = gender.Text;
            u.Age = age.Text;
            u.Phone = phone.Text;
            u.Depart = depart.Text;
            u.Soc = soc.Text;
            u.Idenity = idenity.Text;
            u.Upass = pass.Text;
            if (dd.addUser(u)) {
                MessageBox.Show("注册成功！");
            }
            else {
                MessageBox.Show("注册失败！");
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
