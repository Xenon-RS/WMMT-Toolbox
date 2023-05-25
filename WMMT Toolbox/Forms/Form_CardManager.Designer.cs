namespace WMMT_Toolbox.Forms
{
    partial class Form_CardManager
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
            this.listBox_Cards = new System.Windows.Forms.ListBox();
            this.button_Add_Card = new System.Windows.Forms.Button();
            this.button_Delete_Card = new System.Windows.Forms.Button();
            this.button_Card_CustomName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "您可以在此添加您的游戏卡片\r\n并且允许您在主界面快速切换使用";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "卡片列表";
            // 
            // listBox_Cards
            // 
            this.listBox_Cards.FormattingEnabled = true;
            this.listBox_Cards.ItemHeight = 20;
            this.listBox_Cards.Location = new System.Drawing.Point(12, 83);
            this.listBox_Cards.Name = "listBox_Cards";
            this.listBox_Cards.Size = new System.Drawing.Size(169, 204);
            this.listBox_Cards.TabIndex = 2;
            // 
            // button_Add_Card
            // 
            this.button_Add_Card.Location = new System.Drawing.Point(187, 83);
            this.button_Add_Card.Name = "button_Add_Card";
            this.button_Add_Card.Size = new System.Drawing.Size(78, 39);
            this.button_Add_Card.TabIndex = 3;
            this.button_Add_Card.Text = "添加卡片";
            this.button_Add_Card.UseVisualStyleBackColor = true;
            this.button_Add_Card.Click += new System.EventHandler(this.button_Add_Card_Click);
            // 
            // button_Delete_Card
            // 
            this.button_Delete_Card.Location = new System.Drawing.Point(187, 128);
            this.button_Delete_Card.Name = "button_Delete_Card";
            this.button_Delete_Card.Size = new System.Drawing.Size(78, 39);
            this.button_Delete_Card.TabIndex = 4;
            this.button_Delete_Card.Text = "删除卡片";
            this.button_Delete_Card.UseVisualStyleBackColor = true;
            this.button_Delete_Card.Click += new System.EventHandler(this.button_Delete_Card_Click);
            // 
            // button_Card_CustomName
            // 
            this.button_Card_CustomName.Location = new System.Drawing.Point(187, 173);
            this.button_Card_CustomName.Name = "button_Card_CustomName";
            this.button_Card_CustomName.Size = new System.Drawing.Size(78, 39);
            this.button_Card_CustomName.TabIndex = 5;
            this.button_Card_CustomName.Text = "备注卡片";
            this.button_Card_CustomName.UseVisualStyleBackColor = true;
            this.button_Card_CustomName.Click += new System.EventHandler(this.button_Card_CustomName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "删除/备注功能需要您先选择一个卡片";
            // 
            // Form_CardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Card_CustomName);
            this.Controls.Add(this.button_Delete_Card);
            this.Controls.Add(this.button_Add_Card);
            this.Controls.Add(this.listBox_Cards);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(291, 365);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(291, 365);
            this.Name = "Form_CardManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "游戏卡片管理";
            this.Load += new System.EventHandler(this.Form_CardManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Cards;
        private System.Windows.Forms.Button button_Add_Card;
        private System.Windows.Forms.Button button_Delete_Card;
        private System.Windows.Forms.Button button_Card_CustomName;
        private System.Windows.Forms.Label label3;
    }
}