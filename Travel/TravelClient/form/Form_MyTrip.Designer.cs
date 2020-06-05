namespace TravelClient.form
{
    partial class Form_MyTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MyTrip));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelleft = new System.Windows.Forms.Panel();
            this.btn_journal = new System.Windows.Forms.Button();
            this.btn_todo = new System.Windows.Forms.Button();
            this.btn_plan = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(229)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.panelleft);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 720);
            this.panel1.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(200, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1000, 720);
            this.panelControls.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 52);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.panelSlide);
            this.panelleft.Controls.Add(this.btn_plan);
            this.panelleft.Controls.Add(this.btn_todo);
            this.panelleft.Controls.Add(this.btn_journal);
            this.panelleft.Location = new System.Drawing.Point(0, 58);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(200, 660);
            this.panelleft.TabIndex = 1;
            // 
            // btn_journal
            // 
            this.btn_journal.FlatAppearance.BorderSize = 0;
            this.btn_journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_journal.Image = ((System.Drawing.Image)(resources.GetObject("btn_journal.Image")));
            this.btn_journal.Location = new System.Drawing.Point(0, 0);
            this.btn_journal.Name = "btn_journal";
            this.btn_journal.Size = new System.Drawing.Size(190, 220);
            this.btn_journal.TabIndex = 0;
            this.btn_journal.UseVisualStyleBackColor = true;
            this.btn_journal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_todo
            // 
            this.btn_todo.FlatAppearance.BorderSize = 0;
            this.btn_todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todo.Image = ((System.Drawing.Image)(resources.GetObject("btn_todo.Image")));
            this.btn_todo.Location = new System.Drawing.Point(0, 220);
            this.btn_todo.Name = "btn_todo";
            this.btn_todo.Size = new System.Drawing.Size(190, 220);
            this.btn_todo.TabIndex = 0;
            this.btn_todo.UseVisualStyleBackColor = true;
            this.btn_todo.Click += new System.EventHandler(this.btn_todo_Click);
            // 
            // btn_plan
            // 
            this.btn_plan.FlatAppearance.BorderSize = 0;
            this.btn_plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plan.Image = ((System.Drawing.Image)(resources.GetObject("btn_plan.Image")));
            this.btn_plan.Location = new System.Drawing.Point(0, 440);
            this.btn_plan.Name = "btn_plan";
            this.btn_plan.Size = new System.Drawing.Size(190, 220);
            this.btn_plan.TabIndex = 0;
            this.btn_plan.UseVisualStyleBackColor = true;
            this.btn_plan.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(190, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 220);
            this.panelSlide.TabIndex = 1;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Form_MyTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MyTrip";
            this.Text = "Form_MyTrip";
            this.panel1.ResumeLayout(false);
            this.panelleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button btn_plan;
        private System.Windows.Forms.Button btn_todo;
        private System.Windows.Forms.Button btn_journal;
        private System.Windows.Forms.Panel panelSlide;
    }
}