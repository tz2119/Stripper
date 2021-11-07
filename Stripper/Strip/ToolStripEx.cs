using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Stripper;

namespace Strip {
    public class ToolStripEx : ToolStrip {
        protected override void WndProc(ref Message m) {
            if (m.Msg == StripperUtils.WM_MOUSEACTIVATE) {
                m.Result = new IntPtr(StripperUtils.MA_ACTIVATE);
                return;
            }
            base.WndProc(ref m);
        }
    }
}
