namespace TravelClient.controller
{
    partial class UC_Personalinfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(113, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(113, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "昵称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(113, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(113, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "介绍：";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("宋体", 15F);
            this.tbUserName.Location = new System.Drawing.Point(238, 154);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(274, 42);
            this.tbUserName.TabIndex = 1;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDescription.Location = new System.Drawing.Point(238, 334);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(451, 190);
            this.tbDescription.TabIndex = 1;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserId.Location = new System.Drawing.Point(322, 110);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 18);
            this.lblUserId.TabIndex = 0;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "男",
            "女",
            "未知"});
            this.cbGender.Location = new System.Drawing.Point(238, 235);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(274, 47);
            this.cbGender.TabIndex = 2;
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.btnCommit.ForeColor = System.Drawing.Color.Snow;
            this.btnCommit.Location = new System.Drawing.Point(335, 583);
            this.btnCommit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(165, 60);
            this.btnCommit.TabIndex = 3;
            this.btnCommit.Text = "确认修改";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.BtnCommit_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ID.Location = new System.Drawing.Point(235, 87);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(62, 18);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "label5";
            // 
            // UC_Personalinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Personalinfo";
            this.Size = new System.Drawing.Size(840, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label lbl_ID;
    }
}
