using System;
using System.Windows.Forms;

namespace VTubeMua
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            mainControl.Size = Size;
        }

        private void MainControl_Click(object sender, EventArgs e)
        {
            if (!mainControl.IsVisible)
                mainControl.SetVisibility(true);
        }
    }
}