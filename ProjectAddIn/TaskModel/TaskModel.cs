using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectAddIn.TaskModel
{
    public class TaskModel
    {
        private string _taskName;

        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }
        private string _taskDuring;

        public string TaskDuring
        {
            get { return _taskDuring; }
            set { _taskDuring = value; }
        }
        private string _resourceNames;

        public string ResourceNames
        {
            get { return _resourceNames; }
            set { _resourceNames = value; }
        }
        private string _notes;

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
    }
}
