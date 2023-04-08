namespace WMMT_Toolbox
{
    partial class Form_Path_Select
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
            this.textBox_Maxi = new System.Windows.Forms.TextBox();
            this.button_Maxi_select = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AMA = new System.Windows.Forms.TextBox();
            this.button_AMA_select = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TP = new System.Windows.Forms.TextBox();
            this.button_TP_select = new System.Windows.Forms.Button();
            this.button_into = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "请设置游戏所有运行时的路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maxi Terminal（湾岸终端机）的run.bat文件地址";
            // 
            // textBox_Maxi
            // 
            this.textBox_Maxi.Location = new System.Drawing.Point(17, 60);
            this.textBox_Maxi.Name = "textBox_Maxi";
            this.textBox_Maxi.ReadOnly = true;
            this.textBox_Maxi.Size = new System.Drawing.Size(482, 27);
            this.textBox_Maxi.TabIndex = 2;
            // 
            // button_Maxi_select
            // 
            this.button_Maxi_select.Location = new System.Drawing.Point(506, 60);
            this.button_Maxi_select.Name = "button_Maxi_select";
            this.button_Maxi_select.Size = new System.Drawing.Size(99, 27);
            this.button_Maxi_select.TabIndex = 3;
            this.button_Maxi_select.Text = "选择...";
            this.button_Maxi_select.UseVisualStyleBackColor = true;
            this.button_Maxi_select.Click += new System.EventHandler(this.button_Maxi_select_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "游戏本体内 WMMT6R\\AMCUS文件夹内的AMAuthd.exe文件";
            // 
            // textBox_AMA
            // 
            this.textBox_AMA.Location = new System.Drawing.Point(17, 114);
            this.textBox_AMA.Name = "textBox_AMA";
            this.textBox_AMA.ReadOnly = true;
            this.textBox_AMA.Size = new System.Drawing.Size(482, 27);
            this.textBox_AMA.TabIndex = 5;
            // 
            // button_AMA_select
            // 
            this.button_AMA_select.Location = new System.Drawing.Point(506, 114);
            this.button_AMA_select.Name = "button_AMA_select";
            this.button_AMA_select.Size = new System.Drawing.Size(99, 27);
            this.button_AMA_select.TabIndex = 6;
            this.button_AMA_select.Text = "选择...";
            this.button_AMA_select.UseVisualStyleBackColor = true;
            this.button_AMA_select.Click += new System.EventHandler(this.button_AMA_select_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TeknoParrot鹦鹉模拟器的TeknoParrotUi.exe文件地址";
            // 
            // textBox_TP
            // 
            this.textBox_TP.Location = new System.Drawing.Point(17, 168);
            this.textBox_TP.Name = "textBox_TP";
            this.textBox_TP.ReadOnly = true;
            this.textBox_TP.Size = new System.Drawing.Size(482, 27);
            this.textBox_TP.TabIndex = 8;
            // 
            // button_TP_select
            // 
            this.button_TP_select.Location = new System.Drawing.Point(506, 168);
            this.button_TP_select.Name = "button_TP_select";
            this.button_TP_select.Size = new System.Drawing.Size(99, 27);
            this.button_TP_select.TabIndex = 9;
            this.button_TP_select.Text = "选择...";
            this.button_TP_select.UseVisualStyleBackColor = true;
            this.button_TP_select.Click += new System.EventHandler(this.button_TP_select_Click);
            // 
            // button_into
            // 
            this.button_into.Location = new System.Drawing.Point(16, 210);
            this.button_into.Name = "button_into";
            this.button_into.Size = new System.Drawing.Size(589, 47);
            this.button_into.TabIndex = 10;
            this.button_into.Text = "关闭路径设置窗口";
            this.button_into.UseVisualStyleBackColor = true;
            this.button_into.Click += new System.EventHandler(this.button_into_Click);
            // 
            // Form_Path_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 273);
            this.Controls.Add(this.button_into);
            this.Controls.Add(this.button_TP_select);
            this.Controls.Add(this.textBox_TP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_AMA_select);
            this.Controls.Add(this.textBox_AMA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Maxi_select);
            this.Controls.Add(this.textBox_Maxi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 320);
            this.MinimumSize = new System.Drawing.Size(638, 320);
            this.Name = "Form_Path_Select";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "游戏路径设定";
            this.Load += new System.EventHandler(this.Form_Path_Select_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Maxi;
        private System.Windows.Forms.Button button_Maxi_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AMA;
        private System.Windows.Forms.Button button_AMA_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TP;
        private System.Windows.Forms.Button button_TP_select;
        private System.Windows.Forms.Button button_into;
    }
}