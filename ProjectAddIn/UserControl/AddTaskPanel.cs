using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.MSProject;

namespace ProjectAddIn.UserControlSpace
{
    public partial class AddTaskPanel : FormMaster
    {
        private CustomPanel _customPanel;

        public AddTaskPanel()
        {
            InitializeComponent();
        }

        public AddTaskPanel(CustomPanel customPanel)
            : base()
        {
            this._customPanel = customPanel;
        }


        private void Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taskName.Text)) return;
            Project proj = Globals.ThisAddIn.Application.ActiveProject;
            TaskModel.TaskModel taskModel = new TaskModel.TaskModel
            {
                TaskName = taskName.Text,
                TaskDuring = taskDuring.Value.ToString(),
                ResourceNames = taskResource.Text,
                Notes = taskNotes.Text
            };

            Application_NewProject(proj, taskModel);
        }

        private void Application_NewProject(Microsoft.Office.Interop.MSProject.Project pj, TaskModel.TaskModel taskModel)
        {
            object missing = Type.Missing;
            TaskModel.TaskModel tm = taskModel;
            Microsoft.Office.Interop.MSProject.Task newTask = pj.Tasks.Add(tm.TaskName, missing);
            newTask.Start = DateTime.Now;
            newTask.Duration = tm.TaskDuring;
            newTask.ResourceNames = tm.ResourceNames.ToString();
            newTask.Notes = tm.Notes;
        }

        private void AddTaskPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
