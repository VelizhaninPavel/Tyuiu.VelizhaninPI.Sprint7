using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tyuiu.VelizhaninPI.Sprint7.Project.V10.FormMainProject.Form1;

namespace Tyuiu.VelizhaninPI.Sprint7.Project.V10
{
    public partial class FormMainProject : Form
    {
        public FormMainProject()
        {
            InitializeComponent();

            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));

            //openFileDialogTask_VPI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            //saveFileDialogTask_VPI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.";
        }


        public partial class Form1 : Form
        {
            public enum
            DWMWINDOWATTRIBUTE
            {
                DWMWA_WINDOW_CORNER_PREFERENCE = 33
            }

            public enum
            DWM_WINDOW_CORNER_PREFERENCE
            {
                DWMWCP_DEFAULT = 0,
                DWMWCP_DONOTROUND = 1,
                DWMWCP_ROUND = 2,
                DWMWCP_ROUNDSMALL = 3
            }

            [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
            internal static extern void
            DwmSetWindowAttribute
            (
            IntPtr hwnd, DWMWINDOWATTRIBUTE attribute, ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute, uint cbAttribute);

        }
    }
}