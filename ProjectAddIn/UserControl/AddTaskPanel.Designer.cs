namespace ProjectAddIn.UserControlSpace
{
    partial class AddTaskPanel
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
            this.Create = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taskNotes = new System.Windows.Forms.TextBox();
            this.taskResource = new System.Windows.Forms.TextBox();
            this.taskDuring = new System.Windows.Forms.NumericUpDown();
            this.taskName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.taskDuring)).BeginInit();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Create.ForeColor = System.Drawing.Color.Maroon;
            this.Create.Location = new System.Drawing.Point(358, 357);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(147, 32);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create Task";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(39, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Task Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Task During";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Resource Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "Task Name";
            // 
            // taskNotes
            // 
            this.taskNotes.AcceptsReturn = true;
            this.taskNotes.AcceptsTab = true;
            this.taskNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.taskNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskNotes.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.taskNotes.ForeColor = System.Drawing.Color.Maroon;
            this.taskNotes.Location = new System.Drawing.Point(148, 161);
            this.taskNotes.Multiline = true;
            this.taskNotes.Name = "taskNotes";
            this.taskNotes.Size = new System.Drawing.Size(357, 129);
            this.taskNotes.TabIndex = 13;
            // 
            // taskResource
            // 
            this.taskResource.BackColor = System.Drawing.Color.Black;
            this.taskResource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskResource.ForeColor = System.Drawing.Color.Indigo;
            this.taskResource.Location = new System.Drawing.Point(148, 77);
            this.taskResource.Name = "taskResource";
            this.taskResource.Size = new System.Drawing.Size(357, 21);
            this.taskResource.TabIndex = 12;
            this.taskResource.Text = "徐洪波";
            // 
            // taskDuring
            // 
            this.taskDuring.BackColor = System.Drawing.Color.Black;
            this.taskDuring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskDuring.ForeColor = System.Drawing.Color.White;
            this.taskDuring.Location = new System.Drawing.Point(148, 119);
            this.taskDuring.Name = "taskDuring";
            this.taskDuring.Size = new System.Drawing.Size(357, 17);
            this.taskDuring.TabIndex = 11;
            // 
            // taskName
            // 
            this.taskName.BackColor = System.Drawing.Color.Black;
            this.taskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.taskName.Location = new System.Drawing.Point(148, 35);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(357, 21);
            this.taskName.TabIndex = 10;
            // 
            // AddTaskPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskNotes);
            this.Controls.Add(this.taskResource);
            this.Controls.Add(this.taskDuring);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.Create);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTaskPanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTaskPanel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.taskDuring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskNotes;
        private System.Windows.Forms.TextBox taskResource;
        private System.Windows.Forms.NumericUpDown taskDuring;
        private System.Windows.Forms.TextBox taskName;
    }
}
