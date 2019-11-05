namespace MyApp
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menu_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tool_ChangeImg = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_selectFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_system = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_ChangeOpa = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_opa_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_opa_20 = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_opa_30 = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_opa_40 = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_opa_50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_opa_custom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.noti_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.tim_setBackground = new System.Windows.Forms.Timer(this.components);
            this.menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Main
            // 
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_ChangeImg,
            this.tool_ChangeOpa,
            this.toolStripSeparator1,
            this.tool_Exit});
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.Size = new System.Drawing.Size(125, 76);
            // 
            // tool_ChangeImg
            // 
            this.tool_ChangeImg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_selectFile,
            this.tool_system});
            this.tool_ChangeImg.Name = "tool_ChangeImg";
            this.tool_ChangeImg.Size = new System.Drawing.Size(124, 22);
            this.tool_ChangeImg.Text = "更改图片";
            // 
            // tool_selectFile
            // 
            this.tool_selectFile.Name = "tool_selectFile";
            this.tool_selectFile.Size = new System.Drawing.Size(124, 22);
            this.tool_selectFile.Text = "选择文件";
            this.tool_selectFile.Click += new System.EventHandler(this.tool_ChangeImg_Click);
            // 
            // tool_system
            // 
            this.tool_system.Name = "tool_system";
            this.tool_system.Size = new System.Drawing.Size(124, 22);
            this.tool_system.Text = "跟随系统";
            this.tool_system.Click += new System.EventHandler(this.tool_system_Click);
            // 
            // tool_ChangeOpa
            // 
            this.tool_ChangeOpa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_opa_10,
            this.tool_opa_20,
            this.tool_opa_30,
            this.tool_opa_40,
            this.tool_opa_50,
            this.toolStripSeparator2,
            this.tool_opa_custom});
            this.tool_ChangeOpa.Name = "tool_ChangeOpa";
            this.tool_ChangeOpa.Size = new System.Drawing.Size(124, 22);
            this.tool_ChangeOpa.Text = "透明度";
            // 
            // tool_opa_10
            // 
            this.tool_opa_10.Name = "tool_opa_10";
            this.tool_opa_10.Size = new System.Drawing.Size(112, 22);
            this.tool_opa_10.Tag = "0.1";
            this.tool_opa_10.Text = "10%";
            this.tool_opa_10.Click += new System.EventHandler(this.tool_ChangeOpa_Click);
            // 
            // tool_opa_20
            // 
            this.tool_opa_20.Name = "tool_opa_20";
            this.tool_opa_20.Size = new System.Drawing.Size(112, 22);
            this.tool_opa_20.Tag = "0.2";
            this.tool_opa_20.Text = "20%";
            this.tool_opa_20.Click += new System.EventHandler(this.tool_ChangeOpa_Click);
            // 
            // tool_opa_30
            // 
            this.tool_opa_30.Name = "tool_opa_30";
            this.tool_opa_30.Size = new System.Drawing.Size(112, 22);
            this.tool_opa_30.Tag = "0.3";
            this.tool_opa_30.Text = "30%";
            this.tool_opa_30.Click += new System.EventHandler(this.tool_ChangeOpa_Click);
            // 
            // tool_opa_40
            // 
            this.tool_opa_40.Name = "tool_opa_40";
            this.tool_opa_40.Size = new System.Drawing.Size(112, 22);
            this.tool_opa_40.Tag = "0.4";
            this.tool_opa_40.Text = "40%";
            this.tool_opa_40.Click += new System.EventHandler(this.tool_ChangeOpa_Click);
            // 
            // tool_opa_50
            // 
            this.tool_opa_50.Name = "tool_opa_50";
            this.tool_opa_50.Size = new System.Drawing.Size(112, 22);
            this.tool_opa_50.Tag = "0.5";
            this.tool_opa_50.Text = "50%";
            this.tool_opa_50.Click += new System.EventHandler(this.tool_ChangeOpa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(109, 6);
            // 
            // tool_opa_custom
            // 
            this.tool_opa_custom.Name = "tool_opa_custom";
            this.tool_opa_custom.Size = new System.Drawing.Size(112, 22);
            this.tool_opa_custom.Text = "自定义";
            this.tool_opa_custom.Click += new System.EventHandler(this.tool_opa_custom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // tool_Exit
            // 
            this.tool_Exit.Name = "tool_Exit";
            this.tool_Exit.Size = new System.Drawing.Size(124, 22);
            this.tool_Exit.Text = "退出";
            this.tool_Exit.Click += new System.EventHandler(this.tool_Exit_Click);
            // 
            // noti_Main
            // 
            this.noti_Main.ContextMenuStrip = this.menu_Main;
            this.noti_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("noti_Main.Icon")));
            this.noti_Main.Text = "菜单";
            this.noti_Main.Visible = true;
            // 
            // tim_setBackground
            // 
            this.tim_setBackground.Interval = 1000;
            this.tim_setBackground.Tick += new System.EventHandler(this.tim_setBackground_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 401);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.1D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menu_Main;
        private System.Windows.Forms.ToolStripMenuItem tool_Exit;
        private System.Windows.Forms.NotifyIcon noti_Main;
        private System.Windows.Forms.ToolStripMenuItem tool_ChangeImg;
        private System.Windows.Forms.ToolStripMenuItem tool_ChangeOpa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tool_opa_10;
        private System.Windows.Forms.ToolStripMenuItem tool_opa_20;
        private System.Windows.Forms.ToolStripMenuItem tool_opa_30;
        private System.Windows.Forms.ToolStripMenuItem tool_opa_40;
        private System.Windows.Forms.ToolStripMenuItem tool_opa_50;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tool_opa_custom;
        private System.Windows.Forms.ToolStripMenuItem tool_selectFile;
        private System.Windows.Forms.ToolStripMenuItem tool_system;
        private System.Windows.Forms.Timer tim_setBackground;
    }
}

