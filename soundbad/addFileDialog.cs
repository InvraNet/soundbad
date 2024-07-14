using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soundbad
{
    public partial class addFileDialog : Form
    {
        public addFileDialog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openDialog_Click(object sender, EventArgs e)
        {
            fsDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            fsDialog.RestoreDirectory = true;

            if (fsDialog.ShowDialog() == DialogResult.OK)
            {
                submitFileLocationBox.Text = fsDialog.FileName;
            }
        }
    }
}
