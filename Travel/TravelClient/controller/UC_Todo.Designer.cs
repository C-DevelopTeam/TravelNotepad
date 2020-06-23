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
            this.Cbx_todo = new System.Windows.Forms.CheckBox();
            this.Btn_deleteTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cbx_todo
            // 
            this.Cbx_todo.AutoSize = true;
            this.Cbx_todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_todo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cbx_todo.Location = new System.Drawing.Point(27, 7);
            this.Cbx_todo.Name = "Cbx_todo";
            this.Cbx_todo.Size = new System.Drawing.Size(96, 24);
            this.Cbx_todo.TabIndex = 0;
            this.Cbx_todo.Text = "待办内容";
            this.Cbx_todo.UseVisualStyleBackColor = true;
            this.Cbx_todo.CheckedChanged += new System.EventHandler(this.Cbx_todo_CheckedChanged);
            // 
            // Btn_deleteTodo
            // 
            this.Btn_deleteTodo.FlatAppearance.BorderSize = 0;
            this.Btn_deleteTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_deleteTodo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_deleteTodo.Image")));
            this.Btn_deleteTodo.Location = new System.Drawing.Point(425, 7);
            this.Btn_deleteTodo.Name = "Btn_deleteTodo";
            this.Btn_deleteTodo.Size = new System.Drawing.Size(43, 33);
            this.Btn_deleteTodo.TabIndex = 1;
            this.Btn_deleteTodo.UseVisualStyleBackColor = true;
            this.Btn_deleteTodo.Click += new System.EventHandler(this.Btn_deleteTodo_Click);
            // 
            // UC_Todo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Btn_deleteTodo);
            this.Controls.Add(this.Cbx_todo);
            this.Name = "UC_Todo";
            this.Size = new System.Drawing.Size(521, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Cbx_todo;
        private System.Windows.Forms.Button Btn_deleteTodo;
    }
}
