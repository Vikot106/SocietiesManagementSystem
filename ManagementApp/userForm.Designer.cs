using System.ComponentModel;

namespace ManagementApp
{
    partial class userForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.成员列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除成员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改成员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通知查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通知列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发布通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的社团ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.活动记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发起活动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.社团信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于社团管理系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.关于社团管理系统ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.statu = new System.Windows.Forms.Label();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.resultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem1, this.通知查询ToolStripMenuItem, this.我的社团ToolStripMenuItem, this.帮助ToolStripMenuItem, this.帮助ToolStripMenuItem1, this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.成员列表ToolStripMenuItem, this.删除成员ToolStripMenuItem, this.修改成员ToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "成员查询";
            // 
            // 成员列表ToolStripMenuItem
            // 
            this.成员列表ToolStripMenuItem.Name = "成员列表ToolStripMenuItem";
            this.成员列表ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.成员列表ToolStripMenuItem.Text = "成员列表";
            this.成员列表ToolStripMenuItem.Click += new System.EventHandler(this.成员列表ToolStripMenuItem_Click);
            // 
            // 删除成员ToolStripMenuItem
            // 
            this.删除成员ToolStripMenuItem.Name = "删除成员ToolStripMenuItem";
            this.删除成员ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.删除成员ToolStripMenuItem.Text = "删除成员";
            this.删除成员ToolStripMenuItem.Click += new System.EventHandler(this.删除成员ToolStripMenuItem_Click);
            // 
            // 修改成员ToolStripMenuItem
            // 
            this.修改成员ToolStripMenuItem.Name = "修改成员ToolStripMenuItem";
            this.修改成员ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.修改成员ToolStripMenuItem.Text = "修改成员";
            this.修改成员ToolStripMenuItem.Click += new System.EventHandler(this.修改成员ToolStripMenuItem_Click);
            // 
            // 通知查询ToolStripMenuItem
            // 
            this.通知查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.通知列表ToolStripMenuItem, this.发布通知ToolStripMenuItem});
            this.通知查询ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.通知查询ToolStripMenuItem.Name = "通知查询ToolStripMenuItem";
            this.通知查询ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.通知查询ToolStripMenuItem.Text = "通知查询";
            // 
            // 通知列表ToolStripMenuItem
            // 
            this.通知列表ToolStripMenuItem.Name = "通知列表ToolStripMenuItem";
            this.通知列表ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.通知列表ToolStripMenuItem.Text = "通知列表";
            this.通知列表ToolStripMenuItem.Click += new System.EventHandler(this.通知列表ToolStripMenuItem_Click);
            // 
            // 发布通知ToolStripMenuItem
            // 
            this.发布通知ToolStripMenuItem.Name = "发布通知ToolStripMenuItem";
            this.发布通知ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.发布通知ToolStripMenuItem.Text = "发布通知";
            this.发布通知ToolStripMenuItem.Click += new System.EventHandler(this.发布通知ToolStripMenuItem_Click);
            // 
            // 我的社团ToolStripMenuItem
            // 
            this.我的社团ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.活动记录ToolStripMenuItem, this.发起活动ToolStripMenuItem});
            this.我的社团ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.我的社团ToolStripMenuItem.Name = "我的社团ToolStripMenuItem";
            this.我的社团ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.我的社团ToolStripMenuItem.Text = "活动查询";
            // 
            // 活动记录ToolStripMenuItem
            // 
            this.活动记录ToolStripMenuItem.Name = "活动记录ToolStripMenuItem";
            this.活动记录ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.活动记录ToolStripMenuItem.Text = "活动记录";
            this.活动记录ToolStripMenuItem.Click += new System.EventHandler(this.活动记录ToolStripMenuItem_Click);
            // 
            // 发起活动ToolStripMenuItem
            // 
            this.发起活动ToolStripMenuItem.Name = "发起活动ToolStripMenuItem";
            this.发起活动ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.发起活动ToolStripMenuItem.Text = "发起活动";
            this.发起活动ToolStripMenuItem.Click += new System.EventHandler(this.发起活动ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.社团信息ToolStripMenuItem, this.修改个人信息ToolStripMenuItem});
            this.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.帮助ToolStripMenuItem.Text = "资料查询";
            // 
            // 社团信息ToolStripMenuItem
            // 
            this.社团信息ToolStripMenuItem.Name = "社团信息ToolStripMenuItem";
            this.社团信息ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.社团信息ToolStripMenuItem.Text = "社团信息";
            this.社团信息ToolStripMenuItem.Click += new System.EventHandler(this.社团信息ToolStripMenuItem_Click);
            // 
            // 修改个人信息ToolStripMenuItem
            // 
            this.修改个人信息ToolStripMenuItem.Name = "修改个人信息ToolStripMenuItem";
            this.修改个人信息ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.修改个人信息ToolStripMenuItem.Text = "修改个人信息";
            this.修改个人信息ToolStripMenuItem.Click += new System.EventHandler(this.修改个人信息ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.关于社团管理系统ToolStripMenuItem, this.toolStripSeparator1, this.关于社团管理系统ToolStripMenuItem1});
            this.帮助ToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            // 
            // 关于社团管理系统ToolStripMenuItem
            // 
            this.关于社团管理系统ToolStripMenuItem.Name = "关于社团管理系统ToolStripMenuItem";
            this.关于社团管理系统ToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.关于社团管理系统ToolStripMenuItem.Text = "查看帮助";
            this.关于社团管理系统ToolStripMenuItem.Click += new System.EventHandler(this.关于社团管理系统ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // 关于社团管理系统ToolStripMenuItem1
            // 
            this.关于社团管理系统ToolStripMenuItem1.Name = "关于社团管理系统ToolStripMenuItem1";
            this.关于社团管理系统ToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.关于社团管理系统ToolStripMenuItem1.Text = "关于 社团管理系统";
            this.关于社团管理系统ToolStripMenuItem1.Click += new System.EventHandler(this.关于社团管理系统ToolStripMenuItem1_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.label7.Location = new System.Drawing.Point(401, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(395, 42);
            this.label7.TabIndex = 23;
            this.label7.Text = "Societies Management";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.title.Location = new System.Drawing.Point(556, 349);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(240, 64);
            this.title.TabIndex = 22;
            this.title.Text = "社团管理";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // statu
            // 
            this.statu.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.statu.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.statu.Location = new System.Drawing.Point(22, 413);
            this.statu.Name = "statu";
            this.statu.Size = new System.Drawing.Size(774, 64);
            this.statu.TabIndex = 24;
            this.statu.Text = " ";
            this.statu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (35)))), ((int) (((byte) (35)))), ((int) (((byte) (35)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.resultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
            this.resultGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (35)))), ((int) (((byte) (35)))), ((int) (((byte) (35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))), ((int) (((byte) (30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (20)))), ((int) (((byte) (20)))), ((int) (((byte) (20)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.resultGrid.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (244)))));
            this.resultGrid.Location = new System.Drawing.Point(32, 38);
            this.resultGrid.Name = "resultGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (35)))), ((int) (((byte) (35)))), ((int) (((byte) (35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (35)))), ((int) (((byte) (35)))), ((int) (((byte) (35)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.resultGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.resultGrid.RowTemplate.Height = 23;
            this.resultGrid.Size = new System.Drawing.Size(741, 297);
            this.resultGrid.TabIndex = 26;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (40)))), ((int) (((byte) (40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.statu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "userForm";
            this.Text = "社团管理系统";
            this.Load += new System.EventHandler(this.userForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.resultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;

        private System.Windows.Forms.DataGridView resultGrid;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ToolStripMenuItem 成员列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除成员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改成员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通知查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通知列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发布通知ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的社团ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 活动记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发起活动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 社团信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于社团管理系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 关于社团管理系统ToolStripMenuItem1;
        private System.Windows.Forms.Label statu;
    }
}