using Gma.System.MouseKeyHook;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NetChangeHotKey
{
    public partial class Form1 : Form
    {
        string network1InterfaceName = "Network1";
        string network2InterfaceName = "Network2";
        private IKeyboardMouseEvents m_GlobalHook;
        public Form1()
        {
            InitializeComponent();
        }

        private void net1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAdapter(network1InterfaceName);
            DisableAdapter(network2InterfaceName);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                Hide();
            }));
        }

        private void net2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAdapter(network2InterfaceName);
            DisableAdapter(network1InterfaceName);
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAdapter(network1InterfaceName);
            EnableAdapter(network2InterfaceName);
        }

        private void disAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableAdapter(network1InterfaceName);
            DisableAdapter(network2InterfaceName);
        }

        static void EnableAdapter(string interfaceName)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" enable");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }

        static void DisableAdapter(string interfaceName)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" disable");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
