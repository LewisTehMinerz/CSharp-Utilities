using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNamespace
{
    class FormStyle
    {
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        }

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMargins);
        public void changeToBorder(Form changingForm)
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                changingForm.BackColor = Color.DarkMagenta; changingForm.TransparencyKey = Color.DarkMagenta;
                MARGINS marg = new MARGINS() { Left = -1, Right = -1, Top = -1, Bottom = -1 };
                DwmExtendFrameIntoClientArea(changingForm.Handle, ref marg);
            }
        }
    }
}
