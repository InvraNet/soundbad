namespace soundbad
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.playPauseBtn = new System.Windows.Forms.PictureBox();
            this.stopBtn = new System.Windows.Forms.PictureBox();
            this.soundbadLogo = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.volumeStatement = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.HScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.Button();
            this.openNote = new System.Windows.Forms.Label();
            this.submitFileLocationBox = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contentPlayingIntel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rpcStatus = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundbadLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addItemBtn)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.playPauseBtn);
            this.panel2.Controls.Add(this.stopBtn);
            this.panel2.Controls.Add(this.soundbadLogo);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 34);
            this.panel2.TabIndex = 0;
            // 
            // playPauseBtn
            // 
            this.playPauseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playPauseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPauseBtn.Image = global::soundbad.Properties.Resources.play;
            this.playPauseBtn.Location = new System.Drawing.Point(726, 0);
            this.playPauseBtn.Name = "playPauseBtn";
            this.playPauseBtn.Size = new System.Drawing.Size(76, 34);
            this.playPauseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playPauseBtn.TabIndex = 2;
            this.playPauseBtn.TabStop = false;
            this.playPauseBtn.Click += new System.EventHandler(this.playPauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBtn.Image = global::soundbad.Properties.Resources.stop;
            this.stopBtn.Location = new System.Drawing.Point(632, 0);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(88, 34);
            this.stopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopBtn.TabIndex = 1;
            this.stopBtn.TabStop = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // soundbadLogo
            // 
            this.soundbadLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundbadLogo.ErrorImage = null;
            this.soundbadLogo.Image = global::soundbad.Properties.Resources.soundbad_logo;
            this.soundbadLogo.Location = new System.Drawing.Point(0, 0);
            this.soundbadLogo.Name = "soundbadLogo";
            this.soundbadLogo.Size = new System.Drawing.Size(68, 40);
            this.soundbadLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundbadLogo.TabIndex = 0;
            this.soundbadLogo.TabStop = false;
            this.soundbadLogo.Click += new System.EventHandler(this.soundbadLogo_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(-1, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(802, 402);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.volumeStatement);
            this.panel1.Controls.Add(this.volumeBar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.openDialog);
            this.panel1.Controls.Add(this.openNote);
            this.panel1.Controls.Add(this.submitFileLocationBox);
            this.panel1.Location = new System.Drawing.Point(-1, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 53);
            this.panel1.TabIndex = 3;
            // 
            // volumeStatement
            // 
            this.volumeStatement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeStatement.AutoSize = true;
            this.volumeStatement.Location = new System.Drawing.Point(514, 7);
            this.volumeStatement.Name = "volumeStatement";
            this.volumeStatement.Size = new System.Drawing.Size(48, 13);
            this.volumeStatement.TabIndex = 5;
            this.volumeStatement.Text = "Volume: ";
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeBar.Location = new System.Drawing.Point(514, 23);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(275, 23);
            this.volumeBar.TabIndex = 4;
            this.volumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeBar_Scroll);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(312, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openDialog
            // 
            this.openDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openDialog.Location = new System.Drawing.Point(281, 22);
            this.openDialog.Name = "openDialog";
            this.openDialog.Size = new System.Drawing.Size(25, 23);
            this.openDialog.TabIndex = 2;
            this.openDialog.Text = "...";
            this.openDialog.UseVisualStyleBackColor = true;
            this.openDialog.Click += new System.EventHandler(this.openDialog_Click);
            // 
            // openNote
            // 
            this.openNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openNote.AutoSize = true;
            this.openNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openNote.Location = new System.Drawing.Point(4, 6);
            this.openNote.Name = "openNote";
            this.openNote.Size = new System.Drawing.Size(265, 15);
            this.openNote.TabIndex = 1;
            this.openNote.Text = "Please use items below to open and add new file.";
            // 
            // submitFileLocationBox
            // 
            this.submitFileLocationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.submitFileLocationBox.Location = new System.Drawing.Point(7, 24);
            this.submitFileLocationBox.Name = "submitFileLocationBox";
            this.submitFileLocationBox.Size = new System.Drawing.Size(268, 20);
            this.submitFileLocationBox.TabIndex = 0;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemBtn.Image = global::soundbad.Properties.Resources.add;
            this.addItemBtn.Location = new System.Drawing.Point(771, 407);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(27, 27);
            this.addItemBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addItemBtn.TabIndex = 6;
            this.addItemBtn.TabStop = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contentPlayingIntel
            // 
            this.contentPlayingIntel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.contentPlayingIntel.AutoSize = true;
            this.contentPlayingIntel.Location = new System.Drawing.Point(3, 491);
            this.contentPlayingIntel.Name = "contentPlayingIntel";
            this.contentPlayingIntel.Size = new System.Drawing.Size(92, 13);
            this.contentPlayingIntel.TabIndex = 4;
            this.contentPlayingIntel.Text = "Not playing sound";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playSoundToolStripMenuItem,
            this.stopSoundToolStripMenuItem,
            this.deleteSoundToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 70);
            // 
            // playSoundToolStripMenuItem
            // 
            this.playSoundToolStripMenuItem.Name = "playSoundToolStripMenuItem";
            this.playSoundToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.playSoundToolStripMenuItem.Text = "Play Sound";
            this.playSoundToolStripMenuItem.Click += new System.EventHandler(this.playSoundToolStripMenuItem_Click);
            // 
            // stopSoundToolStripMenuItem
            // 
            this.stopSoundToolStripMenuItem.Name = "stopSoundToolStripMenuItem";
            this.stopSoundToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.stopSoundToolStripMenuItem.Text = "Stop Sound";
            this.stopSoundToolStripMenuItem.Click += new System.EventHandler(this.stopSoundToolStripMenuItem_Click);
            // 
            // deleteSoundToolStripMenuItem
            // 
            this.deleteSoundToolStripMenuItem.Name = "deleteSoundToolStripMenuItem";
            this.deleteSoundToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deleteSoundToolStripMenuItem.Text = "Delete Sound";
            // 
            // rpcStatus
            // 
            this.rpcStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rpcStatus.Location = new System.Drawing.Point(666, 491);
            this.rpcStatus.Name = "rpcStatus";
            this.rpcStatus.Size = new System.Drawing.Size(138, 13);
            this.rpcStatus.TabIndex = 7;
            this.rpcStatus.Text = "Discord RPC Enabled.";
            this.rpcStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rpcStatus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(803, 508);
            this.Controls.Add(this.rpcStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.contentPlayingIntel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Soundbad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playPauseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundbadLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addItemBtn)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox soundbadLogo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox submitFileLocationBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openDialog;
        private System.Windows.Forms.Label openNote;
        private System.Windows.Forms.Label volumeStatement;
        private System.Windows.Forms.HScrollBar volumeBar;
        private System.Windows.Forms.PictureBox playPauseBtn;
        private System.Windows.Forms.PictureBox stopBtn;
        private System.Windows.Forms.Label contentPlayingIntel;
        private System.Windows.Forms.PictureBox addItemBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopSoundToolStripMenuItem;
        private System.Windows.Forms.Label rpcStatus;
    }
}

