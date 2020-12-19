using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBMan;

namespace ManagementApp {
    public partial class userNotice : Form {
        IDataDao dd = new DataDaoImpl();
        private string xh;
        public userNotice(string xh) {
            this.xh = xh;
            InitializeComponent();
        }

        private void reg_Click(object sender, EventArgs e) {
            if (dd.postNotice(xh, textBox1.Text)) {
                MessageBox.Show("发布成功！");
            }
            else {
                MessageBox.Show("发布失败");
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
