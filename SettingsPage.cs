using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GoDrive__Guna_
{
    public partial class SettingsPage : Form
    {
        [DllImport("dxva2.dll", EntryPoint = "GetMonitorBrightness")]
        private static extern bool GetMonitorBrightness(IntPtr hMonitor, out int pdwMinimumBrightness, out int pdwCurrentBrightness, out int pdwMaximumBrightness);

        [DllImport("dxva2.dll", EntryPoint = "SetMonitorBrightness")]
        private static extern bool SetMonitorBrightness(IntPtr hMonitor, int dwNewBrightness);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr MonitorFromWindow(IntPtr hwnd, int dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumProc lpfnEnum, IntPtr dwData);

        private delegate bool MonitorEnumProc(IntPtr hMonitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData);

        [StructLayout(LayoutKind.Sequential)]

        
        private struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private IntPtr primaryMonitor;

        public static Form2 Instance2;
        public static HomePage Instance1;
        public static MapPage Instance3;
        public static SettingsPage Instance4;
        public SettingsPage()
        {
            InitializeComponent();
            EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, MonitorEnum, IntPtr.Zero);
            numericUpDownBrightness.ValueChanged += NumericUpDownBrightness_ValueChanged;
            Instance4 = this;
        }
        private bool MonitorEnum(IntPtr hMonitor, IntPtr hdcMonitor, ref Rect lprcMonitor, IntPtr dwData)
        {
            primaryMonitor = hMonitor;
            return false;
        }

        private void NumericUpDownBrightness_ValueChanged(object sender, EventArgs e)
        {
            int brightness = (int)numericUpDownBrightness.Value;
            SetMonitorBrightness(primaryMonitor, brightness);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void butclosedash_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance2 = new Form2();
            Instance2.Show();
        }

        private void butminimizedash_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance1 = new HomePage();
            Instance1.Show();
        }
    }
}
