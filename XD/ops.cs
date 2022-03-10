using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrnlAPI;
namespace XD
{
    public partial class ops : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public ops()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        Point lastPoint;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void ops_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);
        }

        private void ops_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/Doggo-cryto/EclipseMM2/master/Script");
            MainAPI.Execute(Script);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/LwCa7jPq");
            MainAPI.Execute(Script);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/Rs0q8yLR");
            MainAPI.Execute(Script);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://infinite.yiff.gg/resources/IY_FE.txt");
            MainAPI.Execute(Script);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/7GrandDadPGN/VapeV4ForRoblox/main/loadstring");
            MainAPI.Execute(Script);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub");
            MainAPI.Execute(Script);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://solarishub.dev/loadstring");
            MainAPI.Execute(Script);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt");
            MainAPI.Execute(Script);
          
              
    }

    private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/toeydeklnw/HUB-obfuscator/main/mammoz.lua");
            MainAPI.Execute(Script);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patched :P                                                            ", "Cat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/ArponAG/Scripts/main/STRONGEST_PUNCH_SIMULATOR.lua");
            MainAPI.Execute(Script);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/gw8tpD25");
            MainAPI.Execute(Script);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/CMD-X/CMD-X/master/Source");
            MainAPI.Execute(Script);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("http://impulse-hub.xyz/ImpulseHub");
            MainAPI.Execute(Script);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/VoidMasterX/whub/main/main/.lua");
            MainAPI.Execute(Script);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/LOOF-sys/Roblox-Shit/main/MuscleLegends.lua");
            MainAPI.Execute(Script);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/HydraVirgo/ninjalegendsfreegui/main/obfusc");
            MainAPI.Execute(Script);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/RegularVynixu/Vynixius/main/Build%20A%20Boat%20For%20Treasure/BABFT");
            MainAPI.Execute(Script);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/CatzCode/PikaHub/main/main.lua");
            MainAPI.Execute(Script);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/hAC0U3a5");
            MainAPI.Execute(Script);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("http://void-scripts.com/Scripts/myRest.lua");
            MainAPI.Execute(Script);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/radjahfromdiscord/iNEXT/main/source");
            MainAPI.Execute(Script);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/DevPolarhub/ScriptPacks/main/Anime%20Destroyers%20Simulator");
            MainAPI.Execute(Script);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/EAphDKBF");
            MainAPI.Execute(Script);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/XExsploits/Script/main/PetSimX");
            MainAPI.Execute(Script);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/rQEinwiw");
            MainAPI.Execute(Script);
        }

        private void ops_Load(object sender, EventArgs e)
        {

        }
    }
}
