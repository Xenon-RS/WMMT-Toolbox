namespace WMMT_Toolbox.Forms
{
    partial class Form_Net_Fix
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
            this.textBox_ipv4 = new System.Windows.Forms.TextBox();
            this.textBox_gateway = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Net_Fix = new System.Windows.Forms.Button();
            this.button_TP_Fix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前网络状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "注意：只支持单网络使用，不支持多网络使用\r\n请确保您只连接了一个网络后再使用本功能";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "IPv4地址";
            // 
            // textBox_ipv4
            // 
            this.textBox_ipv4.Location = new System.Drawing.Point(12, 108);
            this.textBox_ipv4.Name = "textBox_ipv4";
            this.textBox_ipv4.Size = new System.Drawing.Size(151, 27);
            this.textBox_ipv4.TabIndex = 3;
            // 
            // textBox_gateway
            // 
            this.textBox_gateway.Location = new System.Drawing.Point(173, 108);
            this.textBox_gateway.Name = "textBox_gateway";
            this.textBox_gateway.Size = new System.Drawing.Size(151, 27);
            this.textBox_gateway.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(169, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "默认网关地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "服务器IP";
            // 
            // textBox_Server
            // 
            this.textBox_Server.Location = new System.Drawing.Point(12, 160);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(151, 27);
            this.textBox_Server.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "网络修复";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 40);
            this.label7.TabIndex = 9;
            this.label7.Text = "当您确保当前网络并无异常则可直接一键修复\r\n该功能亦可用于服务器IP修改\r\n";
            // 
            // button_Net_Fix
            // 
            this.button_Net_Fix.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.button_Net_Fix.Location = new System.Drawing.Point(12, 277);
            this.button_Net_Fix.Name = "button_Net_Fix";
            this.button_Net_Fix.Size = new System.Drawing.Size(312, 49);
            this.button_Net_Fix.TabIndex = 10;
            this.button_Net_Fix.Text = "一键修复游戏网络";
            this.button_Net_Fix.UseVisualStyleBackColor = true;
            this.button_Net_Fix.Click += new System.EventHandler(this.button_Net_Fix_Click);
            // 
            // button_TP_Fix
            // 
            this.button_TP_Fix.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.button_TP_Fix.Location = new System.Drawing.Point(12, 332);
            this.button_TP_Fix.Name = "button_TP_Fix";
            this.button_TP_Fix.Size = new System.Drawing.Size(312, 50);
            this.button_TP_Fix.TabIndex = 11;
            this.button_TP_Fix.Text = "一键修复鹦鹉模拟器网络";
            this.button_TP_Fix.UseVisualStyleBackColor = true;
            this.button_TP_Fix.Click += new System.EventHandler(this.button_TP_Fix_Click);
            // 
            // Form_Net_Fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 393);
            this.Controls.Add(this.button_TP_Fix);
            this.Controls.Add(this.button_Net_Fix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Server);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_gateway);
            this.Controls.Add(this.textBox_ipv4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Net_Fix";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "游戏网络修复";
            this.Load += new System.EventHandler(this.Form_Net_Fix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ipv4;
        private System.Windows.Forms.TextBox textBox_gateway;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Net_Fix;
        private System.Windows.Forms.Button button_TP_Fix;
    }
}