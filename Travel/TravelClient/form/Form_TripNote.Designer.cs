namespace TravelClient.form
{
    partial class Form_TripNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TripNote));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_mytrip = new System.Windows.Forms.Label();
            this.Btn_PersonalInfo = new System.Windows.Forms.Button();
            this.Btn_NoteSharing = new System.Windows.Forms.Button();
            this.Btn_TravelNote = new System.Windows.Forms.Button();
            this.Btn_MyTravel = new System.Windows.Forms.Button();
            this.Btn_presentTravel = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lbl_mytrip);
            this.panel1.Controls.Add(this.Btn_PersonalInfo);
            this.panel1.Controls.Add(this.Btn_NoteSharing);
            this.panel1.Controls.Add(this.Btn_TravelNote);
            this.panel1.Controls.Add(this.Btn_MyTravel);
            this.panel1.Controls.Add(this.Btn_presentTravel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 800);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_mytrip
            // 
            this.Lbl_mytrip.AutoSize = true;
            this.Lbl_mytrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mytrip.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_mytrip.Location = new System.Drawing.Point(99, 59);
            this.Lbl_mytrip.Name = "Lbl_mytrip";
            this.Lbl_mytrip.Size = new System.Drawing.Size(101, 26);
            this.Lbl_mytrip.TabIndex = 6;
            this.Lbl_mytrip.Text = "MY TRIP";
            // 
            // Btn_PersonalInfo
            // 
            this.Btn_PersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.Btn_PersonalInfo.FlatAppearance.BorderSize = 0;
            this.Btn_PersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PersonalInfo.ForeColor = System.Drawing.Color.White;
            this.Btn_PersonalInfo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PersonalInfo.Image")));
            this.Btn_PersonalInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PersonalInfo.Location = new System.Drawing.Point(23, 362);
            this.Btn_PersonalInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_PersonalInfo.Name = "Btn_PersonalInfo";
            this.Btn_PersonalInfo.Size = new System.Drawing.Size(222, 48);
            this.Btn_PersonalInfo.TabIndex = 1;
            this.Btn_PersonalInfo.Text = "个人信息";
            this.Btn_PersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PersonalInfo.UseVisualStyleBackColor = false;
            this.Btn_PersonalInfo.Click += new System.EventHandler(this.Btn_PersonalInfo_Click);
            // 
            // Btn_NoteSharing
            // 
            this.Btn_NoteSharing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.Btn_NoteSharing.FlatAppearance.BorderSize = 0;
            this.Btn_NoteSharing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NoteSharing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NoteSharing.ForeColor = System.Drawing.Color.White;
            this.Btn_NoteSharing.Image = ((System.Drawing.Image)(resources.GetObject("Btn_NoteSharing.Image")));
            this.Btn_NoteSharing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NoteSharing.Location = new System.Drawing.Point(23, 306);
            this.Btn_NoteSharing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_NoteSharing.Name = "Btn_NoteSharing";
            this.Btn_NoteSharing.Size = new System.Drawing.Size(222, 48);
            this.Btn_NoteSharing.TabIndex = 1;
            this.Btn_NoteSharing.Text = "日志圈";
            this.Btn_NoteSharing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_NoteSharing.UseVisualStyleBackColor = false;
            this.Btn_NoteSharing.Click += new System.EventHandler(this.Btn_NoteSharing_Click);
            // 
            // Btn_TravelNote
            // 
            this.Btn_TravelNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.Btn_TravelNote.FlatAppearance.BorderSize = 0;
            this.Btn_TravelNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TravelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TravelNote.ForeColor = System.Drawing.Color.White;
            this.Btn_TravelNote.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TravelNote.Image")));
            this.Btn_TravelNote.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_TravelNote.Location = new System.Drawing.Point(23, 250);
            this.Btn_TravelNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_TravelNote.Name = "Btn_TravelNote";
            this.Btn_TravelNote.Size = new System.Drawing.Size(222, 48);
            this.Btn_TravelNote.TabIndex = 1;
            this.Btn_TravelNote.Text = "旅行日志";
            this.Btn_TravelNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TravelNote.UseVisualStyleBackColor = false;
            this.Btn_TravelNote.Click += new System.EventHandler(this.Btn_TravelNote_Click);
            // 
            // Btn_MyTravel
            // 
            this.Btn_MyTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.Btn_MyTravel.FlatAppearance.BorderSize = 0;
            this.Btn_MyTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MyTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MyTravel.ForeColor = System.Drawing.Color.White;
            this.Btn_MyTravel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MyTravel.Image")));
            this.Btn_MyTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_MyTravel.Location = new System.Drawing.Point(23, 194);
            this.Btn_MyTravel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_MyTravel.Name = "Btn_MyTravel";
            this.Btn_MyTravel.Size = new System.Drawing.Size(222, 48);
            this.Btn_MyTravel.TabIndex = 1;
            this.Btn_MyTravel.Text = "我的旅程";
            this.Btn_MyTravel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_MyTravel.UseVisualStyleBackColor = false;
            this.Btn_MyTravel.Click += new System.EventHandler(this.Btn_MyTravel_Click);
            // 
            // Btn_presentTravel
            // 
            this.Btn_presentTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(106)))), ((int)(((byte)(149)))));
            this.Btn_presentTravel.FlatAppearance.BorderSize = 0;
            this.Btn_presentTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_presentTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_presentTravel.ForeColor = System.Drawing.Color.White;
            this.Btn_presentTravel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_presentTravel.Image")));
            this.Btn_presentTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_presentTravel.Location = new System.Drawing.Point(23, 147);
            this.Btn_presentTravel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_presentTravel.Name = "Btn_presentTravel";
            this.Btn_presentTravel.Size = new System.Drawing.Size(222, 39);
            this.Btn_presentTravel.TabIndex = 1;
            this.Btn_presentTravel.Text = "当前旅程";
            this.Btn_presentTravel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_presentTravel.UseVisualStyleBackColor = false;
            this.Btn_presentTravel.Click += new System.EventHandler(this.Btn_presentTravel_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(260, 50);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(840, 750);
            this.panelControl.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1053, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 48);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form_TripNote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_TripNote";
            this.Text = "Form_TripNote";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_PersonalInfo;
        private System.Windows.Forms.Button Btn_NoteSharing;
        private System.Windows.Forms.Button Btn_TravelNote;
        private System.Windows.Forms.Button Btn_MyTravel;
        private System.Windows.Forms.Button Btn_presentTravel;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_mytrip;
    }
}