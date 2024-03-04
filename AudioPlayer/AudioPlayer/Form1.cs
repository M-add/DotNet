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
using NAudio.Wave;
using TagLib;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        private WaveOut waveOut;
        private AudioFileReader audioFile;
        CoreAudioDevice Volume;

        private List<string> playlist = new List<string>();
        private bool isPlaying = false;
        private int currentSongIndex = 0;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            waveOut = new WaveOut();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += UpdateProgress;

            volumeSlider.ValueChanged += OnVolumeChange;
        }

        private void OnVolumeChange(object sender, float e)
        {
            Volume.SetVolumeAsync(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlaybackButton.DataBindings.Add("Size", PrevButton, "Size");
            NextButton.DataBindings.Add("Size", PrevButton, "Size");
            SongButton.DataBindings.Add("Size", PrevButton, "Size");

            Volume = new CoreAudioController().DefaultPlaybackDevice;
            volumeSlider.Value = ((100 - (float)Volume.Volume) * volumeSlider.Height) / 100;
        }

        private void PlaybackButtonClick(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    CreatePlaylist(folderPath);
                }
            }
        }

        private void CreatePlaylist(string folderPath)
        {
            playlist.Clear();

            string[] audioExtensions = { ".mp3", ".wav" };
            foreach (string extension in audioExtensions)
            {
                foreach (string filePath in Directory.GetFiles
                    (folderPath, "*" + extension, SearchOption.AllDirectories))
                {
                    playlist.Add(filePath);
                }
            }

            PlayAudio(playlist[0]);
        }

        private void PlayAudio(string filePath)
        {
            try
            {
                if (waveOut != null)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                }

                waveOut = new WaveOut();
                audioFile = new AudioFileReader(filePath);

                //Song thumbnail Extraction
                TagLib.File file = TagLib.File.Create(filePath);
                var memoryStream = new MemoryStream();
                var firstPicture = file.Tag.Pictures.FirstOrDefault();
                if (firstPicture != null)
                {
                    byte[] data = firstPicture.Data.Data;
                    memoryStream.Write(data, 0, Convert.ToInt32(data.Length));

                    var bitmap = new Bitmap(memoryStream, false);
                    memoryStream.Dispose();

                    AlbumPicture.Image = bitmap;
                }
                else
                {
                    AlbumPicture.Image = Properties.Resources.tunes;
                }

                waveOut.DesiredLatency = 100;
                waveOut.Init(audioFile);

                PlaybackButton.Text = "▐▐";
                waveOut.Play(); 
                timer.Start();

                waveOut.PlaybackStopped += PlaybackStopped;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing audio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgress(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                PlayBackBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                PlayBackBar.Value = (int)audioFile.CurrentTime.TotalSeconds;

                PlayBackBar.Invalidate();
                StartLabel.Text = audioFile.CurrentTime.ToString(@"mm\:ss");
                EndLabel.Text = audioFile.TotalTime.ToString(@"mm\:ss");
            }
            else
            {
                timer.Stop();
            }
        }

        private void PlaybackStopped(object sender, StoppedEventArgs e)
        {
            currentSongIndex++;
            if (currentSongIndex < playlist.Count)
            {
                PlayAudio(playlist[currentSongIndex]);
            }
        }

        private void PlaybackButton_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 0)
            {
                PlaybackButton.Text = PlaybackButton.Text == "▶" ? "▐▐" : "▶";
                isPlaying = !isPlaying;
                if (!isPlaying)
                {
                    waveOut.Resume();
                }
                else
                {
                    waveOut.Pause();
                }
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (currentSongIndex > 0)
            {
                currentSongIndex--;
                PlayAudio(playlist[currentSongIndex]);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentSongIndex < playlist.Count - 1)
            {
                currentSongIndex++;
                PlayAudio(playlist[currentSongIndex]);
            }
        }

        private void PlayBackBarMouseClick(object sender, MouseEventArgs e)
        {
            float relativeX = e.X / (float)PlayBackBar.Width;
            int newValue = (int)(relativeX * PlayBackBar.Maximum);
            PlayBackBar.Value = newValue;

            if (audioFile != null)
            {
                audioFile.CurrentTime = TimeSpan.FromSeconds(PlayBackBar.Value);
            }
        }
        private void PlayBackBarMouseMove(object sender, MouseEventArgs e)
        {
            float relativeX = e.X / (float)PlayBackBar.Width;
            int newValue = (int)(relativeX * PlayBackBar.Maximum);
            PlayBackBar.Value = newValue;
            if (audioFile != null)
            {
                audioFile.CurrentTime = TimeSpan.FromSeconds(PlayBackBar.Value);
                PlayBackBar.Refresh();
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PrevButton.Location = new Point((PlaybackPanel.Width * 30) / 100, PrevButton.Location.Y);
            PlaybackButton.Location = new Point((PlaybackPanel.Width * 44) / 100, PrevButton.Location.Y);
            NextButton.Location = new Point((PlaybackPanel.Width * 58) / 100, PrevButton.Location.Y);

            PrevButton.Width = (PlaybackPanel.Width * 13) / 100;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.X >= 718 && e.Y <= 387)
            {
                volumeSlider.Visible = true;
            }
            else
            {
                volumeSlider.Visible = false;
            }
        }
    }
}
