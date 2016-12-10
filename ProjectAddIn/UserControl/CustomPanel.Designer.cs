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
            // CustomPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stop);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.update);
            this.Name = "CustomPanel";
            this.Size = new System.Drawing.Size(205, 257);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button stop;
    }
}
