namespace soundbad
{
    partial class soundbadInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(soundbadInfo));
            this.branding = new System.Windows.Forms.Label();
            this.paragraph = new System.Windows.Forms.Label();
            this.optionPicker = new System.Windows.Forms.TrackBar();
            this.doAction = new System.Windows.Forms.Button();
            this.brandingLogo = new System.Windows.Forms.PictureBox();
            this.trackInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.optionPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandingLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // branding
            // 
            this.branding.Dock = System.Windows.Forms.DockStyle.Top;
            this.branding.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.branding.Location = new System.Drawing.Point(0, 83);
            this.branding.Name = "branding";
            this.branding.Size = new System.Drawing.Size(279, 32);
            this.branding.TabIndex = 1;
            this.branding.Text = "Soundbad";
            this.branding.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // paragraph
            // 
            this.paragraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.paragraph.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.paragraph.Location = new System.Drawing.Point(0, 115);
            this.paragraph.Name = "paragraph";
            this.paragraph.Size = new System.Drawing.Size(279, 71);
            this.paragraph.TabIndex = 2;
            this.paragraph.Text = "This is a stupid app is made in WinForms.\r\nThis uses NAudio for Audio Mixing.\r\nTo" +
    "ol is made by the terrible dev InvraNet\r\n\r\n";
            this.paragraph.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optionPicker
            // 
            this.optionPicker.LargeChange = 1;
            this.optionPicker.Location = new System.Drawing.Point(0, 230);
            this.optionPicker.Name = "optionPicker";
            this.optionPicker.Size = new System.Drawing.Size(291, 45);
            this.optionPicker.TabIndex = 3;
            this.optionPicker.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.optionPicker.ValueChanged += new System.EventHandler(this.optionPicker_ValueChanged);
            // 
            // doAction
            // 
            this.doAction.Location = new System.Drawing.Point(178, 206);
            this.doAction.Name = "doAction";
            this.doAction.Size = new System.Drawing.Size(94, 23);
            this.doAction.TabIndex = 4;
            this.doAction.Text = "Indexing";
            this.doAction.UseVisualStyleBackColor = true;
            this.doAction.Click += new System.EventHandler(this.doAction_Click);
            // 
            // brandingLogo
            // 
            this.brandingLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandingLogo.Image = global::soundbad.Properties.Resources.soundbad_logo;
            this.brandingLogo.Location = new System.Drawing.Point(0, 0);
            this.brandingLogo.Name = "brandingLogo";
            this.brandingLogo.Size = new System.Drawing.Size(279, 83);
            this.brandingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brandingLogo.TabIndex = 0;
            this.brandingLogo.TabStop = false;
            // 
            // trackInfo
            // 
            this.trackInfo.AutoSize = true;
            this.trackInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trackInfo.Location = new System.Drawing.Point(9, 210);
            this.trackInfo.Name = "trackInfo";
            this.trackInfo.Size = new System.Drawing.Size(167, 15);
            this.trackInfo.TabIndex = 5;
            this.trackInfo.Text = "Pick an item with the trackbar.";
            // 
            // soundbadInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 266);
            this.ControlBox = false;
            this.Controls.Add(this.trackInfo);
            this.Controls.Add(this.paragraph);
            this.Controls.Add(this.branding);
            this.Controls.Add(this.doAction);
            this.Controls.Add(this.optionPicker);
            this.Controls.Add(this.brandingLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "soundbadInfo";
            this.ShowIcon = false;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.soundbadInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.optionPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandingLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox brandingLogo;
        private System.Windows.Forms.Label branding;
        private System.Windows.Forms.Label paragraph;
        private System.Windows.Forms.TrackBar optionPicker;
        private System.Windows.Forms.Button doAction;
        private System.Windows.Forms.Label trackInfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}