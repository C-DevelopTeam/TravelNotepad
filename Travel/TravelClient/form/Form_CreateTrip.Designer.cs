namespace TravelClient.form
{
    partial class Form_CreateTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CreateTrip));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btn_journal = new System.Windows.Forms.Button();
            this.btn_tdList = new System.Windows.Forms.Button();
            this.buttonct = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(193)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 720);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 36);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 36);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.paneltop.Controls.Add(this.panelSlide);
            this.paneltop.Controls.Add(this.btn_journal);
            this.paneltop.Controls.Add(this.btn_tdList);
            this.paneltop.Controls.Add(this.buttonct);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(405, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(795, 100);
            this.paneltop.TabIndex = 1;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(-1, 89);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(265, 10);
            this.panelSlide.TabIndex = 1;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            // 
            // btn_journal
            // 
            this.btn_journal.AutoSize = true;
            this.btn_journal.FlatAppearance.BorderSize = 0;
            this.btn_journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_journal.Image = ((System.Drawing.Image)(resources.GetObject("btn_journal.Image")));
            this.btn_journal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_journal.Location = new System.Drawing.Point(530, 0);
            this.btn_journal.Name = "btn_journal";
            this.btn_journal.Size = new System.Drawing.Size(265, 90);
            this.btn_journal.TabIndex = 0;
            this.btn_journal.Text = "日志";
            this.btn_journal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_journal.UseVisualStyleBackColor = true;
            this.btn_journal.Click += new System.EventHandler(this.btn_journal_Click);
            // 
            // btn_tdList
            // 
            this.btn_tdList.AutoSize = true;
            this.btn_tdList.FlatAppearance.BorderSize = 0;
            this.btn_tdList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tdList.Image = ((System.Drawing.Image)(resources.GetObject("btn_tdList.Image")));
            this.btn_tdList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_tdList.Location = new System.Drawing.Point(265, 0);
            this.btn_tdList.Name = "btn_tdList";
            this.btn_tdList.Size = new System.Drawing.Size(265, 90);
            this.btn_tdList.TabIndex = 0;
            this.btn_tdList.Text = "新建待办";
            this.btn_tdList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tdList.UseVisualStyleBackColor = true;
            this.btn_tdList.Click += new System.EventHandler(this.btn_tdList_Click);
            // 
            // buttonct
            // 
            this.buttonct.AutoSize = true;
            this.buttonct.FlatAppearance.BorderSize = 0;
            this.buttonct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonct.Image = ((System.Drawing.Image)(resources.GetObject("buttonct.Image")));
            this.buttonct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonct.Location = new System.Drawing.Point(0, 0);
            this.buttonct.Name = "buttonct";
            this.buttonct.Size = new System.Drawing.Size(265, 90);
            this.buttonct.TabIndex = 0;
            this.buttonct.Text = "新建旅程";
            this.buttonct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonct.UseVisualStyleBackColor = true;
            this.buttonct.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelControls
            // 
            this.panelControls.AutoSize = true;
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(405, 100);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(795, 620);
            this.panelControls.TabIndex = 2;
            // 
            // Form_CreateTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CreateTrip";
            this.Text = "Form_CreateTrip";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.panel1.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button btn_journal;
        private System.Windows.Forms.Button btn_tdList;
        private System.Windows.Forms.Button buttonct;
        private System.Windows.Forms.Panel panelControls;
    }
}