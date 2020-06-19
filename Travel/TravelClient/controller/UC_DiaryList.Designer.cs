namespace TravelClient.controller
{
    partial class UC_DiaryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DiaryList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddDiary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDiaryList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddDiary);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 115);
            this.panel1.TabIndex = 0;
            // 
            // btnAddDiary
            // 
            this.btnAddDiary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.btnAddDiary.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddDiary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddDiary.Location = new System.Drawing.Point(676, 50);
            this.btnAddDiary.Name = "btnAddDiary";
            this.btnAddDiary.Size = new System.Drawing.Size(115, 44);
            this.btnAddDiary.TabIndex = 4;
            this.btnAddDiary.Text = "添加日志";
            this.btnAddDiary.UseVisualStyleBackColor = false;
            this.btnAddDiary.Click += new System.EventHandler(this.BtnAddDiary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(124, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "旅行日志";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 67);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelDiaryList
            // 
            this.panelDiaryList.AutoScroll = true;
            this.panelDiaryList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelDiaryList.Location = new System.Drawing.Point(0, 121);
            this.panelDiaryList.Name = "panelDiaryList";
            this.panelDiaryList.Size = new System.Drawing.Size(840, 626);
            this.panelDiaryList.TabIndex = 1;
            // 
            // UC_DiaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDiaryList);
            this.Controls.Add(this.panel1);
            this.Name = "UC_DiaryList";
            this.Size = new System.Drawing.Size(840, 750);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddDiary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelDiaryList;
    }
}
