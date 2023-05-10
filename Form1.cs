using FFMpegCore;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using Xabe.FFmpeg.Downloader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ytDownloader
{

    public partial class Form1 : Form
    {
        private YouTube youtube = YouTube.Default;
        public HashSet<string> videoId = new HashSet<string>();
        private long totalbytes = 0;
        private long collctedbytes = 0;
        private string selectedVideoQuality = "";
        private string selectedAudioQuality = "";
        private static string re = @"list=([A-z0-9-]+(&|$))";
        private static Regex listreg = new Regex(re);
        private static string watchLink = "https://www.youtube.com/watch?v=";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            audiocombo.SelectedIndex = 0;
            qualitycombo.SelectedIndex = 0;
            grbVideoDetails.Visible = true;
            //webBrowser1.ScriptErrorsSuppressed = true;
            grbVideoDetails.Visible = false;
            progressBar1.Visible = false;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text.Contains("playlist"))
            {
                textBox1.Text = txtUrl.Text;
               
                guna2Button1.PerformClick();
            }
            grbVideoDetails.Visible = true;
            await Task.Run(() =>
            {
                while(true)
                {
                    Thread.Sleep(10);
                    if(done) break;
                }
               
            });
           
            chkAudioOnly.Checked = audioonly.Checked;
            cmbAudioQuality.SelectedIndex = audiocombo.SelectedIndex;
            cmbQuality.SelectedIndex = qualitycombo.SelectedIndex;
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            if (!bgWorkerGetVideo.IsBusy)
                bgWorkerGetVideo.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                    txtFilePath.Text = folderDialog.SelectedPath + "\\";
                else
                    txtFilePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }
        bool done=false;
        private void GetVideoData(string link, bool playlist = false)
        {
            var videoData = youtube.GetAllVideos(link);
            var resolution = videoData.Where(r => r.AdaptiveKind == AdaptiveKind.Video && r.Format == VideoFormat.Mp4).
                             Select(r => r.Resolution);
            var bitRate = videoData.Where(r => r.AdaptiveKind == AdaptiveKind.Audio).Select(r => r.AudioBitrate);
            foreach (var item in resolution)
            {
                if(!cmbQuality.Items.Contains(item))
                    cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.Items.Add(item)));
            }
            foreach (var item in bitRate)
            {
                if(!cmbAudioQuality.Items.Contains(item))
                    cmbAudioQuality.Invoke((MethodInvoker)(() => cmbAudioQuality.Items.Add(item)));
            }

            if (cmbQuality.Items.Count > 0)
            {
                cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.Sorted = true));
                cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.SelectedIndex = 0));
                cmbAudioQuality.Invoke((MethodInvoker)(() => cmbAudioQuality.Sorted = true));
                cmbAudioQuality.Invoke((MethodInvoker)(() => cmbAudioQuality.SelectedIndex = 0));
                txtTitle.Invoke((MethodInvoker)(() => txtTitle.Text = videoData.ToList()[0].Title));
            }
            if (playlist)
                Status.Text = videoId.Count + "Videos";
            else
                Status.Text = "Single Video";
             done = true;
        }

        private void EmptyUrl()
        {
            cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.Items.Clear()));
            cmbAudioQuality.Invoke((MethodInvoker)(() => cmbAudioQuality.Items.Clear()));
            txtTitle.Invoke((MethodInvoker)(() => txtTitle.Text = ""));
            selectedVideoQuality = "";
            selectedAudioQuality = "";
        }

        private void bgWorkerGetVideo_DoWork(object sender, DoWorkEventArgs e)
        {
            videoId.Clear();
            Status.Text = "Processing link...";
            if (txtUrl.Text == "")
            {
                EmptyUrl();
                Status.Text = "Empty or Invalid Link";
            }
            else
            {
                try
                {
                    Match m = listreg.Match(txtUrl.Text);
                    if (m.Success)
                    {
                        string listId = m.Groups[1].Value;
                        using (var client = new WebClient())
                        {
                            var responseString = client.DownloadString(txtUrl.Text);
                            string re2 = "\"videoId\":\"([A-z0-9-]+)\",\"playlistId\":\"" + listId + "\"";
                            Regex listOfVideos = new Regex(re);
                            foreach (Match ma in listOfVideos.Matches(responseString))
                            {
                                videoId.Add(ma.Groups[1].Value);
                            }
                            if (videoId.Count > 0)
                                GetVideoData(watchLink + videoId.ElementAt(0), true);
                        }
                    }
                    else
                        GetVideoData(txtUrl.Text);
                }
                catch 
                {
                    EmptyUrl();
                    Status.Text = "Invalid Link";
                }
            }
        }

        private string ByteConverter(long b)
        {
            string final;
            //to kb 
            float c = (float)b;
            c /= 1024;
            final = c.ToString("0.00") + " KB";
            if (c >= (float)1)
            {//to mb
                c /= 1024;
                final = c.ToString("0.00") + " MB";
            }
            else if (c >= (float)1)
            {
                //to gb
                c /= 1024;
                final = c.ToString("0.00") + " GB";
            }
            return final;
        }
        
        private void btnDownload_Click(object sender, EventArgs e)
        {
            done = false; 
            progressBar1.Visible = true;
            if (Downloader_BackProcess.IsBusy != true)
                Downloader_BackProcess.RunWorkerAsync();
        }

        private void FileDelete(string pa)
        {
            if (File.Exists(pa))
                File.Delete(pa);
        }
        int rd;
        bool check(ref int read,System.IO.Stream input, byte[] buffer)
        {
            while (true)
            {
                try
                {
                    if ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        rd = read;
                        return true;
                    }
                    else
                    {
                        rd = read;
                        return false;
                    }
                }
                catch (Exception ex){ break; }
            }
            return false;
        }
        long gx = 0;
        async void Downloader_BackProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            totalbytes = 0;
            collctedbytes = 0;
            string audiomp4 = "Audio.mp4";
            string Audiomp3 = "Audio.mp3";
            string VideoFile = "Video.mp4";
            Status.Text = "Checking tools";
            async Task SourceDownloader(string name, YouTubeVideo vid)
            {
                var client = new HttpClient();
                long? totalByte = 0;
                using (Stream output = File.OpenWrite(name))
                {
                    using (var request = new HttpRequestMessage(HttpMethod.Head, vid.Uri))
                    {
                        totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;
                    }
                    totalbytes += (long)totalByte;
                    using (var input = await client.GetStreamAsync(vid.Uri))
                    {
                        byte[] buffer = new byte[16 * 1024];
                        int read=0;
                        int totalRead = 0;

                        while (check(ref  read, input,  buffer))
                        {
                            output.Write(buffer, 0, read);
                            totalRead += read;
                            collctedbytes += read;
                            if (totalbytes == 0)
                            {
                                totalbytes = 1;
                                collctedbytes = 0;
                            }
                            long x = collctedbytes * 100 / totalbytes;
                            gx = x;
                            Dataprogress.Text = ByteConverter(collctedbytes) + "/" + ByteConverter(totalbytes);
                            progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = (int)x));
                        }
                    }
                }
                client.Dispose();
            }
            await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Full);
            async Task DownloadWork(string link, int playlist = -1)
            {
                if (playlist < 0)
                    Status.Text = "Downloading...";
                else
                    Status.Text = (playlist + 1).ToString() + "/" + videoId.Count.ToString();
                var video = youtube.GetAllVideos(link);
                var Targetaudio = video.Where(r => r.AdaptiveKind == AdaptiveKind.Audio &&
                r.AudioBitrate.ToString() == selectedAudioQuality).Select(r => r);

                var TargetVideo = video.Where(r => r.AdaptiveKind == AdaptiveKind.Video &&
                r.Format == VideoFormat.Mp4 && r.Resolution.ToString() == selectedVideoQuality).Select(r => r);

                txtTitle.Invoke((MethodInvoker)(() => txtTitle.Text = video.ToList()[0].Title));
                Task au = SourceDownloader(audiomp4, Targetaudio.ToList()[0]);
                if (chkAudioOnly.Checked != true)
                {
                    Task vide = SourceDownloader(VideoFile, TargetVideo.ToList()[0]);
                    await au;
                    FFMpeg.ExtractAudio(audiomp4, Audiomp3);
                    File.Delete(audiomp4);
                    await vide;
                    FFMpeg.ReplaceAudio(VideoFile, Audiomp3, "temp.mp4");

                    FileDelete(VideoFile);
                    FileDelete(Audiomp3);
                    var f = TargetVideo.ToList()[0].FullName;
                    var xx = f ;
                    try
                    {
                        File.Move("temp.mp4", txt+title + xx);
                    }
                    catch { }
                }
                else
                {
                    var ff = TargetVideo.ToList()[0].Title.Replace(".mp4", ".mp3");
                    await au;
                    FFMpeg.ExtractAudio(audiomp4, "temp.mp3");
                    FileDelete(audiomp4);
                    var f =ff;
                    var xx = f ;
                    try
                    {
                        File.Move("temp.mp3", txt+title + xx+".mp3");
                    }catch { }
                }
                if (playlist < 0)
                    Status.Text = "Completed";
                else
                    Status.Text = "Done (" + (playlist + 1).ToString() + "/" + videoId.Count.ToString() + ")";
                Dataprogress.Text = "";
            }
            if (videoId.Count > 0)
            {
                for (int i = 0; i < videoId.Count; i++)
                {
                    await DownloadWork(watchLink + videoId.ElementAt(i), i);
                }
            }
            else
            {
                await DownloadWork(txtUrl.Text);
            }
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVideoQuality = cmbQuality.SelectedItem.ToString();
        }

        private void cmbAudioQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAudioQuality = cmbAudioQuality.SelectedItem.ToString();
        }

        private void txtUrl_Enter(object sender, EventArgs e)
        {
            if (txtUrl.Text == "Enter video link")
            {
                txtUrl.Text = "";
                txtUrl.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            if (txtUrl.Text.Length == 0)
            {
                txtUrl.Text = "Enter video link";
                txtUrl.ForeColor = SystemColors.GrayText;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }
        List<string> results;
        int indx = 0;
        string title;
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            
            await Task.Run(() =>
            {

                using (WebClient webClient = new WebClient())
                {
                    var a = webClient.DownloadString(txtUrl.Text);
                    var regex = new Regex("<title>.+</title>");
                    var m=regex.Match(a).Value;
                     title = m.Replace("<title>", "").Replace("</title>", "").Trim();
                   // txt += title;
                    
                    try
                    {
                        Directory.CreateDirectory(txt+title);
                    }catch (Exception ex) { }
                    title += "/";
                }
                // Set up the YouTube Data API service

                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyAW54ymElH-yn3Rj6IX14iuDau09pABUd4",
                    ApplicationName = "YOUR_APPLICATION_NAME_HERE"
                });

                // Set up the playlist request
                var playlistRequest = youtubeService.PlaylistItems.List("snippet");
                playlistRequest.PlaylistId = textBox1.Text.Replace("https://www.youtube.com/playlist?list=", "");
                playlistRequest.MaxResults = 50;

                // Execute the playlist request and retrieve the video links
                var playlistResponse = playlistRequest.Execute();
                results = new List<string>();
                indx = 0;
                foreach (var playlistItem in playlistResponse.Items)
                {
                    var videoId = playlistItem.Snippet.ResourceId.VideoId;
                    var videoLink = $"https://www.youtube.com/watch?v={videoId}";
                    //  Console.WriteLine(videoLink);
                    results.Add(videoLink);
                }
                gx = 100;
            });
            Status.Text = "Completed";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Playlist link")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtUrl.Text.Length == 0)
            {
                txtUrl.Text = "Enter Playlist link";
                txtUrl.ForeColor = SystemColors.GrayText;
            }
        }
        bool plalylist=false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            try
            {
                if ( Status.Text == "Completed")
                {
                    txtUrl.Text = results[indx];
                    indx++;
                    gx = 0;
                    plalylist= true;
                //    Thread.Sleep(1000);
                  //  btnDownload.PerformClick();
                 
                }
                if(done&&plalylist)
                {
                    chkAudioOnly.Checked = audioonly.Checked;
                    cmbAudioQuality.SelectedIndex = audiocombo.SelectedIndex;
                    cmbQuality.SelectedIndex = qualitycombo.SelectedIndex;
                    btnDownload.PerformClick();
                }
                label3.Text = $"Video {indx}/{results.Count}";
            }
            catch (Exception ex) { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            grbVideoDetails.Visible = true;
        }
        string txt;
        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            txt=txtFilePath.Text;
        }
    }
}
