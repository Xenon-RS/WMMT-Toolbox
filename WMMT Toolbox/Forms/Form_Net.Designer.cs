namespace WMMT_Toolbox
{
    partial class Form_Net
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_gateway = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ipv4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_fix_net = new System.Windows.Forms.Button();
            this.button_net_fix_tp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "游戏网络设置/修复";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "自动获取的当前网络的信息\r\n（若不正确可自行修改）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "默认网关";
            // 
            // textBox_gateway
            // 
            this.textBox_gateway.Location = new System.Drawing.Point(12, 109);
            this.textBox_gateway.Name = "textBox_gateway";
            this.textBox_gateway.Size = new System.Drawing.Size(191, 27);
            this.textBox_gateway.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "IPv4地址";
            // 
            // textBox_ipv4
            // 
            this.textBox_ipv4.Location = new System.Drawing.Point(12, 163);
            this.textBox_ipv4.Name = "textBox_ipv4";
            this.textBox_ipv4.Size = new System.Drawing.Size(191, 27);
            this.textBox_ipv4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "游戏服务器地址";
            // 
            // textBox_server
            // 
            this.textBox_server.Location = new System.Drawing.Point(12, 217);
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.Size = new System.Drawing.Size(191, 27);
            this.textBox_server.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 8;
            // 
            // button_fix_net
            // 
            this.button_fix_net.AutoSize = true;
            this.button_fix_net.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_fix_net.Location = new System.Drawing.Point(12, 256);
            this.button_fix_net.MaximumSize = new System.Drawing.Size(191, 48);
            this.button_fix_net.MinimumSize = new System.Drawing.Size(191, 48);
            this.button_fix_net.Name = "button_fix_net";
            this.button_fix_net.Size = new System.Drawing.Size(191, 48);
            this.button_fix_net.TabIndex = 9;
            this.button_fix_net.Text = "一键设置/修复网络";
            this.button_fix_net.UseVisualStyleBackColor = true;
            this.button_fix_net.Click += new System.EventHandler(this.button_fix_net_Click);
            // 
            // button_net_fix_tp
            // 
            this.button_net_fix_tp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_net_fix_tp.Location = new System.Drawing.Point(12, 311);
            this.button_net_fix_tp.MaximumSize = new System.Drawing.Size(191, 60);
            this.button_net_fix_tp.MinimumSize = new System.Drawing.Size(191, 60);
            this.button_net_fix_tp.Name = "button_net_fix_tp";
            this.button_net_fix_tp.Size = new System.Drawing.Size(191, 60);
            this.button_net_fix_tp.TabIndex = 12;
            this.button_net_fix_tp.Text = "一键设置/修复\r\n鹦鹉模拟器网络配置";
            this.button_net_fix_tp.UseVisualStyleBackColor = true;
            this.button_net_fix_tp.Click += new System.EventHandler(this.button_net_fix_tp_Click);
            // 
            // Form_Net
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 384);
            this.Controls.Add(this.button_net_fix_tp);
            this.Controls.Add(this.button_fix_net);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_server);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ipv4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_gateway);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(233, 431);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(233, 431);
            this.Name = "Form_Net";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "游戏网络设置/修复";
            this.Load += new System.EventHandler(this.Form_Net_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_gateway;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ipv4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_fix_net;
        private System.Windows.Forms.Button button_net_fix_tp;
    }
}