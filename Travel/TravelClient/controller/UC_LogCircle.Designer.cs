namespace TravelClient.controller
{
    partial class UC_LogCircle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LogCircle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMyShare = new System.Windows.Forms.Button();
            this.btnLogCircle = new System.Windows.Forms.Button();
            this.panelLogList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(243, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "分享你的旅行日志！";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(120, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "日志圈";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMyShare);
            this.panel2.Controls.Add(this.btnLogCircle);
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 648);
            this.panel2.TabIndex = 1;
            // 
            // btnMyShare
            // 
            this.btnMyShare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMyShare.FlatAppearance.BorderSize = 0;
            this.btnMyShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyShare.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMyShare.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMyShare.Location = new System.Drawing.Point(3, 66);
            this.btnMyShare.Name = "btnMyShare";
            this.btnMyShare.Size = new System.Drawing.Size(150, 57);
            this.btnMyShare.TabIndex = 1;
            this.btnMyShare.Text = "我的发布";
            this.btnMyShare.UseVisualStyleBackColor = false;
            this.btnMyShare.Click += new System.EventHandler(this.BtnMyShare_Click);
            // 
            // btnLogCircle
            // 
            this.btnLogCircle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogCircle.FlatAppearance.BorderSize = 0;
            this.btnLogCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogCircle.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnLogCircle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogCircle.Location = new System.Drawing.Point(4, 3);
            this.btnLogCircle.Name = "btnLogCircle";
            this.btnLogCircle.Size = new System.Drawing.Size(150, 57);
            this.btnLogCircle.TabIndex = 0;
            this.btnLogCircle.Text = "日志圈";
            this.btnLogCircle.UseVisualStyleBackColor = false;
            this.btnLogCircle.Click += new System.EventHandler(this.BtnLogCircle_Click);
            // 
            // panelLogList
            // 
            this.panelLogList.AutoScroll = true;
            this.panelLogList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelLogList.Location = new System.Drawing.Point(157, 102);
            this.panelLogList.Name = "panelLogList";
            this.panelLogList.Size = new System.Drawing.Size(680, 645);
            this.panelLogList.TabIndex = 2;
            // 
            // UC_LogCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLogList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_LogCircle";
            this.Size = new System.Drawing.Size(840, 750);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMyShare;
        private System.Windows.Forms.Button btnLogCircle;
        private System.Windows.Forms.FlowLayoutPanel panelLogList;
    }
}
