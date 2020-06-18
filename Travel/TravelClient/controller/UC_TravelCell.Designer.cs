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
            this.Lbl_TravelTitle = new System.Windows.Forms.Label();
            this.Btn_deleteTravel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
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
            // Lbl_TravelTitle
            // 
            this.Lbl_TravelTitle.AutoSize = true;
            this.Lbl_TravelTitle.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_TravelTitle.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_TravelTitle.Location = new System.Drawing.Point(129, 33);
            this.Lbl_TravelTitle.Name = "Lbl_TravelTitle";
            this.Lbl_TravelTitle.Size = new System.Drawing.Size(148, 44);
            this.Lbl_TravelTitle.TabIndex = 2;
            this.Lbl_TravelTitle.Text = "旅行标题";
            // 
            // Btn_deleteTravel
            // 
            this.Btn_deleteTravel.FlatAppearance.BorderSize = 0;
            this.Btn_deleteTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_deleteTravel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_deleteTravel.Image")));
            this.Btn_deleteTravel.Location = new System.Drawing.Point(732, 33);
            this.Btn_deleteTravel.Name = "Btn_deleteTravel";
            this.Btn_deleteTravel.Size = new System.Drawing.Size(59, 53);
            this.Btn_deleteTravel.TabIndex = 3;
            this.Btn_deleteTravel.UseVisualStyleBackColor = true;
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
            // UC_TravelCell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_deleteTravel);
            this.Controls.Add(this.Lbl_TravelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_TravelCell";
            this.Size = new System.Drawing.Size(837, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_TravelTitle;
        private System.Windows.Forms.Button Btn_deleteTravel;
        private System.Windows.Forms.Label label7;
    }
}
