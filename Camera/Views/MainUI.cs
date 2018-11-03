using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using MetroFramework.Forms;
using CameraSystem.Views;

namespace ModernUIProject.Views
{
    public partial class MainUI : pnlSlider
    {
        public MainUI(Form owner) : base(owner)
        {
            InitializeComponent();
        }
    }
}
