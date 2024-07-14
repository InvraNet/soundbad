using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soundbad
{
    public partial class soundbadInfo : Form
    {
        public soundbadInfo()
        {
            InitializeComponent();
        }

        private void optionPicker_ValueChanged(object sender, EventArgs e)
        {
            if (optionPicker.Value == 10)
            {
                doAction.Text = "Close";
            }
            else if (optionPicker.Value == 9)
            {
                doAction.Text = "Open Terminal";
            }
            else if (optionPicker.Value == 8)
            {
                doAction.Text = "Play error sound";
            }
            else if (optionPicker.Value == 7)
            {
                doAction.Text = "Winver";
            }
            else if (optionPicker.Value == 6)
            {
                doAction.Text = "Hack CIA";
            }
            else
            {
                doAction.Text = "Null";
            }

        }

        private void doAction_Click(object sender, EventArgs e)
        {
            if (optionPicker.Value == 10)
            {
                this.Hide();
            }
            else if (optionPicker.Value == 9)
            {
                try
                {
                    Process.Start("wt.exe");
                }
                catch
                {
                    try
                    {
                        Process.Start("pwsh.exe");
                    }
                    catch
                    {
                        Process.Start("cmd.exe");
                    }
                }
            }
            else if (optionPicker.Value == 8)
            {
                SystemSounds.Hand.Play();
            }
            else if (optionPicker.Value == 7)
            {
                Process.Start("winver");
            }
            else if (optionPicker.Value == 6)
            {
                MessageBox.Show("What did you think this would do lil' bro?", "Mate...");
            }
            else
            {
                doAction.Text = "Null";
            }
        }

        private void soundbadInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
