using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AscomAgent
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // 响应菜单指令
        private void menuFileSaveParam_Click(object sender, EventArgs e)
        {// 保存配置参数

        }
        private void menuFileExit_Click(object sender, EventArgs e)
        {// 退出程序
            // 检查与设备的连接状态, 判定退出前是否需要判定
            Close();
        }

        private void menuMountSelect_Click(object sender, EventArgs e)
        {// 选择软件连接的转台
            // 调用ASCOM选择转台

        }

        private void menuDomeSelect_Click(object sender, EventArgs e)
        {// 选择软件连接的圆顶

        }

        private void menuFilterSelect_Click(object sender, EventArgs e)
        {// 选择软件连接的滤光片

        }

        private void menuNetConfig_Click(object sender, EventArgs e)
        {// 配置网络参数

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
