using System;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class userForm : Form {
        private Boolean flag;
        private String xm;
        
        public userForm(Boolean flag,String xm) {
            this.flag = flag;
            this.xm = xm;
            InitializeComponent();
        }

        private void userForm_Load(object sender, EventArgs e) {
            statu.Text = xm;
            if (!flag) {
                添加成员ToolStripMenuItem.Enabled = false;
                删除成员ToolStripMenuItem.Enabled = false;
                修改成员ToolStripMenuItem.Enabled = false;
                发布通知ToolStripMenuItem.Enabled = false;
                发起活动ToolStripMenuItem.Enabled = false;
            }
        }

        private void 成员列表ToolStripMenuItem_Click(object sender, EventArgs e) {
            //
        }
    }
}