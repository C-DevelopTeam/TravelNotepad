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
            this.btnAddDiary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDiaryList = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDiary
            // 
            this.btnAddDiary.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDiary.FlatAppearance.BorderSize = 0;
            this.btnAddDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiary.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddDiary.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddDiary.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDiary.Image")));
            this.btnAddDiary.Location = new System.Drawing.Point(747, 22);
            this.btnAddDiary.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDiary.Name = "btnAddDiary";
            this.btnAddDiary.Size = new System.Drawing.Size(63, 61);
            this.btnAddDiary.TabIndex = 4;
            this.btnAddDiary.UseVisualStyleBackColor = false;
            this.btnAddDiary.Click += new System.EventHandler(this.BtnAddDiary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "旅行日志";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelDiaryList
            // 
            this.panelDiaryList.AutoScroll = true;
            this.panelDiaryList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelDiaryList.Location = new System.Drawing.Point(0, 101);
            this.panelDiaryList.Margin = new System.Windows.Forms.Padding(4);
            this.panelDiaryList.Name = "panelDiaryList";
            this.panelDiaryList.Size = new System.Drawing.Size(840, 515);
            this.panelDiaryList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(30, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 2);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // UC_DiaryList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddDiary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelDiaryList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_DiaryList";
            this.Size = new System.Drawing.Size(840, 750);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddDiary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelDiaryList;
        private System.Windows.Forms.Label label3;
    }
}
