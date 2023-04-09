namespace WMMT_Toolbox
{
    partial class Form_About
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Name_2 = new System.Windows.Forms.Label();
            this.label_Contect = new System.Windows.Forms.Label();
            this.linkLabel_GitHub = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Bilibili = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_OLG = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WMMT_Toolbox.Properties.Resources._114514;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Name.Location = new System.Drawing.Point(140, 12);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(120, 40);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "@kKsk";
            // 
            // label_Name_2
            // 
            this.label_Name_2.AutoSize = true;
            this.label_Name_2.Location = new System.Drawing.Point(143, 52);
            this.label_Name_2.Name = "label_Name_2";
            this.label_Name_2.Size = new System.Drawing.Size(153, 20);
            this.label_Name_2.TabIndex = 2;
            this.label_Name_2.Text = "一个一个一个湾岸菜B";
            // 
            // label_Contect
            // 
            this.label_Contect.AutoSize = true;
            this.label_Contect.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Contect.Location = new System.Drawing.Point(13, 141);
            this.label_Contect.Name = "label_Contect";
            this.label_Contect.Size = new System.Drawing.Size(106, 31);
            this.label_Contect.TabIndex = 3;
            this.label_Contect.Text = "联系我？";
            // 
            // linkLabel_GitHub
            // 
            this.linkLabel_GitHub.AutoSize = true;
            this.linkLabel_GitHub.Location = new System.Drawing.Point(15, 172);
            this.linkLabel_GitHub.Name = "linkLabel_GitHub";
            this.linkLabel_GitHub.Size = new System.Drawing.Size(121, 20);
            this.linkLabel_GitHub.TabIndex = 4;
            this.linkLabel_GitHub.TabStop = true;
            this.linkLabel_GitHub.Text = "GitHub个人主页";
            this.linkLabel_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GitHub_LinkClicked);
            // 
            // linkLabel_Bilibili
            // 
            this.linkLabel_Bilibili.AutoSize = true;
            this.linkLabel_Bilibili.Location = new System.Drawing.Point(15, 192);
            this.linkLabel_Bilibili.Name = "linkLabel_Bilibili";
            this.linkLabel_Bilibili.Size = new System.Drawing.Size(112, 20);
            this.linkLabel_Bilibili.TabIndex = 5;
            this.linkLabel_Bilibili.TabStop = true;
            this.linkLabel_Bilibili.Text = "Bilibili个人主页";
            this.linkLabel_Bilibili.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Bilibili_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "友情链接";
            // 
            // linkLabel_OLG
            // 
            this.linkLabel_OLG.AutoSize = true;
            this.linkLabel_OLG.Location = new System.Drawing.Point(15, 262);
            this.linkLabel_OLG.Name = "linkLabel_OLG";
            this.linkLabel_OLG.Size = new System.Drawing.Size(188, 20);
            this.linkLabel_OLG.TabIndex = 7;
            this.linkLabel_OLG.TabStop = true;
            this.linkLabel_OLG.Text = "OLG WMMT游戏服务器群";
            this.linkLabel_OLG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_OLG_LinkClicked);
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 297);
            this.Controls.Add(this.linkLabel_OLG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_Bilibili);
            this.Controls.Add(this.linkLabel_GitHub);
            this.Controls.Add(this.label_Contect);
            this.Controls.Add(this.label_Name_2);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 344);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 344);
            this.Name = "Form_About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于开发者";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Name_2;
        private System.Windows.Forms.Label label_Contect;
        private System.Windows.Forms.LinkLabel linkLabel_GitHub;
        private System.Windows.Forms.LinkLabel linkLabel_Bilibili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_OLG;
    }
}