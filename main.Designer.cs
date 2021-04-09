namespace AscomAgent
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveParam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMountSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFocus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFocusSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFocusFocus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDomeSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDomeCtrl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilterSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilterSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNetConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mentNetNTP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTestTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTestSlew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLinkMount = new System.Windows.Forms.Button();
            this.btnLinkDome = new System.Windows.Forms.Button();
            this.btnLinkFilter = new System.Windows.Forms.Button();
            this.btnLinkServer = new System.Windows.Forms.Button();
            this.btnLinkFocus = new System.Windows.Forms.Button();
            this.grpMount = new System.Windows.Forms.GroupBox();
            this.btnMountSync = new System.Windows.Forms.Button();
            this.btnMountPark = new System.Windows.Forms.Button();
            this.btnMountHome = new System.Windows.Forms.Button();
            this.grpMountState = new System.Windows.Forms.GroupBox();
            this.lblMountStateAlt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMountStateAzi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMountStateDEC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMountStateRA = new System.Windows.Forms.Label();
            this.lbl09 = new System.Windows.Forms.Label();
            this.lblMountStateState = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMountStateST = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMountAbort = new System.Windows.Forms.Button();
            this.grpMountSlew = new System.Windows.Forms.GroupBox();
            this.btnMountSlew = new System.Windows.Forms.Button();
            this.cmbMountSlewEpoch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMountSlewDEC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMountSlewRA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progMountSlew = new System.Windows.Forms.ProgressBar();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblFocus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDome = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDomeSlit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblClockPC = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblClockNTP = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblClockDiff = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tmrMount = new System.Windows.Forms.Timer(this.components);
            this.tmrFocus = new System.Windows.Forms.Timer(this.components);
            this.tmrDome = new System.Windows.Forms.Timer(this.components);
            this.tmrFilter = new System.Windows.Forms.Timer(this.components);
            this.tmrNet = new System.Windows.Forms.Timer(this.components);
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.menuMain.SuspendLayout();
            this.grpMount.SuspendLayout();
            this.grpMountState.SuspendLayout();
            this.grpMountSlew.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuMount,
            this.menuFocus,
            this.menuDome,
            this.menuFilter,
            this.menuNetwork,
            this.menuTest});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(980, 29);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "main";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileSaveParam,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.menuFile.Size = new System.Drawing.Size(73, 25);
            this.menuFile.Text = "文件(&F)";
            // 
            // menuFileSaveParam
            // 
            this.menuFileSaveParam.Name = "menuFileSaveParam";
            this.menuFileSaveParam.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSaveParam.Size = new System.Drawing.Size(233, 26);
            this.menuFileSaveParam.Text = "保存参数(&S)...";
            this.menuFileSaveParam.Click += new System.EventHandler(this.menuFileSaveParam_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuFileExit.Size = new System.Drawing.Size(233, 26);
            this.menuFileExit.Text = "退出(&X)";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuMount
            // 
            this.menuMount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMountSelect});
            this.menuMount.Name = "menuMount";
            this.menuMount.Size = new System.Drawing.Size(80, 25);
            this.menuMount.Text = "转台(&M)";
            // 
            // menuMountSelect
            // 
            this.menuMountSelect.Name = "menuMountSelect";
            this.menuMountSelect.Size = new System.Drawing.Size(124, 26);
            this.menuMountSelect.Text = "选择...";
            this.menuMountSelect.Click += new System.EventHandler(this.menuMountSelect_Click);
            // 
            // menuFocus
            // 
            this.menuFocus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFocusSelect,
            this.menuFocusFocus});
            this.menuFocus.Name = "menuFocus";
            this.menuFocus.Size = new System.Drawing.Size(54, 25);
            this.menuFocus.Text = "调焦";
            // 
            // menuFocusSelect
            // 
            this.menuFocusSelect.Name = "menuFocusSelect";
            this.menuFocusSelect.Size = new System.Drawing.Size(124, 26);
            this.menuFocusSelect.Text = "选择...";
            // 
            // menuFocusFocus
            // 
            this.menuFocusFocus.Name = "menuFocusFocus";
            this.menuFocusFocus.Size = new System.Drawing.Size(124, 26);
            this.menuFocusFocus.Text = "调焦...";
            // 
            // menuDome
            // 
            this.menuDome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDomeSelect,
            this.menuDomeCtrl});
            this.menuDome.Name = "menuDome";
            this.menuDome.Size = new System.Drawing.Size(76, 25);
            this.menuDome.Text = "圆顶(&D)";
            // 
            // menuDomeSelect
            // 
            this.menuDomeSelect.Name = "menuDomeSelect";
            this.menuDomeSelect.Size = new System.Drawing.Size(124, 26);
            this.menuDomeSelect.Text = "选择...";
            this.menuDomeSelect.Click += new System.EventHandler(this.menuDomeSelect_Click);
            // 
            // menuDomeCtrl
            // 
            this.menuDomeCtrl.Name = "menuDomeCtrl";
            this.menuDomeCtrl.Size = new System.Drawing.Size(124, 26);
            this.menuDomeCtrl.Text = "控制...";
            // 
            // menuFilter
            // 
            this.menuFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFilterSelect,
            this.menuFilterSwitch});
            this.menuFilter.Name = "menuFilter";
            this.menuFilter.Size = new System.Drawing.Size(70, 25);
            this.menuFilter.Text = "滤光片";
            // 
            // menuFilterSelect
            // 
            this.menuFilterSelect.Name = "menuFilterSelect";
            this.menuFilterSelect.Size = new System.Drawing.Size(172, 26);
            this.menuFilterSelect.Text = "选择...";
            this.menuFilterSelect.Click += new System.EventHandler(this.menuFilterSelect_Click);
            // 
            // menuFilterSwitch
            // 
            this.menuFilterSwitch.Name = "menuFilterSwitch";
            this.menuFilterSwitch.Size = new System.Drawing.Size(172, 26);
            this.menuFilterSwitch.Text = "切换滤光片...";
            // 
            // menuNetwork
            // 
            this.menuNetwork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNetConfig,
            this.mentNetNTP});
            this.menuNetwork.Name = "menuNetwork";
            this.menuNetwork.Size = new System.Drawing.Size(77, 25);
            this.menuNetwork.Text = "网络(&N)";
            // 
            // menuNetConfig
            // 
            this.menuNetConfig.Name = "menuNetConfig";
            this.menuNetConfig.Size = new System.Drawing.Size(124, 26);
            this.menuNetConfig.Text = "配置...";
            this.menuNetConfig.Click += new System.EventHandler(this.menuNetConfig_Click);
            // 
            // mentNetNTP
            // 
            this.mentNetNTP.Name = "mentNetNTP";
            this.mentNetNTP.Size = new System.Drawing.Size(124, 26);
            this.mentNetNTP.Text = "NTP...";
            // 
            // menuTest
            // 
            this.menuTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTestTrack,
            this.menuTestSlew});
            this.menuTest.Name = "menuTest";
            this.menuTest.Size = new System.Drawing.Size(105, 25);
            this.menuTest.Text = "测试工具(&T)";
            // 
            // menuTestTrack
            // 
            this.menuTestTrack.Name = "menuTestTrack";
            this.menuTestTrack.Size = new System.Drawing.Size(172, 26);
            this.menuTestTrack.Text = "跟踪稳定性...";
            // 
            // menuTestSlew
            // 
            this.menuTestSlew.Name = "menuTestSlew";
            this.menuTestSlew.Size = new System.Drawing.Size(172, 26);
            this.menuTestSlew.Text = "指向过程...";
            // 
            // btnLinkMount
            // 
            this.btnLinkMount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinkMount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLinkMount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLinkMount.Location = new System.Drawing.Point(25, 60);
            this.btnLinkMount.Name = "btnLinkMount";
            this.btnLinkMount.Size = new System.Drawing.Size(110, 40);
            this.btnLinkMount.TabIndex = 1;
            this.btnLinkMount.Text = "连接转台";
            this.btnLinkMount.UseVisualStyleBackColor = false;
            // 
            // btnLinkDome
            // 
            this.btnLinkDome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinkDome.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLinkDome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLinkDome.Location = new System.Drawing.Point(25, 190);
            this.btnLinkDome.Name = "btnLinkDome";
            this.btnLinkDome.Size = new System.Drawing.Size(110, 40);
            this.btnLinkDome.TabIndex = 3;
            this.btnLinkDome.Text = "连接圆顶";
            this.btnLinkDome.UseVisualStyleBackColor = false;
            // 
            // btnLinkFilter
            // 
            this.btnLinkFilter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinkFilter.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLinkFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLinkFilter.Location = new System.Drawing.Point(25, 255);
            this.btnLinkFilter.Name = "btnLinkFilter";
            this.btnLinkFilter.Size = new System.Drawing.Size(110, 40);
            this.btnLinkFilter.TabIndex = 4;
            this.btnLinkFilter.Text = "连接滤光片";
            this.btnLinkFilter.UseVisualStyleBackColor = false;
            // 
            // btnLinkServer
            // 
            this.btnLinkServer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinkServer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLinkServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLinkServer.Location = new System.Drawing.Point(25, 320);
            this.btnLinkServer.Name = "btnLinkServer";
            this.btnLinkServer.Size = new System.Drawing.Size(110, 40);
            this.btnLinkServer.TabIndex = 5;
            this.btnLinkServer.Text = "连接服务器";
            this.btnLinkServer.UseVisualStyleBackColor = false;
            // 
            // btnLinkFocus
            // 
            this.btnLinkFocus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinkFocus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLinkFocus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLinkFocus.Location = new System.Drawing.Point(25, 125);
            this.btnLinkFocus.Name = "btnLinkFocus";
            this.btnLinkFocus.Size = new System.Drawing.Size(110, 40);
            this.btnLinkFocus.TabIndex = 2;
            this.btnLinkFocus.Text = "连接调焦器";
            this.btnLinkFocus.UseVisualStyleBackColor = false;
            // 
            // grpMount
            // 
            this.grpMount.Controls.Add(this.btnMountSync);
            this.grpMount.Controls.Add(this.btnMountPark);
            this.grpMount.Controls.Add(this.btnMountHome);
            this.grpMount.Controls.Add(this.grpMountState);
            this.grpMount.Controls.Add(this.btnMountAbort);
            this.grpMount.Controls.Add(this.grpMountSlew);
            this.grpMount.Controls.Add(this.progMountSlew);
            this.grpMount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpMount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grpMount.Location = new System.Drawing.Point(160, 60);
            this.grpMount.Name = "grpMount";
            this.grpMount.Size = new System.Drawing.Size(800, 300);
            this.grpMount.TabIndex = 6;
            this.grpMount.TabStop = false;
            this.grpMount.Text = "转  台";
            // 
            // btnMountSync
            // 
            this.btnMountSync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMountSync.Location = new System.Drawing.Point(670, 180);
            this.btnMountSync.Name = "btnMountSync";
            this.btnMountSync.Size = new System.Drawing.Size(120, 40);
            this.btnMountSync.TabIndex = 11;
            this.btnMountSync.Text = "同步零点";
            this.btnMountSync.UseVisualStyleBackColor = true;
            // 
            // btnMountPark
            // 
            this.btnMountPark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMountPark.Location = new System.Drawing.Point(670, 120);
            this.btnMountPark.Name = "btnMountPark";
            this.btnMountPark.Size = new System.Drawing.Size(120, 40);
            this.btnMountPark.TabIndex = 10;
            this.btnMountPark.Text = "复  位";
            this.btnMountPark.UseVisualStyleBackColor = true;
            // 
            // btnMountHome
            // 
            this.btnMountHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMountHome.Location = new System.Drawing.Point(670, 60);
            this.btnMountHome.Name = "btnMountHome";
            this.btnMountHome.Size = new System.Drawing.Size(120, 40);
            this.btnMountHome.TabIndex = 9;
            this.btnMountHome.Text = "搜索零点";
            this.btnMountHome.UseVisualStyleBackColor = true;
            // 
            // grpMountState
            // 
            this.grpMountState.Controls.Add(this.lblMountStateAlt);
            this.grpMountState.Controls.Add(this.label8);
            this.grpMountState.Controls.Add(this.lblMountStateAzi);
            this.grpMountState.Controls.Add(this.label10);
            this.grpMountState.Controls.Add(this.lblMountStateDEC);
            this.grpMountState.Controls.Add(this.label5);
            this.grpMountState.Controls.Add(this.lblMountStateRA);
            this.grpMountState.Controls.Add(this.lbl09);
            this.grpMountState.Controls.Add(this.lblMountStateState);
            this.grpMountState.Controls.Add(this.label7);
            this.grpMountState.Controls.Add(this.lblMountStateST);
            this.grpMountState.Controls.Add(this.label6);
            this.grpMountState.Location = new System.Drawing.Point(240, 70);
            this.grpMountState.Name = "grpMountState";
            this.grpMountState.Size = new System.Drawing.Size(410, 150);
            this.grpMountState.TabIndex = 8;
            this.grpMountState.TabStop = false;
            this.grpMountState.Text = "状  态";
            // 
            // lblMountStateAlt
            // 
            this.lblMountStateAlt.BackColor = System.Drawing.Color.Black;
            this.lblMountStateAlt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMountStateAlt.ForeColor = System.Drawing.Color.Lime;
            this.lblMountStateAlt.Location = new System.Drawing.Point(285, 100);
            this.lblMountStateAlt.Name = "lblMountStateAlt";
            this.lblMountStateAlt.Size = new System.Drawing.Size(110, 25);
            this.lblMountStateAlt.TabIndex = 13;
            this.lblMountStateAlt.Text = "+00.0000";
            this.lblMountStateAlt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(210, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Alt.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMountStateAzi
            // 
            this.lblMountStateAzi.BackColor = System.Drawing.Color.Black;
            this.lblMountStateAzi.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMountStateAzi.ForeColor = System.Drawing.Color.Lime;
            this.lblMountStateAzi.Location = new System.Drawing.Point(80, 100);
            this.lblMountStateAzi.Name = "lblMountStateAzi";
            this.lblMountStateAzi.Size = new System.Drawing.Size(110, 25);
            this.lblMountStateAzi.TabIndex = 11;
            this.lblMountStateAzi.Text = "000.0000";
            this.lblMountStateAzi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(10, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Azi.:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMountStateDEC
            // 
            this.lblMountStateDEC.BackColor = System.Drawing.Color.Black;
            this.lblMountStateDEC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMountStateDEC.ForeColor = System.Drawing.Color.Lime;
            this.lblMountStateDEC.Location = new System.Drawing.Point(285, 65);
            this.lblMountStateDEC.Name = "lblMountStateDEC";
            this.lblMountStateDEC.Size = new System.Drawing.Size(110, 25);
            this.lblMountStateDEC.TabIndex = 9;
            this.lblMountStateDEC.Text = "+00:00:00.0";
            this.lblMountStateDEC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(210, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "DEC.:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMountStateRA
            // 
            this.lblMountStateRA.BackColor = System.Drawing.Color.Black;
            this.lblMountStateRA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMountStateRA.ForeColor = System.Drawing.Color.Lime;
            this.lblMountStateRA.Location = new System.Drawing.Point(80, 65);
            this.lblMountStateRA.Name = "lblMountStateRA";
            this.lblMountStateRA.Size = new System.Drawing.Size(110, 25);
            this.lblMountStateRA.TabIndex = 7;
            this.lblMountStateRA.Text = "00:00:00.00";
            this.lblMountStateRA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl09
            // 
            this.lbl09.ForeColor = System.Drawing.Color.Black;
            this.lbl09.Location = new System.Drawing.Point(10, 65);
            this.lbl09.Name = "lbl09";
            this.lbl09.Size = new System.Drawing.Size(60, 25);
            this.lbl09.TabIndex = 6;
            this.lbl09.Text = "R.A.:";
            this.lbl09.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMountStateState
            // 
            this.lblMountStateState.BackColor = System.Drawing.Color.Black;
            this.lblMountStateState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMountStateState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMountStateState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMountStateState.Location = new System.Drawing.Point(285, 30);
            this.lblMountStateState.Name = "lblMountStateState";
            this.lblMountStateState.Size = new System.Drawing.Size(110, 25);
            this.lblMountStateState.TabIndex = 5;
            this.lblMountStateState.Text = "Freeze";
            this.lblMountStateState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(210, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "State:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMountStateST
            // 
            this.lblMountStateST.BackColor = System.Drawing.Color.Black;
            this.lblMountStateST.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMountStateST.ForeColor = System.Drawing.Color.Lime;
            this.lblMountStateST.Location = new System.Drawing.Point(80, 30);
            this.lblMountStateST.Name = "lblMountStateST";
            this.lblMountStateST.Size = new System.Drawing.Size(110, 25);
            this.lblMountStateST.TabIndex = 3;
            this.lblMountStateST.Text = "00:00:00.00";
            this.lblMountStateST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "S.T.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMountAbort
            // 
            this.btnMountAbort.ForeColor = System.Drawing.Color.Red;
            this.btnMountAbort.Location = new System.Drawing.Point(240, 235);
            this.btnMountAbort.Name = "btnMountAbort";
            this.btnMountAbort.Size = new System.Drawing.Size(400, 40);
            this.btnMountAbort.TabIndex = 7;
            this.btnMountAbort.Text = "停    止";
            this.btnMountAbort.UseVisualStyleBackColor = true;
            // 
            // grpMountSlew
            // 
            this.grpMountSlew.Controls.Add(this.btnMountSlew);
            this.grpMountSlew.Controls.Add(this.cmbMountSlewEpoch);
            this.grpMountSlew.Controls.Add(this.label3);
            this.grpMountSlew.Controls.Add(this.txtMountSlewDEC);
            this.grpMountSlew.Controls.Add(this.label2);
            this.grpMountSlew.Controls.Add(this.txtMountSlewRA);
            this.grpMountSlew.Controls.Add(this.label1);
            this.grpMountSlew.Location = new System.Drawing.Point(10, 70);
            this.grpMountSlew.Name = "grpMountSlew";
            this.grpMountSlew.Size = new System.Drawing.Size(210, 220);
            this.grpMountSlew.TabIndex = 1;
            this.grpMountSlew.TabStop = false;
            this.grpMountSlew.Text = "指  向";
            // 
            // btnMountSlew
            // 
            this.btnMountSlew.ForeColor = System.Drawing.Color.Blue;
            this.btnMountSlew.Location = new System.Drawing.Point(35, 165);
            this.btnMountSlew.Name = "btnMountSlew";
            this.btnMountSlew.Size = new System.Drawing.Size(140, 40);
            this.btnMountSlew.TabIndex = 6;
            this.btnMountSlew.Text = "指  向";
            this.btnMountSlew.UseVisualStyleBackColor = true;
            // 
            // cmbMountSlewEpoch
            // 
            this.cmbMountSlewEpoch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMountSlewEpoch.FormattingEnabled = true;
            this.cmbMountSlewEpoch.Items.AddRange(new object[] {
            "J2000",
            "Real"});
            this.cmbMountSlewEpoch.Location = new System.Drawing.Point(80, 110);
            this.cmbMountSlewEpoch.Name = "cmbMountSlewEpoch";
            this.cmbMountSlewEpoch.Size = new System.Drawing.Size(120, 24);
            this.cmbMountSlewEpoch.TabIndex = 5;
            this.cmbMountSlewEpoch.Text = "J2000";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Epoch:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMountSlewDEC
            // 
            this.txtMountSlewDEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMountSlewDEC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMountSlewDEC.Location = new System.Drawing.Point(80, 70);
            this.txtMountSlewDEC.MaxLength = 12;
            this.txtMountSlewDEC.Name = "txtMountSlewDEC";
            this.txtMountSlewDEC.Size = new System.Drawing.Size(120, 26);
            this.txtMountSlewDEC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "DEC.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMountSlewRA
            // 
            this.txtMountSlewRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMountSlewRA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMountSlewRA.Location = new System.Drawing.Point(80, 30);
            this.txtMountSlewRA.MaxLength = 12;
            this.txtMountSlewRA.Name = "txtMountSlewRA";
            this.txtMountSlewRA.Size = new System.Drawing.Size(120, 26);
            this.txtMountSlewRA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "R.A.:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progMountSlew
            // 
            this.progMountSlew.Location = new System.Drawing.Point(10, 30);
            this.progMountSlew.Name = "progMountSlew";
            this.progMountSlew.Size = new System.Drawing.Size(640, 25);
            this.progMountSlew.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progMountSlew.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.AcceptsReturn = true;
            this.txtLog.Location = new System.Drawing.Point(470, 370);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(490, 250);
            this.txtLog.TabIndex = 7;
            // 
            // lblFocus
            // 
            this.lblFocus.BackColor = System.Drawing.Color.Black;
            this.lblFocus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFocus.ForeColor = System.Drawing.Color.Lime;
            this.lblFocus.Location = new System.Drawing.Point(110, 385);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(110, 25);
            this.lblFocus.TabIndex = 9;
            this.lblFocus.Text = "+0.0";
            this.lblFocus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Focus:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDome
            // 
            this.lblDome.BackColor = System.Drawing.Color.Black;
            this.lblDome.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDome.ForeColor = System.Drawing.Color.Gold;
            this.lblDome.Location = new System.Drawing.Point(110, 420);
            this.lblDome.Name = "lblDome";
            this.lblDome.Size = new System.Drawing.Size(110, 25);
            this.lblDome.TabIndex = 11;
            this.lblDome.Text = "+0.0";
            this.lblDome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Dome:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDomeSlit
            // 
            this.lblDomeSlit.BackColor = System.Drawing.Color.Black;
            this.lblDomeSlit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDomeSlit.ForeColor = System.Drawing.Color.Gold;
            this.lblDomeSlit.Location = new System.Drawing.Point(330, 420);
            this.lblDomeSlit.Name = "lblDomeSlit";
            this.lblDomeSlit.Size = new System.Drawing.Size(110, 25);
            this.lblDomeSlit.TabIndex = 13;
            this.lblDomeSlit.Text = "Closed";
            this.lblDomeSlit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(240, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Slit:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilter
            // 
            this.lblFilter.BackColor = System.Drawing.Color.Black;
            this.lblFilter.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFilter.ForeColor = System.Drawing.Color.Lime;
            this.lblFilter.Location = new System.Drawing.Point(330, 385);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(110, 25);
            this.lblFilter.TabIndex = 15;
            this.lblFilter.Text = "W";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(240, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "Filter:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServer
            // 
            this.lblServer.BackColor = System.Drawing.Color.Black;
            this.lblServer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServer.ForeColor = System.Drawing.Color.Lime;
            this.lblServer.Location = new System.Drawing.Point(110, 455);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(110, 25);
            this.lblServer.TabIndex = 17;
            this.lblServer.Text = "Connected";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(20, 455);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "Server:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClockPC
            // 
            this.lblClockPC.BackColor = System.Drawing.Color.Black;
            this.lblClockPC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClockPC.ForeColor = System.Drawing.Color.Gold;
            this.lblClockPC.Location = new System.Drawing.Point(110, 495);
            this.lblClockPC.Name = "lblClockPC";
            this.lblClockPC.Size = new System.Drawing.Size(110, 25);
            this.lblClockPC.TabIndex = 19;
            this.lblClockPC.Text = "00:00:00.00";
            this.lblClockPC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(20, 495);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 25);
            this.label15.TabIndex = 18;
            this.label15.Text = "PC Clock:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClockNTP
            // 
            this.lblClockNTP.BackColor = System.Drawing.Color.Black;
            this.lblClockNTP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClockNTP.ForeColor = System.Drawing.Color.Gold;
            this.lblClockNTP.Location = new System.Drawing.Point(330, 495);
            this.lblClockNTP.Name = "lblClockNTP";
            this.lblClockNTP.Size = new System.Drawing.Size(110, 25);
            this.lblClockNTP.TabIndex = 21;
            this.lblClockNTP.Text = "00:00:00.00";
            this.lblClockNTP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(240, 495);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "NTP:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClockDiff
            // 
            this.lblClockDiff.BackColor = System.Drawing.Color.Black;
            this.lblClockDiff.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClockDiff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClockDiff.Location = new System.Drawing.Point(110, 530);
            this.lblClockDiff.Name = "lblClockDiff";
            this.lblClockDiff.Size = new System.Drawing.Size(110, 25);
            this.lblClockDiff.TabIndex = 23;
            this.lblClockDiff.Text = "0.0";
            this.lblClockDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(20, 530);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 25);
            this.label17.TabIndex = 22;
            this.label17.Text = "NTP-PC:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrFocus
            // 
            this.tmrFocus.Interval = 1000;
            // 
            // tmrDome
            // 
            this.tmrDome.Interval = 1000;
            // 
            // tmrFilter
            // 
            this.tmrFilter.Interval = 1000;
            // 
            // tmrNet
            // 
            this.tmrNet.Interval = 1000;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 648);
            this.Controls.Add(this.lblClockDiff);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblClockNTP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblClockPC);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDomeSlit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpMount);
            this.Controls.Add(this.btnLinkMount);
            this.Controls.Add(this.btnLinkFocus);
            this.Controls.Add(this.btnLinkDome);
            this.Controls.Add(this.btnLinkFilter);
            this.Controls.Add(this.btnLinkServer);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "AscomAgent -- 基于ASCOM封装望远镜控制接口";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grpMount.ResumeLayout(false);
            this.grpMountState.ResumeLayout(false);
            this.grpMountSlew.ResumeLayout(false);
            this.grpMountSlew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveParam;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuMount;
        private System.Windows.Forms.ToolStripMenuItem menuDome;
        private System.Windows.Forms.ToolStripMenuItem menuNetwork;
        private System.Windows.Forms.ToolStripMenuItem menuTest;
        private System.Windows.Forms.ToolStripMenuItem menuMountSelect;
        private System.Windows.Forms.ToolStripMenuItem menuDomeSelect;
        private System.Windows.Forms.ToolStripMenuItem menuFilter;
        private System.Windows.Forms.ToolStripMenuItem menuFilterSelect;
        private System.Windows.Forms.ToolStripMenuItem menuNetConfig;
        private System.Windows.Forms.Button btnLinkMount;
        private System.Windows.Forms.Button btnLinkDome;
        private System.Windows.Forms.Button btnLinkFilter;
        private System.Windows.Forms.Button btnLinkServer;
        private System.Windows.Forms.ToolStripMenuItem mentNetNTP;
        private System.Windows.Forms.ToolStripMenuItem menuFocus;
        private System.Windows.Forms.ToolStripMenuItem menuFocusSelect;
        private System.Windows.Forms.Button btnLinkFocus;
        private System.Windows.Forms.GroupBox grpMount;
        private System.Windows.Forms.GroupBox grpMountSlew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progMountSlew;
        private System.Windows.Forms.TextBox txtMountSlewRA;
        private System.Windows.Forms.Button btnMountAbort;
        private System.Windows.Forms.Button btnMountSlew;
        private System.Windows.Forms.ComboBox cmbMountSlewEpoch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMountSlewDEC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpMountState;
        private System.Windows.Forms.Label lblMountStateAlt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMountStateAzi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMountStateDEC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMountStateRA;
        private System.Windows.Forms.Label lbl09;
        private System.Windows.Forms.Label lblMountStateState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMountStateST;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMountSync;
        private System.Windows.Forms.Button btnMountPark;
        private System.Windows.Forms.Button btnMountHome;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDomeSlit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblClockPC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblClockNTP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblClockDiff;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem menuFocusFocus;
        private System.Windows.Forms.ToolStripMenuItem menuDomeCtrl;
        private System.Windows.Forms.ToolStripMenuItem menuFilterSwitch;
        private System.Windows.Forms.ToolStripMenuItem menuTestTrack;
        private System.Windows.Forms.ToolStripMenuItem menuTestSlew;
        private System.Windows.Forms.Timer tmrMount;
        private System.Windows.Forms.Timer tmrFocus;
        private System.Windows.Forms.Timer tmrDome;
        private System.Windows.Forms.Timer tmrFilter;
        private System.Windows.Forms.Timer tmrNet;
        private System.Windows.Forms.Timer tmrClock;
    }
}

