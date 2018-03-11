using System;
using System.Windows.Forms;

namespace TeleBotMessenger.Helper
{
    public static class WindowsHelper
    {
        public static void ThreadSafeCall(this Control ctrl, Action act)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new Action(delegate { ThreadSafeCall(ctrl, act); }));
            }
            else
            {
                act.Invoke();
            }
        }
    }
}
