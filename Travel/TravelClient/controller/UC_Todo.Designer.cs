namespace TravelClient.controller
{
    partial class UC_Todo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Todo));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Btn_deleteTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(16, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 33);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "待办内容";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Btn_deleteTodo
            // 
            this.Btn_deleteTodo.FlatAppearance.BorderSize = 0;
            this.Btn_deleteTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_deleteTodo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_deleteTodo.Image")));
            this.Btn_deleteTodo.Location = new System.Drawing.Point(460, 0);
            this.Btn_deleteTodo.Name = "Btn_deleteTodo";
            this.Btn_deleteTodo.Size = new System.Drawing.Size(44, 45);
            this.Btn_deleteTodo.TabIndex = 1;
            this.Btn_deleteTodo.UseVisualStyleBackColor = true;
            // 
            // UC_Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_deleteTodo);
            this.Controls.Add(this.checkBox1);
            this.Name = "UC_Todo";
            this.Size = new System.Drawing.Size(521, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Btn_deleteTodo;
    }
}
