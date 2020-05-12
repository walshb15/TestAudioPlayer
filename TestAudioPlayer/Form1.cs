using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAudioPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Initialize a list
            path = new List<String>();
        }

        // List to hold the paths
        List<String> path;

        /// <summary>
        /// Runs when the open button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String file = openFileDialog1.SafeFileName;
                path.Add(openFileDialog1.FileName);
                listBox1.Items.Add(file);
            }
        }

        /// <summary>
        /// Function that runs when the OK button is pressed in the
        /// open file dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // If no song is currently playing
            if (axWindowsMediaPlayer1.URL == "")
            {
                // Set the media player URL to the file selected in the dialog
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Function that runs when you click on an item in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Tell the media player to play the song you clicked on
            axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
        }
    }
}
