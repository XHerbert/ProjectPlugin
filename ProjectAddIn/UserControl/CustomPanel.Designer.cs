namespace ProjectAddIn
{
    partial class CustomPanel
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.update = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.expand = new System.Windows.Forms.Button();
            this.colapse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.update.Location = new System.Drawing.Point(11, 42);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(182, 32);
            this.update.TabIndex = 0;
            this.update.Text = "Update Task State Color";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Create
            // 
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Create.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Create.Location = new System.Drawing.Point(11, 5);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(182, 32);
            this.Create.TabIndex = 1;
            this.Create.Text = "Quick Create Project";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // stop
            // 
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stop.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stop.Location = new System.Drawing.Point(11, 79);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(182, 32);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop Project";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Finish
            // 
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Finish.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Finish.Location = new System.Drawing.Point(11, 117);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(182, 32);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "Finish Project";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Standard_Click);
            // 
            // expand
            // 
            this.expand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expand.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.expand.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expand.Location = new System.Drawing.Point(11, 155);
            this.expand.Name = "expand";
            this.expand.Size = new System.Drawing.Size(182, 32);
            this.expand.TabIndex = 4;
            this.expand.Text = "Expand All Tasks";
            this.expand.UseVisualStyleBackColor = true;
            this.expand.Click += new System.EventHandler(this.expand_Click);
            // 
            // colapse
            // 
            this.colapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colapse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colapse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.colapse.Location = new System.Drawing.Point(11, 193);
            this.colapse.Name = "colapse";
            this.colapse.Size = new System.Drawing.Size(182, 32);
            this.colapse.TabIndex = 5;
            this.colapse.Text = "Colapse All Tasks";
            this.colapse.UseVisualStyleBackColor = true;
            this.colapse.Click += new System.EventHandler(this.colapse_Click);
            // 
            // CustomPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colapse);
            this.Controls.Add(this.expand);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.update);
            this.Name = "CustomPanel";
            this.Size = new System.Drawing.Size(205, 412);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button expand;
        private System.Windows.Forms.Button colapse;
    }
}
