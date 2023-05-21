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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_RES = new System.Windows.Forms.ComboBox();
            this.button_RES_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择分辨率并点击修改即可";
            // 
            // comboBox_RES
            // 
            this.comboBox_RES.FormattingEnabled = true;
            this.comboBox_RES.Items.AddRange(new object[] {
            "1366 x 768（原版分辨率）",
            "1600 x 900（900P）",
            "1920 x 1080（1080P）",
            "2448 x 1373（2K窗体非全屏）",
            "2560 x 1080（1080P宽屏）",
            "2560 x 1440（2K全屏）",
            "3440 x 1440（2K宽屏）"});
            this.comboBox_RES.Location = new System.Drawing.Point(12, 32);
            this.comboBox_RES.Name = "comboBox_RES";
            this.comboBox_RES.Size = new System.Drawing.Size(245, 28);
            this.comboBox_RES.TabIndex = 1;
            this.comboBox_RES.Text = "请选择一个分辨率";
            // 
            // button_RES_edit
            // 
            this.button_RES_edit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_RES_edit.Location = new System.Drawing.Point(12, 67);
            this.button_RES_edit.Name = "button_RES_edit";
            this.button_RES_edit.Size = new System.Drawing.Size(245, 42);
            this.button_RES_edit.TabIndex = 2;
            this.button_RES_edit.Text = "修改";
            this.button_RES_edit.UseVisualStyleBackColor = true;
            this.button_RES_edit.Click += new System.EventHandler(this.button_RES_edit_Click);
            // 
            // Form_RES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 121);
            this.Controls.Add(this.button_RES_edit);
            this.Controls.Add(this.comboBox_RES);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(287, 168);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(287, 168);
            this.Name = "Form_RES";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "游戏内分辨率修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_RES;
        private System.Windows.Forms.Button button_RES_edit;
    }
}