using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.MSProject;
using System.Drawing;

namespace ProjectAddIn.Base
{
    public class CommonData
    {
        public enum TaskState
        {
            /// <summary>
            /// 未开始
            /// </summary>
            Ready,
            /// <summary>
            /// 进行中
            /// </summary>
            Processing,
            /// <summary>
            /// 已完成
            /// </summary>
            Complete,
            /// <summary>
            /// 已停止
            /// </summary>
            Stop
        }


        public static Color MappingColorState(TaskState type)
        {
            Color state=Color.LightGreen;
            switch (type)
            {
                case TaskState.Ready:
                    state = ColorTranslator.FromHtml("#D99694");
                    break;
                case TaskState.Processing:
                    state = ColorTranslator.FromHtml("#FFFFCC");//#B8CCE4
                    break;
                case TaskState.Complete:
                    state = ColorTranslator.FromHtml("#C3D69B");
                    break;
                case TaskState.Stop:
                    state = ColorTranslator.FromHtml("#953734");
                    break;
                default:
                    break;
            }
            return state;
        }
    }
}
