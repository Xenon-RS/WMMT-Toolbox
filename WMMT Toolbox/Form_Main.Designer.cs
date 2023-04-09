namespace WMMT_Toolbox
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Tool_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Net_fix_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.res_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.card_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fixer_Normal_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxiTerminal_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teknoParrot_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developer_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_game_start = new System.Windows.Forms.Button();
            this.checkBox_maxi = new System.Windows.Forms.CheckBox();
            this.checkBox_AMA = new System.Windows.Forms.CheckBox();
            this.checkBox_TP = new System.Windows.Forms.CheckBox();
            this.checkBox_autostart = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_path_setting = new System.Windows.Forms.Button();
            this.button_Net = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Path_Maxi = new System.Windows.Forms.Label();
            this.Path_AMA = new System.Windows.Forms.Label();
            this.Path_TP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_bug_fixer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_Terminal = new System.Windows.Forms.CheckBox();
            this.button_res = new System.Windows.Forms.Button();
            this.button_card = new System.Windows.Forms.Button();
            this.About_Software_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_ToolStripMenuItem,
            this.Setting_ToolStripMenuItem,
            this.About_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Tool_ToolStripMenuItem
            // 
            this.Tool_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Net_fix_ToolStripMenuItem,
            this.res_ToolStripMenuItem,
            this.card_ToolStripMenuItem,
            this.Fixer_Normal_ToolStripMenuItem});
            this.Tool_ToolStripMenuItem.Name = "Tool_ToolStripMenuItem";
            this.Tool_ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.Tool_ToolStripMenuItem.Text = "工具";
            // 
            // Net_fix_ToolStripMenuItem
            // 
            this.Net_fix_ToolStripMenuItem.Name = "Net_fix_ToolStripMenuItem";
            this.Net_fix_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Net_fix_ToolStripMenuItem.Text = "网络修复工具";
            this.Net_fix_ToolStripMenuItem.Click += new System.EventHandler(this.Net_fix_ToolStripMenuItem_Click);
            // 
            // res_ToolStripMenuItem
            // 
            this.res_ToolStripMenuItem.Name = "res_ToolStripMenuItem";
            this.res_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.res_ToolStripMenuItem.Text = "分辨率修改";
            this.res_ToolStripMenuItem.Click += new System.EventHandler(this.res_ToolStripMenuItem_Click);
            // 
            // card_ToolStripMenuItem
            // 
            this.card_ToolStripMenuItem.Name = "card_ToolStripMenuItem";
            this.card_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.card_ToolStripMenuItem.Text = "刷卡键修改";
            this.card_ToolStripMenuItem.Click += new System.EventHandler(this.card_ToolStripMenuItem_Click);
            // 
            // Fixer_Normal_ToolStripMenuItem
            // 
            this.Fixer_Normal_ToolStripMenuItem.Name = "Fixer_Normal_ToolStripMenuItem";
            this.Fixer_Normal_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Fixer_Normal_ToolStripMenuItem.Text = "常见问题修复工具";
            this.Fixer_Normal_ToolStripMenuItem.Click += new System.EventHandler(this.Fixer_Normal_ToolStripMenuItem_Click);
            // 
            // Setting_ToolStripMenuItem
            // 
            this.Setting_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxiTerminal_ToolStripMenuItem,
            this.teknoParrot_ToolStripMenuItem});
            this.Setting_ToolStripMenuItem.Name = "Setting_ToolStripMenuItem";
            this.Setting_ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.Setting_ToolStripMenuItem.Text = "设置";
            // 
            // maxiTerminal_ToolStripMenuItem
            // 
            this.maxiTerminal_ToolStripMenuItem.Name = "maxiTerminal_ToolStripMenuItem";
            this.maxiTerminal_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.maxiTerminal_ToolStripMenuItem.Text = "Maxi Terminal设置";
            this.maxiTerminal_ToolStripMenuItem.Click += new System.EventHandler(this.maxiTerminal_ToolStripMenuItem_Click);
            // 
            // teknoParrot_ToolStripMenuItem
            // 
            this.teknoParrot_ToolStripMenuItem.Name = "teknoParrot_ToolStripMenuItem";
            this.teknoParrot_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.teknoParrot_ToolStripMenuItem.Text = "TeknoParrot设置";
            this.teknoParrot_ToolStripMenuItem.Click += new System.EventHandler(this.teknoParrot_ToolStripMenuItem_Click);
            // 
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developer_ToolStripMenuItem,
            this.About_Software_ToolStripMenuItem});
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.About_ToolStripMenuItem.Text = "关于";
            this.About_ToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // developer_ToolStripMenuItem
            // 
            this.developer_ToolStripMenuItem.Name = "developer_ToolStripMenuItem";
            this.developer_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.developer_ToolStripMenuItem.Text = "关于开发者";
            this.developer_ToolStripMenuItem.Click += new System.EventHandler(this.developer_ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "WMMT Toolbox  ——————————\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "游戏启动";
            // 
            // button_game_start
            // 
            this.button_game_start.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_game_start.Location = new System.Drawing.Point(21, 110);
            this.button_game_start.Name = "button_game_start";
            this.button_game_start.Size = new System.Drawing.Size(187, 144);
            this.button_game_start.TabIndex = 3;
            this.button_game_start.Text = "启动游戏";
            this.button_game_start.UseVisualStyleBackColor = true;
            this.button_game_start.Click += new System.EventHandler(this.button_game_start_Click);
            // 
            // checkBox_maxi
            // 
            this.checkBox_maxi.AutoSize = true;
            this.checkBox_maxi.Checked = true;
            this.checkBox_maxi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_maxi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_maxi.Location = new System.Drawing.Point(215, 110);
            this.checkBox_maxi.Name = "checkBox_maxi";
            this.checkBox_maxi.Size = new System.Drawing.Size(268, 24);
            this.checkBox_maxi.TabIndex = 4;
            this.checkBox_maxi.Text = "启动Maxi Terminal（湾岸终端机）";
            this.checkBox_maxi.UseVisualStyleBackColor = true;
            this.checkBox_maxi.CheckedChanged += new System.EventHandler(this.checkBox_maxi_CheckedChanged);
            // 
            // checkBox_AMA
            // 
            this.checkBox_AMA.AutoSize = true;
            this.checkBox_AMA.Checked = true;
            this.checkBox_AMA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AMA.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_AMA.Location = new System.Drawing.Point(215, 140);
            this.checkBox_AMA.Name = "checkBox_AMA";
            this.checkBox_AMA.Size = new System.Drawing.Size(252, 24);
            this.checkBox_AMA.TabIndex = 5;
            this.checkBox_AMA.Text = "启动AMAuthd.exe（游戏联网）";
            this.checkBox_AMA.UseVisualStyleBackColor = true;
            this.checkBox_AMA.CheckedChanged += new System.EventHandler(this.checkBox_AMA_CheckedChanged);
            // 
            // checkBox_TP
            // 
            this.checkBox_TP.AutoSize = true;
            this.checkBox_TP.Checked = true;
            this.checkBox_TP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_TP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_TP.Location = new System.Drawing.Point(215, 170);
            this.checkBox_TP.Name = "checkBox_TP";
            this.checkBox_TP.Size = new System.Drawing.Size(286, 24);
            this.checkBox_TP.TabIndex = 6;
            this.checkBox_TP.Text = "启动TeknoParrot（鹦鹉游戏模拟器）";
            this.checkBox_TP.UseVisualStyleBackColor = true;
            this.checkBox_TP.CheckedChanged += new System.EventHandler(this.checkBox_TP_CheckedChanged);
            // 
            // checkBox_autostart
            // 
            this.checkBox_autostart.AutoSize = true;
            this.checkBox_autostart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_autostart.Location = new System.Drawing.Point(214, 200);
            this.checkBox_autostart.Name = "checkBox_autostart";
            this.checkBox_autostart.Size = new System.Drawing.Size(391, 24);
            this.checkBox_autostart.TabIndex = 7;
            this.checkBox_autostart.Text = "自动启动游戏（将按照上方三个按钮的设定进行加载）";
            this.checkBox_autostart.UseVisualStyleBackColor = true;
            this.checkBox_autostart.CheckedChanged += new System.EventHandler(this.checkBox_autostart_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "设置";
            // 
            // button_path_setting
            // 
            this.button_path_setting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_path_setting.Location = new System.Drawing.Point(21, 411);
            this.button_path_setting.Name = "button_path_setting";
            this.button_path_setting.Size = new System.Drawing.Size(187, 36);
            this.button_path_setting.TabIndex = 9;
            this.button_path_setting.Text = "启动路径设置";
            this.button_path_setting.UseVisualStyleBackColor = true;
            this.button_path_setting.Click += new System.EventHandler(this.button_path_setting_Click);
            // 
            // button_Net
            // 
            this.button_Net.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Net.Location = new System.Drawing.Point(21, 453);
            this.button_Net.Name = "button_Net";
            this.button_Net.Size = new System.Drawing.Size(186, 36);
            this.button_Net.TabIndex = 10;
            this.button_Net.Text = "游戏网络设定 / 修复";
            this.button_Net.UseVisualStyleBackColor = true;
            this.button_Net.Click += new System.EventHandler(this.button_Net_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "当前游戏启动路径";
            // 
            // Path_Maxi
            // 
            this.Path_Maxi.AutoSize = true;
            this.Path_Maxi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Path_Maxi.Location = new System.Drawing.Point(141, 288);
            this.Path_Maxi.Name = "Path_Maxi";
            this.Path_Maxi.Size = new System.Drawing.Size(99, 20);
            this.Path_Maxi.TabIndex = 12;
            this.Path_Maxi.Text = "请先设定路径";
            // 
            // Path_AMA
            // 
            this.Path_AMA.AutoSize = true;
            this.Path_AMA.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Path_AMA.Location = new System.Drawing.Point(141, 318);
            this.Path_AMA.Name = "Path_AMA";
            this.Path_AMA.Size = new System.Drawing.Size(99, 20);
            this.Path_AMA.TabIndex = 13;
            this.Path_AMA.Text = "请先设定路径";
            // 
            // Path_TP
            // 
            this.Path_TP.AutoSize = true;
            this.Path_TP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Path_TP.Location = new System.Drawing.Point(73, 347);
            this.Path_TP.Name = "Path_TP";
            this.Path_TP.Size = new System.Drawing.Size(99, 20);
            this.Path_TP.TabIndex = 14;
            this.Path_TP.Text = "请先设定路径";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(19, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "其他游戏工具";
            // 
            // button_bug_fixer
            // 
            this.button_bug_fixer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_bug_fixer.Location = new System.Drawing.Point(24, 536);
            this.button_bug_fixer.Name = "button_bug_fixer";
            this.button_bug_fixer.Size = new System.Drawing.Size(186, 36);
            this.button_bug_fixer.TabIndex = 16;
            this.button_bug_fixer.Text = "游戏补丁安装器";
            this.button_bug_fixer.UseVisualStyleBackColor = true;
            this.button_bug_fixer.Click += new System.EventHandler(this.button_bug_fixer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(20, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Maxi Terminal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(21, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "AMAuthd.exe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(21, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "TPUI:";
            // 
            // checkBox_Terminal
            // 
            this.checkBox_Terminal.AutoSize = true;
            this.checkBox_Terminal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Terminal.Location = new System.Drawing.Point(214, 230);
            this.checkBox_Terminal.Name = "checkBox_Terminal";
            this.checkBox_Terminal.Size = new System.Drawing.Size(136, 24);
            this.checkBox_Terminal.TabIndex = 21;
            this.checkBox_Terminal.Text = "湾岸终端机模式";
            this.checkBox_Terminal.UseVisualStyleBackColor = true;
            this.checkBox_Terminal.CheckedChanged += new System.EventHandler(this.checkBox_Terminal_CheckedChanged);
            // 
            // button_res
            // 
            this.button_res.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_res.Location = new System.Drawing.Point(214, 411);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(187, 36);
            this.button_res.TabIndex = 22;
            this.button_res.Text = "游戏分辨率修改";
            this.button_res.UseVisualStyleBackColor = true;
            this.button_res.Click += new System.EventHandler(this.button_res_Click);
            // 
            // button_card
            // 
            this.button_card.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_card.Location = new System.Drawing.Point(215, 453);
            this.button_card.Name = "button_card";
            this.button_card.Size = new System.Drawing.Size(186, 36);
            this.button_card.TabIndex = 23;
            this.button_card.Text = "刷卡键修改";
            this.button_card.UseVisualStyleBackColor = true;
            // 
            // About_Software_ToolStripMenuItem
            // 
            this.About_Software_ToolStripMenuItem.Name = "About_Software_ToolStripMenuItem";
            this.About_Software_ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.About_Software_ToolStripMenuItem.Text = "关于工具箱";
            this.About_Software_ToolStripMenuItem.Click += new System.EventHandler(this.About_Software_ToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 591);
            this.Controls.Add(this.button_card);
            this.Controls.Add(this.button_res);
            this.Controls.Add(this.checkBox_Terminal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_bug_fixer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Path_TP);
            this.Controls.Add(this.Path_AMA);
            this.Controls.Add(this.Path_Maxi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Net);
            this.Controls.Add(this.button_path_setting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_autostart);
            this.Controls.Add(this.checkBox_TP);
            this.Controls.Add(this.checkBox_AMA);
            this.Controls.Add(this.checkBox_maxi);
            this.Controls.Add(this.button_game_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMMT Toolbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Tool_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Net_fix_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Setting_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxiTerminal_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teknoParrot_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developer_ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem res_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem card_ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_game_start;
        private System.Windows.Forms.CheckBox checkBox_maxi;
        private System.Windows.Forms.CheckBox checkBox_AMA;
        private System.Windows.Forms.CheckBox checkBox_TP;
        private System.Windows.Forms.CheckBox checkBox_autostart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_path_setting;
        private System.Windows.Forms.Button button_Net;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Path_Maxi;
        private System.Windows.Forms.Label Path_AMA;
        private System.Windows.Forms.Label Path_TP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_bug_fixer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_Terminal;
        private System.Windows.Forms.ToolStripMenuItem Fixer_Normal_ToolStripMenuItem;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Button button_card;
        private System.Windows.Forms.ToolStripMenuItem About_Software_ToolStripMenuItem;
    }
}

