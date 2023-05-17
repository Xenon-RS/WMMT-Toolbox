namespace WMMT_Toolbox.Forms
{
    partial class Form_Server
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
            this.linkLabel_OLG = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_KS = new System.Windows.Forms.LinkLabel();
            this.label22 = new System.Windows.Forms.Label();
            this.linkLabel_JS = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "友情服务器列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "OLG服（主打自由为主）";
            // 
            // linkLabel_OLG
            // 
            this.linkLabel_OLG.AutoSize = true;
            this.linkLabel_OLG.Location = new System.Drawing.Point(14, 74);
            this.linkLabel_OLG.Name = "linkLabel_OLG";
            this.linkLabel_OLG.Size = new System.Drawing.Size(264, 20);
            this.linkLabel_OLG.TabIndex = 2;
            this.linkLabel_OLG.TabStop = true;
            this.linkLabel_OLG.Text = "QQ群：756445021（点击即可加入）";
            this.linkLabel_OLG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_OLG_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "KS服（主打活动多为主）";
            // 
            // linkLabel_KS
            // 
            this.linkLabel_KS.AutoSize = true;
            this.linkLabel_KS.Location = new System.Drawing.Point(14, 123);
            this.linkLabel_KS.Name = "linkLabel_KS";
            this.linkLabel_KS.Size = new System.Drawing.Size(144, 20);
            this.linkLabel_KS.TabIndex = 4;
            this.linkLabel_KS.TabStop = true;
            this.linkLabel_KS.Text = "QQ群：651521577";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(14, 153);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(197, 19);
            this.label22.TabIndex = 5;
            this.label22.Text = "JS服（主打OCM技术为主）";
            // 
            // linkLabel_JS
            // 
            this.linkLabel_JS.AutoSize = true;
            this.linkLabel_JS.Location = new System.Drawing.Point(14, 172);
            this.linkLabel_JS.Name = "linkLabel_JS";
            this.linkLabel_JS.Size = new System.Drawing.Size(144, 20);
            this.linkLabel_JS.TabIndex = 6;
            this.linkLabel_JS.TabStop = true;
            this.linkLabel_JS.Text = "QQ群：599208776";
            // 
            // Form_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 206);
            this.Controls.Add(this.linkLabel_JS);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.linkLabel_KS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel_OLG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 253);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 253);
            this.Name = "Form_Server";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "友情服务器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_OLG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel_KS;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.LinkLabel linkLabel_JS;
    }
}