namespace TravelClient.controller
{
    partial class UC_SiteInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SiteInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_backToRoute = new System.Windows.Forms.Button();
            this.Lbl_vehicle = new System.Windows.Forms.Label();
            this.Lbl_timeForLeave = new System.Windows.Forms.Label();
            this.Lbl_timeForArrive = new System.Windows.Forms.Label();
            this.Lbl_site = new System.Windows.Forms.Label();
            this.Txtbox_site = new System.Windows.Forms.TextBox();
            this.Txtbos_vehicle = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Gpb_todolist = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_todo = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Comfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Gpb_todolist.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(113, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_title
            // 
            this.Lbl_title.AutoSize = true;
            this.Lbl_title.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_title.Location = new System.Drawing.Point(184, 24);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Size = new System.Drawing.Size(183, 54);
            this.Lbl_title.TabIndex = 9;
            this.Lbl_title.Text = "旅程标题";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 2);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Btn_backToRoute
            // 
            this.Btn_backToRoute.FlatAppearance.BorderSize = 0;
            this.Btn_backToRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_backToRoute.Image = ((System.Drawing.Image)(resources.GetObject("Btn_backToRoute.Image")));
            this.Btn_backToRoute.Location = new System.Drawing.Point(32, 18);
            this.Btn_backToRoute.Name = "Btn_backToRoute";
            this.Btn_backToRoute.Size = new System.Drawing.Size(75, 60);
            this.Btn_backToRoute.TabIndex = 12;
            this.Btn_backToRoute.UseVisualStyleBackColor = true;
            this.Btn_backToRoute.Click += new System.EventHandler(this.Btn_backToRoute_Click);
            // 
            // Lbl_vehicle
            // 
            this.Lbl_vehicle.AutoSize = true;
            this.Lbl_vehicle.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_vehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_vehicle.Location = new System.Drawing.Point(84, 293);
            this.Lbl_vehicle.Name = "Lbl_vehicle";
            this.Lbl_vehicle.Size = new System.Drawing.Size(159, 33);
            this.Lbl_vehicle.TabIndex = 13;
            this.Lbl_vehicle.Text = "怎么去下一站";
            // 
            // Lbl_timeForLeave
            // 
            this.Lbl_timeForLeave.AutoSize = true;
            this.Lbl_timeForLeave.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_timeForLeave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_timeForLeave.Location = new System.Drawing.Point(84, 233);
            this.Lbl_timeForLeave.Name = "Lbl_timeForLeave";
            this.Lbl_timeForLeave.Size = new System.Drawing.Size(111, 33);
            this.Lbl_timeForLeave.TabIndex = 14;
            this.Lbl_timeForLeave.Text = "离开时间";
            // 
            // Lbl_timeForArrive
            // 
            this.Lbl_timeForArrive.AutoSize = true;
            this.Lbl_timeForArrive.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_timeForArrive.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_timeForArrive.Location = new System.Drawing.Point(83, 175);
            this.Lbl_timeForArrive.Name = "Lbl_timeForArrive";
            this.Lbl_timeForArrive.Size = new System.Drawing.Size(111, 33);
            this.Lbl_timeForArrive.TabIndex = 15;
            this.Lbl_timeForArrive.Text = "到达时间";
            // 
            // Lbl_site
            // 
            this.Lbl_site.AutoSize = true;
            this.Lbl_site.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_site.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_site.Location = new System.Drawing.Point(84, 117);
            this.Lbl_site.Name = "Lbl_site";
            this.Lbl_site.Size = new System.Drawing.Size(63, 33);
            this.Lbl_site.TabIndex = 16;
            this.Lbl_site.Text = "地点";
            // 
            // Txtbox_site
            // 
            this.Txtbox_site.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbox_site.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txtbox_site.Location = new System.Drawing.Point(286, 117);
            this.Txtbox_site.Name = "Txtbox_site";
            this.Txtbox_site.Size = new System.Drawing.Size(240, 36);
            this.Txtbox_site.TabIndex = 17;
            // 
            // Txtbos_vehicle
            // 
            this.Txtbos_vehicle.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbos_vehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txtbos_vehicle.Location = new System.Drawing.Point(286, 290);
            this.Txtbos_vehicle.Name = "Txtbos_vehicle";
            this.Txtbos_vehicle.Size = new System.Drawing.Size(240, 36);
            this.Txtbos_vehicle.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("方正幼线简体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 31);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker2.Font = new System.Drawing.Font("方正幼线简体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(286, 233);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(240, 31);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // Gpb_todolist
            // 
            this.Gpb_todolist.Controls.Add(this.flowLayoutPanel_todo);
            this.Gpb_todolist.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Gpb_todolist.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Gpb_todolist.Location = new System.Drawing.Point(90, 347);
            this.Gpb_todolist.Name = "Gpb_todolist";
            this.Gpb_todolist.Size = new System.Drawing.Size(606, 334);
            this.Gpb_todolist.TabIndex = 23;
            this.Gpb_todolist.TabStop = false;
            this.Gpb_todolist.Text = "待办事项";
            // 
            // flowLayoutPanel_todo
            // 
            this.flowLayoutPanel_todo.Location = new System.Drawing.Point(45, 73);
            this.flowLayoutPanel_todo.Name = "flowLayoutPanel_todo";
            this.flowLayoutPanel_todo.Size = new System.Drawing.Size(524, 240);
            this.flowLayoutPanel_todo.TabIndex = 25;
            // 
            // Btn_Comfirm
            // 
            this.Btn_Comfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.Btn_Comfirm.Font = new System.Drawing.Font("造字工房力黑（非商用）常规体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Comfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Comfirm.Location = new System.Drawing.Point(362, 687);
            this.Btn_Comfirm.Name = "Btn_Comfirm";
            this.Btn_Comfirm.Size = new System.Drawing.Size(106, 46);
            this.Btn_Comfirm.TabIndex = 25;
            this.Btn_Comfirm.Text = "确定";
            this.Btn_Comfirm.UseVisualStyleBackColor = false;
            // 
            // UC_SiteInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Btn_Comfirm);
            this.Controls.Add(this.Gpb_todolist);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Txtbos_vehicle);
            this.Controls.Add(this.Txtbox_site);
            this.Controls.Add(this.Lbl_site);
            this.Controls.Add(this.Lbl_timeForArrive);
            this.Controls.Add(this.Lbl_timeForLeave);
            this.Controls.Add(this.Lbl_vehicle);
            this.Controls.Add(this.Btn_backToRoute);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_title);
            this.Controls.Add(this.label1);
            this.Name = "UC_SiteInfo";
            this.Size = new System.Drawing.Size(840, 750);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Gpb_todolist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_backToRoute;
        private System.Windows.Forms.Label Lbl_vehicle;
        private System.Windows.Forms.Label Lbl_timeForLeave;
        private System.Windows.Forms.Label Lbl_timeForArrive;
        private System.Windows.Forms.Label Lbl_site;
        private System.Windows.Forms.TextBox Txtbox_site;
        private System.Windows.Forms.TextBox Txtbos_vehicle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox Gpb_todolist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_todo;
        private System.Windows.Forms.Button Btn_Comfirm;
    }
}
