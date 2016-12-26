using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.MSProject;
using ProjectAddIn.UserControlSpace;
using Microsoft.Office.Tools.Ribbon;
using ProjectAddIn.Base;
using System.Diagnostics;

namespace ProjectAddIn
{
    /// <summary>
    /// 插件管理面板
    /// </summary>
    public partial class CustomPanel : UserControl
    {
        public CustomPanel()
        {
            InitializeComponent(); 
        }

        private void update_Click(object sender, EventArgs e)
        {
            CallSelectTaskField();
        }
        private static AddTaskPanel _add;
        private void Create_Click(object sender, EventArgs e)
        {
            AddTaskPanel task = new AddTaskPanel();
            task.Show();
        }

        private static AddTaskPanel CreateSingletonPanel()
        {
            if (_add == null)
            {
                _add = new AddTaskPanel();
            }
            return _add;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            //停止项目
            CallSelectRangeField();
        }

        /// <summary>
        /// 根据任务状态进行背景填充的核心方法
        /// </summary>
        private void CallSelectTaskField()
        {
            foreach (Task task in Globals.ThisAddIn.Application.ActiveProject.Tasks)
            {
                if (task.ResourceNames == string.Empty) continue;//如果任务停止，不更新状态
                Globals.ThisAddIn.Application.SelectTaskField(task.Index, "名称", false, 5, 0);
                if (task.PercentComplete == 0)
                {
                    CallFont32Ex(CommonData.MappingColorState(CommonData.TaskState.Ready),false);
                }
                else if (task.PercentComplete == 100)
                {
                    CallFont32Ex(CommonData.MappingColorState(CommonData.TaskState.Complete), false);
                }
                else
                {
                    CallFont32Ex(CommonData.MappingColorState(CommonData.TaskState.Processing), false);
                }
            }
        }

        /// <summary>
        /// 调用系统方法设置背景色
        /// </summary>
        /// <param name="bgColor"></param>
        private void CallFont32Ex(Color bgColor,bool isStop)
        {
            object missing=Type.Missing;
            Color white = Color.White;
            Color blak = Color.Black;
            Color useColor = blak;
            if (isStop)
            {
                useColor = white;
            }
            Globals.ThisAddIn.Application.Font32Ex(
                "微软雅黑", 9, missing, missing, 
                missing, useColor, missing,
                bgColor, missing, missing);
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        private void CallSelectRangeField()
        {
            if (Globals.ThisAddIn.Application.ActiveSelection.Tasks == null)
                return;
            foreach (Task task in Globals.ThisAddIn.Application.ActiveSelection.Tasks)
            {
                Globals.ThisAddIn.Application.SelectTaskField(task.Index, "名称", false, 5, 0);
                //清除资源
                task.ResourceNames = string.Empty;
                //完成百分比
                task.PercentComplete = 0;
                //背景状态
                CallFont32Ex(CommonData.MappingColorState(CommonData.TaskState.Stop),true);
            }
        }

        private void FinishTask()
        {
            if (Globals.ThisAddIn.Application.ActiveSelection.Tasks == null)
                return;
            foreach (Task task in Globals.ThisAddIn.Application.ActiveSelection.Tasks)
            {
                Globals.ThisAddIn.Application.SelectTaskField(task.Index, "名称", false, 5, 0);
                //清除资源
                task.ResourceNames = "徐洪波";
                //完成百分比
                task.PercentComplete = 100;
                //背景状态
                CallFont32Ex(CommonData.MappingColorState(CommonData.TaskState.Complete), false);
            }
        }

        private void expand_Click(object sender, EventArgs e)
        {
            foreach (Task item in Globals.ThisAddIn.Application.ActiveProject.Tasks)
            {
                if (item.OutlineChildren.Count > 0)
                {
                    item.OutlineShowAllTasks();
                }
            }
        }

        private void colapse_Click(object sender, EventArgs e)
        {
            foreach (Task item in Globals.ThisAddIn.Application.ActiveProject.Tasks)
            {
                if (item.OutlineChildren.Count > 0)
                {
                    item.OutlineHideSubTasks();
                }
            }
        }

        private void Standard_Click(object sender, EventArgs e)
        {
            FinishTask();
        }

        private void Init(Project activeProj)
        {
            //activeProj.AddNewColumn("完成百分比");
            //activeProj.Application.AddNewColumn(PjFieldTypes.pjNumberField);
            activeProj.Application.ColumnAlignment(PjAlignment.pjLeft);
            activeProj.Application.ColumnDelete();
            activeProj.Application.AddNewColumn(PjFieldTypes.pjFinishField);
        }

        private void InitProj_Click(object sender, EventArgs e)
        {
            Init(Globals.ThisAddIn.Application.ActiveProject);
            
        }
    }
}
