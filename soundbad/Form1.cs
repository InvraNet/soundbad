using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DiscordRPC;
using DiscordRPC.Logging;

namespace soundbad
{
    public partial class Form1 : Form
    {
        private DiscordRpcClient client;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private int WM_LBUTTONDOWN = 0x0201;
        private int WM_LBUTTONUP = 0x0202;
        private WaveOutEvent waveOutDevice;
        private AudioFileReader audioFileReader;
        private string convResFolder;
        private bool isPlaying = false;

        public Form1()
        {
            InitializeComponent();
            InitializeDiscordRPC();
            convResFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Soundbad", "convRes");

            if (!Directory.Exists(convResFolder))
            {
                Directory.CreateDirectory(convResFolder);
            }
            waveOutDevice = new WaveOutEvent();
        }
        private void InitializeDiscordRPC()
        {
            client = new DiscordRpcClient("1261951108654432286");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
            rpcStatus.Visible = true;
            UpdateDiscordPresence("Idle", "No audio playing");
        }
        private void UpdateDiscordPresence(string state, string details)
        {
            if (client != null)
            {
                if (isPlaying)
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = details,
                        State = state,
                        Buttons = new DiscordRPC.Button[]
                        {
                            new DiscordRPC.Button() { Label = "In development", Url = "https://invra.net/" }
                        },
                        Assets = new Assets()
                        {
                            LargeImageKey = "discord-large-rpc",
                            LargeImageText = $"Playing: {Path.GetFileName(audioFileReader.FileName)}",
                            SmallImageKey = "soundbad-logo",
                            SmallImageText = "Soundbad - By InvraNet"
                        }
                    });
                } else if (!isPlaying)
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = details,
                        State = state,
                        Buttons = new DiscordRPC.Button[]
                        {
                            new DiscordRPC.Button() { Label = "In development", Url = "https://invra.net/" }
                        },
                        Assets = new Assets()
                        {
                            LargeImageKey = "discord-large-rpc",
                            LargeImageText = "Idling",
                            SmallImageKey = "soundbad-logo",
                            SmallImageText = "Soundbad - By InvraNet"
                        }
                    });
                }
            }
        }
        private void UpdatePresenceBasedOnPlayback()
        {
            if (isPlaying && audioFileReader != null)
            {
                UpdateDiscordPresence("Playing", $"Playing: {Path.GetFileName(audioFileReader.FileName)}");
            }
            else
            {
                UpdateDiscordPresence("Idle", "No audio playing");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(volumeBar, "Yes, this is the volume-slider.");
            toolTip1.SetToolTip(playPauseBtn, "Play/ Pause");
            toolTip1.SetToolTip(stopBtn, "Stop");
            toolTip1.SetToolTip(soundbadLogo, "Info");
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 1000;
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            string[] wavFiles = Directory.GetFiles(convResFolder, "*.wav");
            foreach (string file in wavFiles)
            {
                listBox1.Items.Add(file);
            }
            stopSoundToolStripMenuItem.Visible = false;
            volumeBar.Minimum = 0;
            volumeBar.Maximum = 110;
            volumeBar.SmallChange = 1;
            volumeBar.LargeChange = 10;
            volumeStatement.Text = "Volume: " + 1 * 100 + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = submitFileLocationBox.Text;

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter a file path.", "Error with opening specified file.");
                return;
            }

            if (!File.Exists(path))
            {
                MessageBox.Show("The specified file doesn't exist.", "Error with opening specified file.");
                return;
            }

            FileAttributes attr = File.GetAttributes(path);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                MessageBox.Show("Specified path is a directory, not a file.", "Error with opening specified file.");
                return;
            }
            string wavFilePath = ConvertToWav(path);
            if (wavFilePath == null)
            {
                MessageBox.Show("Error converting file to WAV format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.Add(wavFilePath);
        }

        private void PlayAudio(string filePath)
        {
            try
            {
                StopAudio();
                string filename = Path.GetFileName(filePath);
                audioFileReader = new AudioFileReader(filePath);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                waveOutDevice.PlaybackStopped += WaveOutDevice_PlaybackStopped;
                isPlaying = true;
                playSoundToolStripMenuItem.Visible = false;
                stopSoundToolStripMenuItem.Visible = true;
                contentPlayingIntel.Text = $"Playing: {filename}";
                UpdatePresenceBasedOnPlayback();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void WaveOutDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (audioFileReader == null || waveOutDevice.PlaybackState != PlaybackState.Playing)
            {
                isPlaying = false;
                contentPlayingIntel.Text = "Not playing sound.";
                UpdatePresenceBasedOnPlayback();
            }
            waveOutDevice.PlaybackStopped -= WaveOutDevice_PlaybackStopped;
        }

        private void StopAudio()
        {
            contentPlayingIntel.Text = "Not Playing.";

            if (waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                waveOutDevice.Stop();
                isPlaying = false;
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }

            // Update context menu
            playSoundToolStripMenuItem.Visible = true;
            stopSoundToolStripMenuItem.Visible = false;
        }

        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                performClick(stopBtn);
                string fileName = listBox1.SelectedItem.ToString();
                PlayAudio(fileName);
            }
            else if (listBox1.SelectedItem != null)
            {
                string fileName = listBox1.SelectedItem.ToString();
                PlayAudio(fileName);
            }
            else
            {
                MessageBox.Show("Please select an item from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void volumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            float volume = (float)volumeBar.Value / 100.0f;
            if (volume == 1 || volume >= 1)
            {
                waveOutDevice.Volume = 1;
                volumeStatement.Text = "Volume: " + 1 * 100;
            }
            else
            {
                waveOutDevice.Volume = volume;
                double roundedVolume = Math.Round(volume * 100, 1);
                volumeStatement.Text = $"Volume: {roundedVolume}%";
            }
        }
private string ConvertToWav(string inputFilePath)
{
    try
    {
        string fileName = Path.GetFileNameWithoutExtension(inputFilePath) + ".wav";
        string outputFilePath = Path.Combine(convResFolder, fileName);

        if (Path.GetExtension(inputFilePath).ToLower() == ".wav")
        {
            File.Copy(inputFilePath, outputFilePath, true);
            return outputFilePath;
        }
        else
        {
            using (var reader = new MediaFoundationReader(inputFilePath))
            {
                WaveFileWriter.CreateWaveFile(outputFilePath, reader);
            }
            return outputFilePath;
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error converting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return null;
    }
}

        private void stopBtn_Click(object sender, EventArgs e)
        {
            StopAudio();
        }

        private void soundbadLogo_Click(object sender, EventArgs e)
        {
            new soundbadInfo().Show();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            new addFileDialog().Show();
        }

        private void openDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            openFileDialog1.Filter = "Audio Files|*.wav;*.mp3;*.ogg;*.m4a|Video Files|*.mp4;*.mov;;*.webp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                submitFileLocationBox.Text = openFileDialog1.FileName;
            }
        }
        private void playSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performClick(playPauseBtn);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listBox1.IndexFromPoint(e.Location) >= 0)
                {
                    listBox1.SelectedIndex = listBox1.IndexFromPoint(e.Location);
                    contextMenuStrip1.Show(listBox1, e.Location);
                }
            }
        }

        private void stopSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performClick(stopBtn);
        }
        private void performClick(Control control)
        {
            SendMessage(control.Handle, WM_LBUTTONDOWN, 0, 0);
            SendMessage(control.Handle, WM_LBUTTONUP, 0, 0);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string fileName = listBox1.SelectedItem.ToString();

                if (isPlaying && audioFileReader != null && audioFileReader.FileName.Contains(fileName))
                {
                    performClick(stopBtn);
                }
                else
                {
                    contentPlayingIntel.Text = $"Playing: {Path.GetFileName(fileName)}";
                    performClick(playPauseBtn);
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            client.Dispose();
        }
    }
}
