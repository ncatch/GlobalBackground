using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyApp
{
    public partial class frmMain : Form
    {
        private const uint WS_EX_LAYERED = 524288u;

        private const int WS_EX_TRANSPARENT = 32;

        private const int GWL_STYLE = -16;

        private const int GWL_EXSTYLE = -20;

        private const int LWA_ALPHA = 0;

        [DllImport("user32")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);

        [DllImport("user32")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport("user32")]
        private static extern int SetLayeredWindowAttributes(IntPtr hwnd, int crKey, int bAlpha, int dwFlags);

        public frmMain()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.  
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲  
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string text = ConfigurationManager.AppSettings["url"];
            string value = ConfigurationManager.AppSettings["Opacity"];
            if (!string.IsNullOrEmpty(text))
            {
                if (this.BackgroundImage != null)
                {
                    this.BackgroundImage.Dispose();
                }
                this.BackgroundImage = Image.FromFile(text);
            }

            this.SetPenetrate();

            this.Opacity = 0.1;
            if (!string.IsNullOrEmpty(value))
            {
                this.Opacity = Convert.ToDouble(value);
            }

            //this.ShowInTaskbar = true;

            if (Convert.ToBoolean(ConfigurationManager.AppSettings["followingSystem"]))
            {
                tool_system_Click(null, null);
            }
        }

        public void SetPenetrate()
        {
            frmMain.GetWindowLong(base.Handle, -20);
            frmMain.SetWindowLong(base.Handle, -20, 524320u);
            frmMain.SetLayeredWindowAttributes(base.Handle, 0, 100, 0);
        }

        public void SetConfig(string name, string value)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Application.ExecutablePath + ".config");
            XmlNode xmlNode = xmlDocument.SelectSingleNode("//add[@key='" + name + "']");
            XmlElement xmlElement = (XmlElement)xmlNode;
            xmlElement.SetAttribute("value", value);
            xmlDocument.Save(Application.ExecutablePath + ".config");
        }

        private void tool_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
        }

        private void tool_ChangeImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg图片|*.jpg|png图片|*.png";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                ConfigurationManager.AppSettings["followingSystem"] = "false";
                SetConfig("followingSystem", "false");

                string fileName = openFileDialog.FileName;
                ConfigurationManager.AppSettings["url"] = fileName;
                this.SetConfig("url", fileName);
                this.SetConfig("followingSystem", "false");
                this.frmMain_Load(null, null);
            }
        }

        private void tool_ChangeOpa_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            base.Opacity = Convert.ToDouble(toolStripMenuItem.Tag);
            this.SetConfig("Opacity", toolStripMenuItem.Tag.ToString());
        }

        private void tool_opa_custom_Click(object sender, EventArgs e)
        {
            int num = 1;
            do
            {
                string text = Interaction.InputBox("请输入透明度", "输入透明度", "", 100, 100);
                if (string.IsNullOrEmpty(text))
                {
                    break;
                }
                if (!int.TryParse(text, out num) || num <= 0 || num >= 100)
                {
                    MessageBox.Show("请输入1-100之间的数!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    num = 0;
                }
            }
            while (num == 0);

            if (num != 0)
            {
                base.Opacity = (double)num/100;
                this.SetConfig("Opacity", ((double)num/100).ToString());
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 注意判断关闭事件reason来源于窗体按钮，否则用菜单退出时无法退出!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //取消"关闭窗口"事件
                e.Cancel = true;
                //使关闭时窗口向右下角缩小的效果
                this.WindowState = FormWindowState.Minimized;
                this.noti_Main.Visible = true;
                this.Hide();
                this.Dispose();
                return;
            }
        }

        #region 获取桌面背景路径
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SystemParametersInfo(uint uAction, uint uParam, StringBuilder lpvParam, uint init);

        const uint SPI_GETDESKWALLPAPER = 0x0073;
        #endregion


        private void tool_system_Click(object sender, EventArgs e)
        {
            tim_setBackground.Enabled = true;
            ConfigurationManager.AppSettings["followingSystem"] = "true";
            SetConfig("followingSystem", "true");
        }

        StringBuilder wallPaperPath = new StringBuilder(200);
        private void tim_setBackground_Tick(object sender, EventArgs e)
        {
            if (SystemParametersInfo(SPI_GETDESKWALLPAPER, 200, wallPaperPath, 0))
            {
                if (Convert.ToBoolean(ConfigurationManager.AppSettings["followingSystem"]) && wallPaperPath.ToString() != ConfigurationManager.AppSettings["url"])
                {
                    ConfigurationManager.AppSettings["url"] = wallPaperPath.ToString();
                    this.SetConfig("url", wallPaperPath.ToString());
                    this.frmMain_Load(null, null);
                }
            }
        }
    }
}
