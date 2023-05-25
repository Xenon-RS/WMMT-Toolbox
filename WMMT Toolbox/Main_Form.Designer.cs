namespace WMMT_Toolbox
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ME_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Server_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_Box_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Game = new System.Windows.Forms.TabControl();
            this.tabPage_Main = new System.Windows.Forms.TabPage();
            this.comboBox_Cards = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_Terminal_Mode = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Maxi_Start = new System.Windows.Forms.CheckBox();
            this.checkBox_AMA_Start = new System.Windows.Forms.CheckBox();
            this.checkBox_TP_Start = new System.Windows.Forms.CheckBox();
            this.checkBox_direct_start = new System.Windows.Forms.CheckBox();
            this.button_Create_Ink = new System.Windows.Forms.Button();
            this.button_Start_Game = new System.Windows.Forms.Button();
            this.tabPage_gp_Setting = new System.Windows.Forms.TabPage();
            this.button_TP_Select = new System.Windows.Forms.Button();
            this.button_AMA_Select = new System.Windows.Forms.Button();
            this.button_Maxi_Select = new System.Windows.Forms.Button();
            this.textBox_TP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AMA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Maxi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_Settings = new System.Windows.Forms.TabControl();
            this.tabPage_Tools = new System.Windows.Forms.TabPage();
            this.button_CardManager = new System.Windows.Forms.Button();
            this.button_card = new System.Windows.Forms.Button();
            this.button_Net_Fix = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_res = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage_Maxi = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl_Game.SuspendLayout();
            this.tabPage_Main.SuspendLayout();
            this.tabPage_gp_Setting.SuspendLayout();
            this.tabControl_Settings.SuspendLayout();
            this.tabPage_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(384, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_ME_ToolStripMenuItem,
            this.Server_ToolStripMenuItem,
            this.About_Box_ToolStripMenuItem});
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.About_ToolStripMenuItem.Text = "关于";
            // 
            // About_ME_ToolStripMenuItem
            // 
            this.About_ME_ToolStripMenuItem.Name = "About_ME_ToolStripMenuItem";
            this.About_ME_ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.About_ME_ToolStripMenuItem.Text = "关于作者";
            this.About_ME_ToolStripMenuItem.Click += new System.EventHandler(this.About_ME_ToolStripMenuItem_Click);
            // 
            // Server_ToolStripMenuItem
            // 
            this.Server_ToolStripMenuItem.Name = "Server_ToolStripMenuItem";
            this.Server_ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.Server_ToolStripMenuItem.Text = "友情服务器";
            this.Server_ToolStripMenuItem.Click += new System.EventHandler(this.Server_ToolStripMenuItem_Click);
            // 
            // About_Box_ToolStripMenuItem
            // 
            this.About_Box_ToolStripMenuItem.Name = "About_Box_ToolStripMenuItem";
            this.About_Box_ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.About_Box_ToolStripMenuItem.Text = "关于工具箱";
            this.About_Box_ToolStripMenuItem.Click += new System.EventHandler(this.About_Box_ToolStripMenuItem_Click);
            // 
            // tabControl_Game
            // 
            this.tabControl_Game.Controls.Add(this.tabPage_Main);
            this.tabControl_Game.Controls.Add(this.tabPage_gp_Setting);
            this.tabControl_Game.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl_Game.Location = new System.Drawing.Point(12, 329);
            this.tabControl_Game.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl_Game.Name = "tabControl_Game";
            this.tabControl_Game.SelectedIndex = 0;
            this.tabControl_Game.Size = new System.Drawing.Size(360, 222);
            this.tabControl_Game.TabIndex = 1;
            // 
            // tabPage_Main
            // 
            this.tabPage_Main.BackColor = System.Drawing.Color.White;
            this.tabPage_Main.Controls.Add(this.comboBox_Cards);
            this.tabPage_Main.Controls.Add(this.label7);
            this.tabPage_Main.Controls.Add(this.checkBox_Terminal_Mode);
            this.tabPage_Main.Controls.Add(this.label4);
            this.tabPage_Main.Controls.Add(this.checkBox_Maxi_Start);
            this.tabPage_Main.Controls.Add(this.checkBox_AMA_Start);
            this.tabPage_Main.Controls.Add(this.checkBox_TP_Start);
            this.tabPage_Main.Controls.Add(this.checkBox_direct_start);
            this.tabPage_Main.Controls.Add(this.button_Create_Ink);
            this.tabPage_Main.Controls.Add(this.button_Start_Game);
            this.tabPage_Main.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Main.Name = "tabPage_Main";
            this.tabPage_Main.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Main.Size = new System.Drawing.Size(352, 189);
            this.tabPage_Main.TabIndex = 0;
            this.tabPage_Main.Text = "游戏启动";
            // 
            // comboBox_Cards
            // 
            this.comboBox_Cards.FormattingEnabled = true;
            this.comboBox_Cards.Location = new System.Drawing.Point(180, 44);
            this.comboBox_Cards.Name = "comboBox_Cards";
            this.comboBox_Cards.Size = new System.Drawing.Size(166, 28);
            this.comboBox_Cards.TabIndex = 8;
            this.comboBox_Cards.Text = "留空则使用当前卡片";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(176, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "选择卡片";
            // 
            // checkBox_Terminal_Mode
            // 
            this.checkBox_Terminal_Mode.AutoSize = true;
            this.checkBox_Terminal_Mode.Location = new System.Drawing.Point(11, 152);
            this.checkBox_Terminal_Mode.Name = "checkBox_Terminal_Mode";
            this.checkBox_Terminal_Mode.Size = new System.Drawing.Size(106, 24);
            this.checkBox_Terminal_Mode.TabIndex = 6;
            this.checkBox_Terminal_Mode.Text = "终端机模式";
            this.checkBox_Terminal_Mode.UseVisualStyleBackColor = true;
            this.checkBox_Terminal_Mode.CheckedChanged += new System.EventHandler(this.checkBox_Terminal_Mode_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "高级启动";
            // 
            // checkBox_Maxi_Start
            // 
            this.checkBox_Maxi_Start.AutoSize = true;
            this.checkBox_Maxi_Start.Checked = true;
            this.checkBox_Maxi_Start.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Maxi_Start.Location = new System.Drawing.Point(11, 32);
            this.checkBox_Maxi_Start.Name = "checkBox_Maxi_Start";
            this.checkBox_Maxi_Start.Size = new System.Drawing.Size(159, 24);
            this.checkBox_Maxi_Start.TabIndex = 4;
            this.checkBox_Maxi_Start.Text = "启动MaxiTerminal";
            this.checkBox_Maxi_Start.UseVisualStyleBackColor = true;
            this.checkBox_Maxi_Start.CheckedChanged += new System.EventHandler(this.checkBox_Maxi_Start_CheckedChanged);
            // 
            // checkBox_AMA_Start
            // 
            this.checkBox_AMA_Start.AutoSize = true;
            this.checkBox_AMA_Start.Checked = true;
            this.checkBox_AMA_Start.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AMA_Start.Location = new System.Drawing.Point(11, 62);
            this.checkBox_AMA_Start.Name = "checkBox_AMA_Start";
            this.checkBox_AMA_Start.Size = new System.Drawing.Size(162, 24);
            this.checkBox_AMA_Start.TabIndex = 3;
            this.checkBox_AMA_Start.Text = "启动AMAuthd.exe";
            this.checkBox_AMA_Start.UseVisualStyleBackColor = true;
            this.checkBox_AMA_Start.CheckedChanged += new System.EventHandler(this.checkBox_AMA_Start_CheckedChanged);
            // 
            // checkBox_TP_Start
            // 
            this.checkBox_TP_Start.AutoSize = true;
            this.checkBox_TP_Start.Checked = true;
            this.checkBox_TP_Start.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_TP_Start.Location = new System.Drawing.Point(11, 92);
            this.checkBox_TP_Start.Name = "checkBox_TP_Start";
            this.checkBox_TP_Start.Size = new System.Drawing.Size(136, 24);
            this.checkBox_TP_Start.TabIndex = 2;
            this.checkBox_TP_Start.Text = "启动鹦鹉模拟器";
            this.checkBox_TP_Start.UseVisualStyleBackColor = true;
            this.checkBox_TP_Start.CheckedChanged += new System.EventHandler(this.checkBox_TP_Start_CheckedChanged);
            // 
            // checkBox_direct_start
            // 
            this.checkBox_direct_start.AutoSize = true;
            this.checkBox_direct_start.Checked = true;
            this.checkBox_direct_start.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_direct_start.Location = new System.Drawing.Point(11, 122);
            this.checkBox_direct_start.Name = "checkBox_direct_start";
            this.checkBox_direct_start.Size = new System.Drawing.Size(121, 24);
            this.checkBox_direct_start.TabIndex = 1;
            this.checkBox_direct_start.Text = "直接启动游戏";
            this.checkBox_direct_start.UseVisualStyleBackColor = true;
            // 
            // button_Create_Ink
            // 
            this.button_Create_Ink.Location = new System.Drawing.Point(180, 78);
            this.button_Create_Ink.Name = "button_Create_Ink";
            this.button_Create_Ink.Size = new System.Drawing.Size(166, 31);
            this.button_Create_Ink.TabIndex = 0;
            this.button_Create_Ink.Text = "创建快捷方式到桌面";
            this.button_Create_Ink.UseVisualStyleBackColor = true;
            this.button_Create_Ink.Click += new System.EventHandler(this.button_Create_Ink_Click);
            // 
            // button_Start_Game
            // 
            this.button_Start_Game.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Start_Game.Location = new System.Drawing.Point(180, 115);
            this.button_Start_Game.Name = "button_Start_Game";
            this.button_Start_Game.Size = new System.Drawing.Size(166, 63);
            this.button_Start_Game.TabIndex = 0;
            this.button_Start_Game.Text = "启动游戏";
            this.button_Start_Game.UseVisualStyleBackColor = true;
            this.button_Start_Game.Click += new System.EventHandler(this.button_Start_Game_Click);
            // 
            // tabPage_gp_Setting
            // 
            this.tabPage_gp_Setting.Controls.Add(this.button_TP_Select);
            this.tabPage_gp_Setting.Controls.Add(this.button_AMA_Select);
            this.tabPage_gp_Setting.Controls.Add(this.button_Maxi_Select);
            this.tabPage_gp_Setting.Controls.Add(this.textBox_TP);
            this.tabPage_gp_Setting.Controls.Add(this.label3);
            this.tabPage_gp_Setting.Controls.Add(this.textBox_AMA);
            this.tabPage_gp_Setting.Controls.Add(this.label2);
            this.tabPage_gp_Setting.Controls.Add(this.textBox_Maxi);
            this.tabPage_gp_Setting.Controls.Add(this.label1);
            this.tabPage_gp_Setting.Location = new System.Drawing.Point(4, 29);
            this.tabPage_gp_Setting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_gp_Setting.Name = "tabPage_gp_Setting";
            this.tabPage_gp_Setting.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_gp_Setting.Size = new System.Drawing.Size(352, 215);
            this.tabPage_gp_Setting.TabIndex = 1;
            this.tabPage_gp_Setting.Text = "游戏启动路径设置";
            this.tabPage_gp_Setting.UseVisualStyleBackColor = true;
            // 
            // button_TP_Select
            // 
            this.button_TP_Select.BackColor = System.Drawing.Color.White;
            this.button_TP_Select.Location = new System.Drawing.Point(280, 133);
            this.button_TP_Select.Name = "button_TP_Select";
            this.button_TP_Select.Size = new System.Drawing.Size(65, 27);
            this.button_TP_Select.TabIndex = 8;
            this.button_TP_Select.Text = "选择...";
            this.button_TP_Select.UseVisualStyleBackColor = false;
            this.button_TP_Select.Click += new System.EventHandler(this.button_TP_Select_Click);
            // 
            // button_AMA_Select
            // 
            this.button_AMA_Select.BackColor = System.Drawing.Color.White;
            this.button_AMA_Select.Location = new System.Drawing.Point(281, 80);
            this.button_AMA_Select.Name = "button_AMA_Select";
            this.button_AMA_Select.Size = new System.Drawing.Size(65, 27);
            this.button_AMA_Select.TabIndex = 7;
            this.button_AMA_Select.Text = "选择...";
            this.button_AMA_Select.UseVisualStyleBackColor = false;
            this.button_AMA_Select.Click += new System.EventHandler(this.button_AMA_Select_Click);
            // 
            // button_Maxi_Select
            // 
            this.button_Maxi_Select.BackColor = System.Drawing.Color.White;
            this.button_Maxi_Select.Location = new System.Drawing.Point(281, 27);
            this.button_Maxi_Select.Name = "button_Maxi_Select";
            this.button_Maxi_Select.Size = new System.Drawing.Size(65, 27);
            this.button_Maxi_Select.TabIndex = 6;
            this.button_Maxi_Select.Text = "选择...";
            this.button_Maxi_Select.UseVisualStyleBackColor = false;
            this.button_Maxi_Select.Click += new System.EventHandler(this.button_Maxi_Select_Click);
            // 
            // textBox_TP
            // 
            this.textBox_TP.Location = new System.Drawing.Point(10, 133);
            this.textBox_TP.Name = "textBox_TP";
            this.textBox_TP.Size = new System.Drawing.Size(264, 27);
            this.textBox_TP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "TeknoParrotUi模拟器路径";
            // 
            // textBox_AMA
            // 
            this.textBox_AMA.Location = new System.Drawing.Point(10, 80);
            this.textBox_AMA.Name = "textBox_AMA";
            this.textBox_AMA.Size = new System.Drawing.Size(264, 27);
            this.textBox_AMA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AMAuthd.exe路径";
            // 
            // textBox_Maxi
            // 
            this.textBox_Maxi.Location = new System.Drawing.Point(10, 27);
            this.textBox_Maxi.Name = "textBox_Maxi";
            this.textBox_Maxi.Size = new System.Drawing.Size(264, 27);
            this.textBox_Maxi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaxiTerminal的run.bat路径";
            // 
            // tabControl_Settings
            // 
            this.tabControl_Settings.Controls.Add(this.tabPage_Tools);
            this.tabControl_Settings.Controls.Add(this.tabPage_Maxi);
            this.tabControl_Settings.Location = new System.Drawing.Point(12, 33);
            this.tabControl_Settings.Name = "tabControl_Settings";
            this.tabControl_Settings.SelectedIndex = 0;
            this.tabControl_Settings.Size = new System.Drawing.Size(360, 289);
            this.tabControl_Settings.TabIndex = 2;
            // 
            // tabPage_Tools
            // 
            this.tabPage_Tools.Controls.Add(this.button1);
            this.tabPage_Tools.Controls.Add(this.button_CardManager);
            this.tabPage_Tools.Controls.Add(this.button_card);
            this.tabPage_Tools.Controls.Add(this.button_Net_Fix);
            this.tabPage_Tools.Controls.Add(this.label6);
            this.tabPage_Tools.Controls.Add(this.button_res);
            this.tabPage_Tools.Controls.Add(this.label5);
            this.tabPage_Tools.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Tools.Name = "tabPage_Tools";
            this.tabPage_Tools.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Tools.Size = new System.Drawing.Size(352, 256);
            this.tabPage_Tools.TabIndex = 0;
            this.tabPage_Tools.Text = "实用工具";
            this.tabPage_Tools.UseVisualStyleBackColor = true;
            // 
            // button_CardManager
            // 
            this.button_CardManager.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_CardManager.Location = new System.Drawing.Point(177, 67);
            this.button_CardManager.Name = "button_CardManager";
            this.button_CardManager.Size = new System.Drawing.Size(169, 30);
            this.button_CardManager.TabIndex = 5;
            this.button_CardManager.Text = "游戏卡片管理";
            this.button_CardManager.UseVisualStyleBackColor = true;
            this.button_CardManager.Click += new System.EventHandler(this.button_CardManager_Click);
            // 
            // button_card
            // 
            this.button_card.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_card.Location = new System.Drawing.Point(6, 67);
            this.button_card.Name = "button_card";
            this.button_card.Size = new System.Drawing.Size(169, 30);
            this.button_card.TabIndex = 4;
            this.button_card.Text = "游戏刷卡键修改";
            this.button_card.UseVisualStyleBackColor = true;
            this.button_card.Click += new System.EventHandler(this.button_card_Click);
            // 
            // button_Net_Fix
            // 
            this.button_Net_Fix.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Net_Fix.Location = new System.Drawing.Point(180, 31);
            this.button_Net_Fix.Name = "button_Net_Fix";
            this.button_Net_Fix.Size = new System.Drawing.Size(169, 30);
            this.button_Net_Fix.TabIndex = 3;
            this.button_Net_Fix.Text = "游戏网络修复";
            this.button_Net_Fix.UseVisualStyleBackColor = true;
            this.button_Net_Fix.Click += new System.EventHandler(this.button_Net_Fix_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 2;
            // 
            // button_res
            // 
            this.button_res.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_res.Location = new System.Drawing.Point(6, 31);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(169, 30);
            this.button_res.TabIndex = 1;
            this.button_res.Text = "游戏分辨率修改";
            this.button_res.UseVisualStyleBackColor = true;
            this.button_res.Click += new System.EventHandler(this.button_res_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(1, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "常用工具";
            // 
            // tabPage_Maxi
            // 
            this.tabPage_Maxi.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Maxi.Name = "tabPage_Maxi";
            this.tabPage_Maxi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Maxi.Size = new System.Drawing.Size(352, 230);
            this.tabPage_Maxi.TabIndex = 1;
            this.tabPage_Maxi.Text = "MaxiTerminal配置";
            this.tabPage_Maxi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(6, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "服务器IP切换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.tabControl_Settings);
            this.Controls.Add(this.tabControl_Game);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 609);
            this.MinimumSize = new System.Drawing.Size(402, 609);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMMT Toolbox";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl_Game.ResumeLayout(false);
            this.tabPage_Main.ResumeLayout(false);
            this.tabPage_Main.PerformLayout();
            this.tabPage_gp_Setting.ResumeLayout(false);
            this.tabPage_gp_Setting.PerformLayout();
            this.tabControl_Settings.ResumeLayout(false);
            this.tabPage_Tools.ResumeLayout(false);
            this.tabPage_Tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_Game;
        private System.Windows.Forms.TabPage tabPage_Main;
        private System.Windows.Forms.Button button_Start_Game;
        private System.Windows.Forms.TabPage tabPage_gp_Setting;
        private System.Windows.Forms.TabControl tabControl_Settings;
        private System.Windows.Forms.TabPage tabPage_Tools;
        private System.Windows.Forms.TabPage tabPage_Maxi;
        private System.Windows.Forms.Button button_TP_Select;
        private System.Windows.Forms.Button button_AMA_Select;
        private System.Windows.Forms.Button button_Maxi_Select;
        private System.Windows.Forms.TextBox textBox_TP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AMA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Maxi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Create_Ink;
        private System.Windows.Forms.CheckBox checkBox_direct_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Maxi_Start;
        private System.Windows.Forms.CheckBox checkBox_AMA_Start;
        private System.Windows.Forms.CheckBox checkBox_TP_Start;
        private System.Windows.Forms.Button button_card;
        private System.Windows.Forms.Button button_Net_Fix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem About_ME_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Server_ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_Terminal_Mode;
        private System.Windows.Forms.ToolStripMenuItem About_Box_ToolStripMenuItem;
        private System.Windows.Forms.Button button_CardManager;
        private System.Windows.Forms.ComboBox comboBox_Cards;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

