using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDLSharp;
using YoutubeDLSharp.Metadata;
using YoutubeDLSharp.Options;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ytdl = new YoutubeDL();
            ytdl.OutputFolder = Properties.Settings.Default.save_path;
            ext_btn.DataSource = Enum.GetNames(typeof(VideoRecodeFormat));
            ext_btn.SelectedIndex = 1;
            save_folder_tb.Text = Properties.Settings.Default.save_path;

        }
        YoutubeDL ytdl;

        private void Progress_ProgressChanged(object sender, DownloadProgress e)
        {
            if (e.State == DownloadState.PreProcessing)
            {
                guna2ProgressIndicator1.Visible = true;
            }
            else
            {
                guna2ProgressIndicator1.Visible = false;
                guna2ProgressBar1.Value = Convert.ToInt32(e.Progress * 100);
                eta_lbl.Text = e.ETA;
                speed_lbl.Text = e.DownloadSpeed;
                label10.Text = e.TotalDownloadSize;
            }

        }

        private void fpd_btn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                save_folder_tb.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.save_path = save_folder_tb.Text;
                Properties.Settings.Default.Save();
            }
        }

        private async void video_download_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (url_tb.Text.Trim().Length == 0)
                {
                    MessageBox.Show("الرجاء أدخال رابط الفيديو", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                ytdl.YoutubeDLPath = Application.StartupPath + "\\yt-dlp.exe";
                ytdl.FFmpegPath = Application.StartupPath + "\\ffmpeg.exe";
                var progress = new Progress<DownloadProgress>();
                var cts = new CancellationTokenSource();
                var format = (VideoRecodeFormat)Enum.Parse(typeof(VideoRecodeFormat), ext_btn.Text);
                progress.ProgressChanged += Progress_ProgressChanged;
                var url = url_tb.Text;
                var res = await ytdl.RunVideoDownload(url,
                                                      progress: progress,
                                                      ct: cts.Token,
                                                      recodeFormat: format);
                if (res.Data.Length == 0)
                {
                    MessageBox.Show("الرجاء أدخال رابط فيديو صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                video_download_btn.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                video_download_btn.Enabled = true;
            }


        }
    }
}
