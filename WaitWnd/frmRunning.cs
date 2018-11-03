using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraSystem
{
    public partial class frmRunning : MetroFramework.Forms.MetroForm
    {
        public frmRunning()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public frmRunning(MetroFramework.Forms.MetroForm parent)
        {
            InitializeComponent();
            this.Theme = parent.Theme;
            this.Style = parent.Style;
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2, parent.Location.Y + parent.Height / 2 - this.Height / 2);
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterParent;
            }
        }
        public void CloseLoadingForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
        }
    }
}
