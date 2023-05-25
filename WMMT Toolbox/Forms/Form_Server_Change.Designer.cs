namespace WMMT_Toolbox.Forms
{
    partial class Form_Server_Change
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
            this.textBox_ServerIP = new System.Windows.Forms.TextBox();
            this.button_Server_Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用提醒：\r\n仅限于修改Hosts中的IP地址使用";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "服务器IP";
            // 
            // textBox_ServerIP
            // 
            this.textBox_ServerIP.Location = new System.Drawing.Point(12, 89);
            this.textBox_ServerIP.Name = "textBox_ServerIP";
            this.textBox_ServerIP.Size = new System.Drawing.Size(225, 27);
            this.textBox_ServerIP.TabIndex = 2;
            // 
            // button_Server_Change
            // 
            this.button_Server_Change.Location = new System.Drawing.Point(12, 122);
            this.button_Server_Change.Name = "button_Server_Change";
            this.button_Server_Change.Size = new System.Drawing.Size(225, 38);
            this.button_Server_Change.TabIndex = 3;
            this.button_Server_Change.Text = "修改服务器IP";
            this.button_Server_Change.UseVisualStyleBackColor = true;
            this.button_Server_Change.Click += new System.EventHandler(this.button_Server_Change_Click);
            // 
            // Form_Server_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 174);
            this.Controls.Add(this.button_Server_Change);
            this.Controls.Add(this.textBox_ServerIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(269, 221);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(269, 221);
            this.Name = "Form_Server_Change";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器IP切换";
            this.Load += new System.EventHandler(this.Form_Server_Change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ServerIP;
        private System.Windows.Forms.Button button_Server_Change;
    }
}