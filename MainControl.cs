using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace VTubeMua
{
    public partial class MainControl : UserControl
    {
        public bool IsVisible { private set; get; }
        private PictureBox selectedBox;
        private long winkCooldown, lastTick;

        public MainControl()
        {
            InitializeComponent();
            lastTick = DateTime.Now.Ticks;
        }

        public void SetVisibility(bool visibility)
        {
            foreach (Control c in Controls) c.Visible = visibility;
            IsVisible = visibility;
        }

        private void MainControl_SizeChanged(object sender, EventArgs e)
        {
            microphone.Location = new Point((Width - microphone.Width) / 2, microphone.Location.Y);
            hideControlsButton.Location = new Point(Width - 126, Height - 79);
            changeColorButton.Location = new Point(10, Height - 79);
            bottomPanel.Location = new Point((Width - bottomPanel.Width) / 2, Height - 139);

            Graphics.FromHwnd(Handle).Clear(BackColor);
        }

        private void HideControlsButton_Click(object sender, EventArgs e)
            => SetVisibility(false);

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                selectedBox.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            } catch { }            
            Graphics.FromHwnd(Handle).Clear(BackColor);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            selectedBox = (PictureBox)sender;
            openFileDialog.ShowDialog();
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
            => colorDialog.ShowDialog();

        private void Timer_Tick(object sender, EventArgs e)
        {
            BackColor = colorDialog.Color;

            var ran = new Random();
            var wink = ran.Next(150) == 0;
            var img = screamingBox.BackgroundImage;

            if (wink) winkCooldown = ran.Next(500000, 800000);

            if (microphone.Output < 10) img = winkCooldown > 0 ? eyesClosedBox.BackgroundImage : standardBox.BackgroundImage;
            else if (microphone.Output < 50) img = talkingBox.BackgroundImage;

            var g = Graphics.FromHwnd(Handle);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(img, (Width - Height) / 2, 0, Height, Height);

            winkCooldown -= DateTime.Now.Ticks - lastTick;
            lastTick = DateTime.Now.Ticks;
        }
    }
}