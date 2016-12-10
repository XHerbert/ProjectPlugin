using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using MSProject = Microsoft.Office.Interop.MSProject;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using Microsoft.Office.Interop.MSProject;
using ProjectAddIn.UserControlSpace;

namespace ProjectAddIn
{
    public partial class ThisAddIn
    {
        private AddTaskPanel addTask;

        private CustomPanel myUserControl1;

        //public CustomPanel MyUserControl1
        //{
        //    get { return myUserControl1; }
        //    set { myUserControl1 = value; }
        //}
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        private Microsoft.Office.Tools.CustomTaskPane myAddTask;
        public Microsoft.Office.Tools.CustomTaskPane MyCustomTaskPane
        {
            get { return myCustomTaskPane; }
            set { myCustomTaskPane = value; }
        }
        private Microsoft.Office.Tools.CustomTaskPaneCollection myCustomTaskPaneCollection;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            CreateCustomPanel();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }


        public void CreateCustomPanel()
        {
            myUserControl1 = new CustomPanel();
            addTask = new AddTaskPanel();
            myCustomTaskPaneCollection =Globals.Factory.CreateCustomTaskPaneCollection
                (null, null, "CustomTaskPanes", "CustomTaskPanes", this);

            myCustomTaskPane = myCustomTaskPaneCollection.Add(myUserControl1, "插件面板");
            myCustomTaskPane.Visible = true;
        }
        #endregion
    }
}
