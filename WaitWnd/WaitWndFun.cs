using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CameraSystem
{
    public class WaitWndFun
    {
        frmRunning loadingForm;
        Thread loadthread;

        public void Show()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcessEx));
            loadthread.Start();
        }
        public void Show(MetroFramework.Forms.MetroForm parent)
        {
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcessEx));
            loadthread.Start(parent);
        }
        public void Close()
        {
            if (loadingForm != null)
            {
                loadingForm.BeginInvoke(new System.Threading.ThreadStart(loadingForm.CloseLoadingForm));
                loadingForm = null;
                loadthread = null;
            }
        }
        private void LoadingProcessEx()
        {
            loadingForm = new frmRunning();
            loadingForm.ShowDialog();
        }
        private void LoadingProcessEx(object parent)
        {
            MetroFramework.Forms.MetroForm Cparent = parent as MetroFramework.Forms.MetroForm;
            loadingForm = new frmRunning(Cparent);
            loadingForm.ShowDialog();
        }
    }
}
