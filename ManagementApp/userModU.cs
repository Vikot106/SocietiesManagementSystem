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
    public partial class userModU : Form
    {
        IDataDao dd = new DataDaoImpl();
        private string xh;
        public userModU(string xh) {
            this.xh = xh;
            InitializeComponent();
        }

        private void reg_Click_1(object sender, EventArgs e) {
            User u = new User();
            u.Age = age.Text;
            u.Phone = phone.Text;
            u.Depart = depart.Text;
            u.Idenity = idenity.Text;
            u.Upass = pass.Text;
            if (dd.modUserU(u,xh)) {
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
