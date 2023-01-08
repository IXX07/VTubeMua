using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace VTubeMua
{
    public partial class Microphone : UserControl
    {
        private int volume;
        public int Output { get; private set; }
        private WaveInEvent waveIn;

        public Microphone()
        {
            InitializeComponent();

            for (int i = 0; i < WaveIn.DeviceCount; i++)
                inputSelect.Items.Add(WaveIn.GetCapabilities(i).ProductName);

            inputSelect.SelectedIndex = 0;
        }

        private void InputSelect_SelectedItemChanged(object sender, EventArgs e)
        {
            if (waveIn != null) waveIn.StopRecording();

            waveIn = new WaveInEvent
            {
                DeviceNumber = inputSelect.SelectedIndex,
                WaveFormat = new WaveFormat(44100, 16, 1),
                BufferMilliseconds = 50
            };

            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.StartRecording();
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            const float maxValue = 32767;
            int peakValue = 0;

            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                int value = BitConverter.ToInt16(e.Buffer, i);
                peakValue = Math.Max(peakValue, value);
            }

            volume = (int)(peakValue / maxValue * 100);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Output = volumeBar.Value = Math.Min(100, volume * (amplifyBar.Value / 10));
        }
    }
}
