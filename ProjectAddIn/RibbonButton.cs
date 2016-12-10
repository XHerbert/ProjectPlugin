using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools;


namespace ProjectAddIn
{
    public partial class RibbonButton
    {
        private void RibbonButton_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
        {
            CustomTaskPane userPanel=Globals.ThisAddIn.MyCustomTaskPane;
            if (userPanel != null)
            {
                if (toggleButton.Checked)
                {
                    toggleButton.Label = "禁用控制面板";
                    userPanel.Visible = true;
                }
                else
                {
                    toggleButton.Label = "启用控制面板";
                    userPanel.Visible = false;
                }
            }
        }
    }
}
