using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using DBMan;

namespace ManagementApp
{
    public partial class userForm : Form {
        private Boolean flag;
        private String xh;
        private DataSet ds = null;
        private OdbcDataAdapter da = null;
        IDataDao dd = new DataDaoImpl();
        
        public userForm(Boolean flag,String xh) {
            this.flag = flag;
            this.xh = xh;
            InitializeComponent();
        }
        
        private void userForm_Load(object sender, EventArgs e) {
            string zw = "";
            if (!flag) {
                删除成员ToolStripMenuItem.Enabled = false;
                修改成员ToolStripMenuItem.Enabled = false;
                发布通知ToolStripMenuItem.Enabled = false;
                发起活动ToolStripMenuItem.Enabled = false;
                zw = "社团成员";
            }
            else {
                zw = "社团负责人";
            }
            statu.Text = dd.getName(xh) + " " + dd.getSoc(xh) + " " + zw;
            ds = new DataSet();
            da = dd.listUser(xh,flag);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                resultGrid.DataSource = ds.Tables[0].DefaultView;
            else
                MessageBox.Show("查询结果为空！");
        }

        private void 成员列表ToolStripMenuItem_Click(object sender, EventArgs e) {
            ds = new DataSet();
            da = dd.listUser(xh,flag);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                resultGrid.DataSource = ds.Tables[0].DefaultView;
            else
                MessageBox.Show("查询结果为空！");
        }

        private void 通知列表ToolStripMenuItem_Click(object sender, EventArgs e) {
            ds = new DataSet();
            da = dd.listNotice(xh);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                resultGrid.DataSource = ds.Tables[0].DefaultView;
            else
                MessageBox.Show("查询结果为空！");
        }

        private void 活动记录ToolStripMenuItem_Click(object sender, EventArgs e) {
            ds = new DataSet();
            da = dd.listActivity(xh);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                resultGrid.DataSource = ds.Tables[0].DefaultView;
            else
                MessageBox.Show("查询结果为空！");
        }

        private void 社团信息ToolStripMenuItem_Click(object sender, EventArgs e) {
            ds = new DataSet();
            da = dd.listSoc(xh);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                resultGrid.DataSource = ds.Tables[0].DefaultView;
            else
                MessageBox.Show("查询结果为空！");
        }

        private void 删除成员ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 修改成员ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 发布通知ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 发起活动ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 修改个人信息ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 关于社团管理系统ToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://blog.moku.ink");
        }

        private void 关于社团管理系统ToolStripMenuItem1_Click(object sender, EventArgs e) {
            MessageBox.Show("社团信息管理系统 Build:20201219");
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }
    }
}