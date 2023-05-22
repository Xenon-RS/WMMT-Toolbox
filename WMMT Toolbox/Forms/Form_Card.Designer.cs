namespace WMMT_Toolbox.Forms
{
    partial class Form_Card
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
            this.comboBox_card_type = new System.Windows.Forms.ComboBox();
            this.button_Card_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "该功能用于修改刷卡按键\r\n选择按键并点击修改即可";
            // 
            // comboBox_card_type
            // 
            this.comboBox_card_type.FormattingEnabled = true;
            this.comboBox_card_type.Items.AddRange(new object[] {
            "Backspace（退格删除键）",
            "Ctrl",
            "Delete",
            "Enter（回车）",
            "Home",
            "小键盘 0键",
            "鼠标 左键",
            "鼠标 中键",
            "鼠标 右键",
            "Shift",
            "SpaceBar（空格键）"});
            this.comboBox_card_type.Location = new System.Drawing.Point(12, 52);
            this.comboBox_card_type.Name = "comboBox_card_type";
            this.comboBox_card_type.Size = new System.Drawing.Size(215, 28);
            this.comboBox_card_type.TabIndex = 1;
            // 
            // button_Card_Edit
            // 
            this.button_Card_Edit.Location = new System.Drawing.Point(13, 87);
            this.button_Card_Edit.Name = "button_Card_Edit";
            this.button_Card_Edit.Size = new System.Drawing.Size(214, 45);
            this.button_Card_Edit.TabIndex = 2;
            this.button_Card_Edit.Text = "修改";
            this.button_Card_Edit.UseVisualStyleBackColor = true;
            this.button_Card_Edit.Click += new System.EventHandler(this.button_Card_Edit_Click);
            // 
            // Form_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 144);
            this.Controls.Add(this.button_Card_Edit);
            this.Controls.Add(this.comboBox_card_type);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(257, 191);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(257, 191);
            this.Name = "Form_Card";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "刷卡键修改";
            this.Load += new System.EventHandler(this.Form_Card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_card_type;
        private System.Windows.Forms.Button button_Card_Edit;
    }
}