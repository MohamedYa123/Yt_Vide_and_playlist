
namespace ytDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDownload = new System.Windows.Forms.TabPage();
            this.audioonly = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.audiocombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.qualitycombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dataprogress = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbVideoDetails = new System.Windows.Forms.GroupBox();
            this.btnDownload = new Guna.UI2.WinForms.Guna2Button();
            this.chkAudioOnly = new System.Windows.Forms.CheckBox();
            this.lblAudio = new System.Windows.Forms.Label();
            this.cmbAudioQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.cmbQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.txtUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bgWorkerGetVideo = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Downloader_BackProcess = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDownload.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grbVideoDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDownload);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 567);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDownload
            // 
            this.tabDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabDownload.Controls.Add(this.label3);
            this.tabDownload.Controls.Add(this.audioonly);
            this.tabDownload.Controls.Add(this.label2);
            this.tabDownload.Controls.Add(this.label1);
            this.tabDownload.Controls.Add(this.btnBrowse);
            this.tabDownload.Controls.Add(this.audiocombo);
            this.tabDownload.Controls.Add(this.txtFilePath);
            this.tabDownload.Controls.Add(this.lblPath);
            this.tabDownload.Controls.Add(this.guna2Button1);
            this.tabDownload.Controls.Add(this.textBox1);
            this.tabDownload.Controls.Add(this.qualitycombo);
            this.tabDownload.Controls.Add(this.statusStrip1);
            this.tabDownload.Controls.Add(this.grbVideoDetails);
            this.tabDownload.Controls.Add(this.btnStart);
            this.tabDownload.Controls.Add(this.txtUrl);
            this.tabDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDownload.Location = new System.Drawing.Point(4, 26);
            this.tabDownload.Margin = new System.Windows.Forms.Padding(4);
            this.tabDownload.Name = "tabDownload";
            this.tabDownload.Padding = new System.Windows.Forms.Padding(4);
            this.tabDownload.Size = new System.Drawing.Size(1037, 537);
            this.tabDownload.TabIndex = 0;
            this.tabDownload.Text = "Download";
            // 
            // audioonly
            // 
            this.audioonly.AutoSize = true;
            this.audioonly.Location = new System.Drawing.Point(741, 96);
            this.audioonly.Margin = new System.Windows.Forms.Padding(4);
            this.audioonly.Name = "audioonly";
            this.audioonly.Size = new System.Drawing.Size(111, 22);
            this.audioonly.TabIndex = 11;
            this.audioonly.Text = "Audio Only";
            this.audioonly.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Audio Quality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Video Quality";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Location = new System.Drawing.Point(931, 142);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(45, 42);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // audiocombo
            // 
            this.audiocombo.BackColor = System.Drawing.Color.Transparent;
            this.audiocombo.BorderRadius = 15;
            this.audiocombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.audiocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audiocombo.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.audiocombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.audiocombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.audiocombo.FocusedState.Parent = this.audiocombo;
            this.audiocombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.audiocombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.audiocombo.HoverState.Parent = this.audiocombo;
            this.audiocombo.ItemHeight = 30;
            this.audiocombo.Items.AddRange(new object[] {
            "128",
            "48"});
            this.audiocombo.ItemsAppearance.Parent = this.audiocombo;
            this.audiocombo.Location = new System.Drawing.Point(519, 82);
            this.audiocombo.Margin = new System.Windows.Forms.Padding(4);
            this.audiocombo.Name = "audiocombo";
            this.audiocombo.ShadowDecoration.Parent = this.audiocombo;
            this.audiocombo.Size = new System.Drawing.Size(185, 36);
            this.audiocombo.TabIndex = 11;
            // 
            // txtFilePath
            // 
            this.txtFilePath.BorderRadius = 15;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.DefaultText = "";
            this.txtFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.DisabledState.Parent = this.txtFilePath;
            this.txtFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.FillColor = System.Drawing.Color.LightSteelBlue;
            this.txtFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.FocusedState.Parent = this.txtFilePath;
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.HoverState.Parent = this.txtFilePath;
            this.txtFilePath.Location = new System.Drawing.Point(110, 142);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.PlaceholderText = "";
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.ShadowDecoration.Parent = this.txtFilePath;
            this.txtFilePath.Size = new System.Drawing.Size(813, 44);
            this.txtFilePath.TabIndex = 7;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(21, 155);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(72, 20);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Save to";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Firebrick;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(928, 437);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.IndianRed;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(100, 55);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Start";
            this.guna2Button1.Visible = false;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderRadius = 15;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "Enter Playlist link";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.Parent = this.textBox1;
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FillColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.FocusedState.Parent = this.textBox1;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.HoverState.Parent = this.textBox1;
            this.textBox1.Location = new System.Drawing.Point(821, 437);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PlaceholderText = "";
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionStart = 19;
            this.textBox1.ShadowDecoration.Parent = this.textBox1;
            this.textBox1.Size = new System.Drawing.Size(80, 44);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // qualitycombo
            // 
            this.qualitycombo.BackColor = System.Drawing.Color.Transparent;
            this.qualitycombo.BorderRadius = 15;
            this.qualitycombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.qualitycombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualitycombo.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.qualitycombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qualitycombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qualitycombo.FocusedState.Parent = this.qualitycombo;
            this.qualitycombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.qualitycombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.qualitycombo.HoverState.Parent = this.qualitycombo;
            this.qualitycombo.ItemHeight = 30;
            this.qualitycombo.Items.AddRange(new object[] {
            "1080",
            "144",
            "240",
            "360",
            "480",
            "720"});
            this.qualitycombo.ItemsAppearance.Parent = this.qualitycombo;
            this.qualitycombo.Location = new System.Drawing.Point(163, 82);
            this.qualitycombo.Margin = new System.Windows.Forms.Padding(4);
            this.qualitycombo.Name = "qualitycombo";
            this.qualitycombo.ShadowDecoration.Parent = this.qualitycombo;
            this.qualitycombo.Size = new System.Drawing.Size(185, 36);
            this.qualitycombo.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status,
            this.Dataprogress});
            this.statusStrip1.Location = new System.Drawing.Point(4, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1029, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 16);
            // 
            // Dataprogress
            // 
            this.Dataprogress.Name = "Dataprogress";
            this.Dataprogress.Size = new System.Drawing.Size(0, 16);
            // 
            // grbVideoDetails
            // 
            this.grbVideoDetails.Controls.Add(this.btnDownload);
            this.grbVideoDetails.Controls.Add(this.chkAudioOnly);
            this.grbVideoDetails.Controls.Add(this.lblAudio);
            this.grbVideoDetails.Controls.Add(this.cmbAudioQuality);
            this.grbVideoDetails.Controls.Add(this.lblVideo);
            this.grbVideoDetails.Controls.Add(this.cmbQuality);
            this.grbVideoDetails.Controls.Add(this.txtTitle);
            this.grbVideoDetails.Controls.Add(this.lblTitle);
            this.grbVideoDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.grbVideoDetails.Location = new System.Drawing.Point(0, 194);
            this.grbVideoDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grbVideoDetails.Name = "grbVideoDetails";
            this.grbVideoDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grbVideoDetails.Size = new System.Drawing.Size(1040, 225);
            this.grbVideoDetails.TabIndex = 2;
            this.grbVideoDetails.TabStop = false;
            this.grbVideoDetails.Text = "Video Details";
            // 
            // btnDownload
            // 
            this.btnDownload.BorderRadius = 20;
            this.btnDownload.CheckedState.Parent = this.btnDownload;
            this.btnDownload.CustomImages.Parent = this.btnDownload;
            this.btnDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownload.DisabledState.Parent = this.btnDownload;
            this.btnDownload.FillColor = System.Drawing.Color.Firebrick;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.HoverState.Parent = this.btnDownload;
            this.btnDownload.Location = new System.Drawing.Point(799, 87);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.PressedColor = System.Drawing.Color.IndianRed;
            this.btnDownload.ShadowDecoration.Parent = this.btnDownload;
            this.btnDownload.Size = new System.Drawing.Size(184, 55);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // chkAudioOnly
            // 
            this.chkAudioOnly.AutoSize = true;
            this.chkAudioOnly.Location = new System.Drawing.Point(673, 193);
            this.chkAudioOnly.Margin = new System.Windows.Forms.Padding(4);
            this.chkAudioOnly.Name = "chkAudioOnly";
            this.chkAudioOnly.Size = new System.Drawing.Size(111, 22);
            this.chkAudioOnly.TabIndex = 9;
            this.chkAudioOnly.Text = "Audio Only";
            this.chkAudioOnly.UseVisualStyleBackColor = true;
            this.chkAudioOnly.Visible = false;
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudio.Location = new System.Drawing.Point(393, 117);
            this.lblAudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(121, 20);
            this.lblAudio.TabIndex = 5;
            this.lblAudio.Text = "Audio Quality";
            this.lblAudio.Visible = false;
            // 
            // cmbAudioQuality
            // 
            this.cmbAudioQuality.BackColor = System.Drawing.Color.Transparent;
            this.cmbAudioQuality.BorderRadius = 15;
            this.cmbAudioQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAudioQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioQuality.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbAudioQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAudioQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAudioQuality.FocusedState.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAudioQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAudioQuality.HoverState.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.ItemHeight = 30;
            this.cmbAudioQuality.ItemsAppearance.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.Location = new System.Drawing.Point(539, 106);
            this.cmbAudioQuality.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAudioQuality.Name = "cmbAudioQuality";
            this.cmbAudioQuality.ShadowDecoration.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.Size = new System.Drawing.Size(185, 36);
            this.cmbAudioQuality.TabIndex = 4;
            this.cmbAudioQuality.Visible = false;
            this.cmbAudioQuality.SelectedIndexChanged += new System.EventHandler(this.cmbAudioQuality_SelectedIndexChanged);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(11, 117);
            this.lblVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(121, 20);
            this.lblVideo.TabIndex = 3;
            this.lblVideo.Text = "Video Quality";
            this.lblVideo.Visible = false;
            // 
            // cmbQuality
            // 
            this.cmbQuality.BackColor = System.Drawing.Color.Transparent;
            this.cmbQuality.BorderRadius = 15;
            this.cmbQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuality.FocusedState.Parent = this.cmbQuality;
            this.cmbQuality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbQuality.HoverState.Parent = this.cmbQuality;
            this.cmbQuality.ItemHeight = 30;
            this.cmbQuality.ItemsAppearance.Parent = this.cmbQuality;
            this.cmbQuality.Location = new System.Drawing.Point(156, 106);
            this.cmbQuality.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.ShadowDecoration.Parent = this.cmbQuality;
            this.cmbQuality.Size = new System.Drawing.Size(185, 36);
            this.cmbQuality.TabIndex = 2;
            this.cmbQuality.Visible = false;
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 15;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.Parent = this.txtTitle;
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FillColor = System.Drawing.Color.LightSteelBlue;
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.FocusedState.Parent = this.txtTitle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.HoverState.Parent = this.txtTitle;
            this.txtTitle.Location = new System.Drawing.Point(81, 25);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.ShadowDecoration.Parent = this.txtTitle;
            this.txtTitle.Size = new System.Drawing.Size(881, 44);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 37);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 20;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.DisabledState.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.Firebrick;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(821, 5);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.PressedColor = System.Drawing.Color.IndianRed;
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(203, 55);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.BorderRadius = 15;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.DefaultText = "Enter video link";
            this.txtUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.DisabledState.Parent = this.txtUrl;
            this.txtUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.FillColor = System.Drawing.Color.LightSteelBlue;
            this.txtUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.FocusedState.Parent = this.txtUrl;
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.HoverState.Parent = this.txtUrl;
            this.txtUrl.Location = new System.Drawing.Point(11, 7);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.PlaceholderText = "";
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionStart = 16;
            this.txtUrl.ShadowDecoration.Parent = this.txtUrl;
            this.txtUrl.Size = new System.Drawing.Size(792, 44);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.txtUrl.Enter += new System.EventHandler(this.txtUrl_Enter);
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // tabHelp
            // 
            this.tabHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHelp.Location = new System.Drawing.Point(4, 26);
            this.tabHelp.Margin = new System.Windows.Forms.Padding(4);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(4);
            this.tabHelp.Size = new System.Drawing.Size(1037, 537);
            this.tabHelp.TabIndex = 1;
            this.tabHelp.Text = "Help";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 575);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1024, 34);
            this.progressBar1.TabIndex = 3;
            // 
            // bgWorkerGetVideo
            // 
            this.bgWorkerGetVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerGetVideo_DoWork);
            // 
            // Downloader_BackProcess
            // 
            this.Downloader_BackProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Downloader_BackProcess_DoWork);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Video 0/0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1045, 666);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Video Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDownload.ResumeLayout(false);
            this.tabDownload.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grbVideoDetails.ResumeLayout(false);
            this.grbVideoDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDownload;
        private System.Windows.Forms.GroupBox grbVideoDetails;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
        private System.Windows.Forms.CheckBox chkAudioOnly;
        private System.Windows.Forms.Button btnBrowse;
        private Guna.UI2.WinForms.Guna2TextBox txtFilePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblAudio;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAudioQuality;
        private System.Windows.Forms.Label lblVideo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbQuality;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2TextBox txtUrl;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripStatusLabel Dataprogress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bgWorkerGetVideo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker Downloader_BackProcess;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox qualitycombo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox audiocombo;
        private System.Windows.Forms.CheckBox audioonly;
        private System.Windows.Forms.Label label3;
    }
}

