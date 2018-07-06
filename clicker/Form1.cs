using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;

namespace clicker
{
    public partial class PandaClicker : MetroForm
    {
        //low level hook from: https://blogs.msdn.microsoft.com/toub/2006/05/03/low-level-keyboard-hook-in-c/ (not working)

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        Random rand1 = new Random();
        Random rand2 = new Random();

        int lmbMin = 11;
        int lmbMax = 15;
        int rmbMin = 45;
        int rmbMax = 55;

        Keys lmbBind = Keys.V;
        Keys rmbBind = Keys.X;

        uint mouseX;
        uint mouseY;

        public PandaClicker()
        {
            InitializeComponent();

            hookID = SetHook(proc);

            UnhookWindowsHookEx(hookID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(13, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static LowLevelKeyboardProc proc = HookCallback;
        private static IntPtr hookID = IntPtr.Zero;
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            MessageBox.Show("test");
            if (nCode >= 0 && wParam == (IntPtr)0x0100)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                MessageBox.Show(vkCode.ToString());
            }
            return CallNextHookEx(hookID, nCode, wParam, lParam);
        }

        public void DoMouseClick(string clickType)
        {
            mouseX = (uint)Cursor.Position.X;
            mouseY = (uint)Cursor.Position.Y;
            if(clickType == "lmb")
            {
                mouse_event(0x02 | 0x04, mouseX, mouseY, 0, 0);
            }
            else if (clickType == "rmb")
            {
                mouse_event(0x08 | 0x10, mouseX, mouseY, 0, 0);
            }
        }

        private void leftClick_Tick(object sender, EventArgs e)
        {
            try
            {
                leftClick.Interval = (1000 / rand1.Next(lmbMin, lmbMax));
            }
            catch (Exception) { leftClick.Stop(); }
            DoMouseClick("lmb");
        }

        private void rightClick_Tick(object sender, EventArgs e)
        {
            try
            {
                rightClick.Interval = (1000 / rand2.Next(rmbMin, rmbMax));
            }
            catch (Exception) { rightClick.Stop(); }
            DoMouseClick("rmb");
        }

        private void leftCpsMin_Scroll(object sender, ScrollEventArgs e)
        {
            if (leftCpsMin.Value > leftCpsMax.Value)
            {
                leftCpsMin.Value = leftCpsMax.Value;
            }
            metroLabel7.Text = leftCpsMin.Value.ToString();
            lmbMin = leftCpsMin.Value;
        }

        private void leftCpsMax_Scroll(object sender, ScrollEventArgs e)
        {
            if (leftCpsMax.Value < leftCpsMin.Value)
            {
                leftCpsMax.Value = leftCpsMin.Value;
            }
            metroLabel8.Text = leftCpsMax.Value.ToString();
            lmbMax = leftCpsMax.Value;
        }

        private void rightCpsMin_Scroll(object sender, ScrollEventArgs e)
        {
            if (rightCpsMin.Value > rightCpsMax.Value)
            {
                rightCpsMin.Value = rightCpsMax.Value;
            }
            metroLabel9.Text = rightCpsMin.Value.ToString();
            rmbMin = rightCpsMin.Value;
        }

        private void rightCpsMax_Scroll(object sender, ScrollEventArgs e)
        {
            if (rightCpsMax.Value < rightCpsMin.Value)
            {
                rightCpsMax.Value = rightCpsMin.Value;
            }
            metroLabel10.Text = rightCpsMax.Value.ToString();
            rmbMax = rightCpsMax.Value;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keys)
        {
            if (keys == lmbBind)
            {
                leftClick.Enabled = !leftClick.Enabled;
            }
            if (keys == rmbBind)
            {
                rightClick.Enabled = !rightClick.Enabled;
            }
            if(keys == Keys.A)
            {
                MessageBox.Show("acapulco");
            }
            return base.ProcessCmdKey(ref msg, keys);
        }
    }
}