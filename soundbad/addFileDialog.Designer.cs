namespace soundbad
{
    partial class addFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFileDialog));
            this.locationLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.submitFileLocationBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.Button();
            this.fsDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(12, 9);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(121, 13);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "Enter location of the file.";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name of file";
            // 
            // submitFileLocationBox
            // 
            this.submitFileLocationBox.Location = new System.Drawing.Point(15, 25);
            this.submitFileLocationBox.Name = "submitFileLocationBox";
            this.submitFileLocationBox.Size = new System.Drawing.Size(299, 20);
            this.submitFileLocationBox.TabIndex = 1;
            this.submitFileLocationBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openDialog
            // 
            this.openDialog.Location = new System.Drawing.Point(314, 24);
            this.openDialog.Name = "openDialog";
            this.openDialog.Size = new System.Drawing.Size(24, 22);
            this.openDialog.TabIndex = 2;
            this.openDialog.Text = ">";
            this.openDialog.UseVisualStyleBackColor = true;
            this.openDialog.Click += new System.EventHandler(this.openDialog_Click);
            // 
            // fsDialog
            // 
            this.fsDialog.Filter = "Audio Files|*.wav;*.mp3;*.ogg;*.m4a|Video Files|*.mp4;*.mov;;*.webp";
            // 
            // addFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 98);
            this.Controls.Add(this.openDialog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.submitFileLocationBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.locationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addFileDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new file";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox submitFileLocationBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openDialog;
        private System.Windows.Forms.OpenFileDialog fsDialog;
    }
}