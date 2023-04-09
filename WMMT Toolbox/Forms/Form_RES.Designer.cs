namespace WMMT_Toolbox.Forms
{
    partial class Form_RES
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
            this.comboBox_ress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_res_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_ress
            // 
            this.comboBox_ress.FormattingEnabled = true;
            this.comboBox_ress.Items.AddRange(new object[] {
            "1366 x 768",
            "1600 x 900",
            "1920 x 1080",
            "2560 x 1440",
            "2448 x 1373",
            "3840 x 2160"});
            this.comboBox_ress.Location = new System.Drawing.Point(12, 80);
            this.comboBox_ress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_ress.Name = "comboBox_ress";
            this.comboBox_ress.Size = new System.Drawing.Size(259, 28);
            this.comboBox_ress.TabIndex = 0;
            this.comboBox_ress.Text = "请选择分辨率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "游戏分辨率修改";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "请先设置您想要更改的分辨率\r\n设置好后点击更改即可";
            // 
            // button_res_change
            // 
            this.button_res_change.Location = new System.Drawing.Point(12, 115);
            this.button_res_change.Name = "button_res_change";
            this.button_res_change.Size = new System.Drawing.Size(259, 38);
            this.button_res_change.TabIndex = 3;
            this.button_res_change.Text = "更改";
            this.button_res_change.UseVisualStyleBackColor = true;
            this.button_res_change.Click += new System.EventHandler(this.button_res_change_Click);
            // 
            // Form_RES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 166);
            this.Controls.Add(this.button_res_change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ress);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RES";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "游戏分辨率修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_res_change;
    }
}