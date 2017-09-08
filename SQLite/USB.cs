using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLite
{
    public partial class USB : Form
    {
        const int WM_DEVICECHANGE = 537;
        const int DBT_DEVICEARRIVAL = 0x8000;
        const int DBT_DEVICEREMOVECOMPLETE = 0x8004;

        public USB()
        {
            InitializeComponent();
            refreshUsb();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE && ((int)m.WParam == DBT_DEVICEARRIVAL || (int)m.WParam == DBT_DEVICEREMOVECOMPLETE))
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(refreshUsb());
            }
            base.WndProc(ref m);
        }

        private System.IO.DriveInfo[] refreshUsb()
        {
            var usbs = System.IO.DriveInfo.GetDrives().Where(d => d.DriveType == System.IO.DriveType.Removable || d.DriveType == System.IO.DriveType.CDRom).ToArray();
            
            return usbs;
        }
    }
}
