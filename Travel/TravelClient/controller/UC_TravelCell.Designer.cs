namespace TravelClient.controller
{
    partial class UC_TravelCell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TravelCell));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_deleteTravel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_TravelTitle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 79);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_deleteTravel
            // 
            this.Btn_deleteTravel.FlatAppearance.BorderSize = 0;
            this.Btn_deleteTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_deleteTravel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_deleteTravel.Image")));
            this.Btn_deleteTravel.Location = new System.Drawing.Point(735, 31);
            this.Btn_deleteTravel.Name = "Btn_deleteTravel";
            this.Btn_deleteTravel.Size = new System.Drawing.Size(59, 53);
            this.Btn_deleteTravel.TabIndex = 3;
            this.Btn_deleteTravel.UseVisualStyleBackColor = true;
            this.Btn_deleteTravel.Click += new System.EventHandler(this.Btn_deleteTravel_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(30, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(780, 2);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // Btn_TravelTitle
            // 
            this.Btn_TravelTitle.FlatAppearance.BorderSize = 0;
            this.Btn_TravelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TravelTitle.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TravelTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_TravelTitle.Location = new System.Drawing.Point(115, 33);
            this.Btn_TravelTitle.Name = "Btn_TravelTitle";
            this.Btn_TravelTitle.Size = new System.Drawing.Size(462, 42);
            this.Btn_TravelTitle.TabIndex = 11;
            this.Btn_TravelTitle.Text = "旅行标题";
            this.Btn_TravelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TravelTitle.UseVisualStyleBackColor = true;
            this.Btn_TravelTitle.Click += new System.EventHandler(this.Btn_TravelTitle_Click);
            // 
            // UC_TravelCell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Btn_TravelTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_deleteTravel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_TravelCell";
            this.Size = new System.Drawing.Size(837, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_deleteTravel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_TravelTitle;
    }
}
