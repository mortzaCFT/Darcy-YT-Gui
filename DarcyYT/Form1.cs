using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DarcyYT
{
    public partial class mainForm : Form
    {
        public string[] sizeFrame = { "1080", "720", "480", "360", "240", "144" };
        public string[] fpsS = { "60", "50", "48", "30", "24" };
        string Darcy_URL = "https://discord.gg/cGEzdzxdkx";
        string Ver = "beta_0.0.1";
        
        string format;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            QualityDropDown.SelectedIndex = 0;
            FPSDropDown.SelectedIndex = 0;
        }

        private void buildFormat(int qualSkip,int fpsSkip)
        {
            string[] sizeFrameMin = sizeFrame.Skip(qualSkip).ToArray();
            string[] fpsSMin = fpsS.Skip(fpsSkip).ToArray();
            format = "-f ";
            foreach (string quality in sizeFrameMin)
            {
                foreach (string framerate in fpsSMin)
                {
                    format += "bestvideo[height=?" + quality + "][fps=?" + framerate + "]+bestaudio/";
                }
            }
            format += "best";
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string URL = URLTextBox.Text;
            string dlPath = downloadPathTxtBox.Text.Replace('\\','/');
            int height = Convert.ToInt16(QualityDropDown.Text.Substring(0, QualityDropDown.Text.LastIndexOf("p")));
            int fps = Convert.ToInt16(FPSDropDown.Text);
            

            //Size and FPS 
           if (height == 1080 && fps == 30)
            {
                buildFormat(3, 3);
            }
            else if (height == 720 && fps == 60)
            {
                buildFormat(4, 0);
            }
            else if (height == 720 && fps == 30)
            {
                buildFormat(4, 3);
            }
            else if (height == 480)
            {
                buildFormat(5, 3);
            }
            else if (height == 360)
            {
                buildFormat(6, 3);
            }
            else if (height == 240)
            {
                buildFormat(7, 3);
            }
            else if (height == 144)
            {
                buildFormat(8, 3);
            }
            else
            {
                format = "-f bestvideo+bestaudio/best";
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "-o "+dlPath+"/%(title)s.%(ext)s "+format+" -i --ignore-config --hls-prefer-native "+URL;
            try
            {
                using (Process p = Process.Start(startInfo))
                {
                    p.WaitForExit();
                }
                format = "";
            }
            catch
            {
                Console.WriteLine(DialogResult);
            }
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                downloadPathTxtBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "-U";

            try
            {
                using (Process p = Process.Start(startInfo))
                {
                    p.WaitForExit();
                }
            }
            catch
            {
                Console.WriteLine(DialogResult);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Join The Darcy Family!");
            System.Diagnostics.Process.Start(Darcy_URL);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: mortza \n The Downloader Everything with youtube-dl(Using For APL). \n If Anyerror you have to download pls tell me on discord. \n Discord ID: mortza#3700", Ver );
        }

    }
}
