using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using KrnlAPI;
using System.Threading;
// SOURCE CODE BY Agent Cat
namespace XD
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            MainAPI.Latest();
            MainAPI.Load();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        Point lastPoint;



        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
          
           
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "./scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./scripts", "*.lua");
            this.editor.Navigate(string.Format("file:///{0}bin/ace/AceEditor.html", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainAPI.IsAttached() == true)

            {

                MessageBox.Show("Already Injected", "Cat");

            }

            else

            {

                MainAPI.Inject();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            HtmlDocument document = editor.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            MainAPI.Execute(script);
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (editorClearPromptToolStripMenuItem.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("do you want to clear editor ?", "Cat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    editor.Document.InvokeScript("SetText", new object[]
           {
                ""
           });
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            else if (editorClearPromptToolStripMenuItem.Checked == false)
            {
                editor.Document.InvokeScript("SetText", new object[]
          {
                ""
          });
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip2.Show(ptLowerLeft);

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            



        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            ops openform = new ops();
            openform.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ops openform = new ops();
            openform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainAPI.IsAttached() == true)

            {

                StatusLabel.Text = "Cat - ready!";

                StatusLabel.ForeColor = Color.SpringGreen;

            }

            else

            {

                StatusLabel.Text = "Cat";

                StatusLabel.ForeColor = Color.White;

            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            {
                foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    process.Kill();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost ^= true;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_2(object sender, EventArgs e)
        {

        }

        private void aPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex != -1)
            {
                MainAPI.Execute(System.IO.File.ReadAllText("scripts\\" + this.listBox1.SelectedItem.ToString()));
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./scripts", "*.lua");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex != -1)
            {
                this.editor.Document.InvokeScript("SetText", new object[1]
                {
          (object) System.IO.File.ReadAllText("scripts\\" + this.listBox1.SelectedItem.ToString())
                });
            }
            else
            {

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Functions.openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    MainAPI.Execute(File.ReadAllText(Functions.openfiledialog.FileName));


                }
                catch (Exception ex)
                {

                }
            }

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Functions.openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string MainText = File.ReadAllText(Functions.openfiledialog.FileName);
                    editor.Document.InvokeScript("SetText", new object[]
                    {
                          MainText
                    });

                }
                catch (Exception ex)
                {

                }
            }

        }

        private void themeing_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            settings.Show(ptLowerLeft);
        }

        private void opcityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opcityToolStripMenuItem.Checked == true)
            {
                this.Opacity = 0.8;
            }

            else if (opcityToolStripMenuItem.Checked == false)
            {
                this.Opacity = 60;
            }
        }

        private void settings_Opening(object sender, CancelEventArgs e)
        {

        }

        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (topMostToolStripMenuItem.Checked == true)
            {
                this.TopMost = true;
            }

            else if (topMostToolStripMenuItem.Checked == false)
            {
                this.TopMost = false;
            }
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void opacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opacityToolStripMenuItem.Checked == true)
            {
                this.Opacity = 0.8;
            }

            else if (opacityToolStripMenuItem.Checked == false)
            {
                this.Opacity = 70;
            }
        }

        private void autoAttachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoAttachToolStripMenuItem.Checked == true)
            {
                MainAPI.AutoAttach(true);
            }

            else if (autoAttachToolStripMenuItem.Checked == false)
            {
                MainAPI.AutoAttach(false);
            }
        }

        private void downloadDLLSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            execute.FlatAppearance.MouseDownBackColor = Color.SpringGreen;
            execute.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            open.FlatAppearance.MouseDownBackColor = Color.SpringGreen;
            open.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            clear.FlatAppearance.MouseDownBackColor = Color.SpringGreen;
            clear.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            close.FlatAppearance.MouseDownBackColor = Color.SpringGreen;
            close.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            inject.FlatAppearance.MouseDownBackColor = Color.SpringGreen;
            inject.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            scripts.FlatAppearance.MouseDownBackColor = Color.SpringGreen;
            scripts.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HtmlDocument document = this.editor.Document;
            string scriptName = "GetText";
            object[] array = new string[0];
            object[] array2 = array;
            object[] args = array2;
            object obj = document.InvokeScript(scriptName, args);
            string text = obj.ToString();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Lua Script (*.lua)|*.lua|Text File (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save As";
                saveFileDialog.ShowDialog();
                try
                {
                    string fileName = saveFileDialog.FileName;
                    string text2 = text;
                    string[] contents = new string[]
                    {
text2.ToString(),
""
                    };
                    File.WriteAllLines(saveFileDialog.FileName, contents);
                }
                catch (Exception)
                {
                }
            }
        }

        private void mmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colbaitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
           {
                "eclipse"
           });
        }

        private void draculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
         {
                "dracula"
         });
        }

        private void cloudsMidnightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
         {
                "clouds_midnight"
         });
        }

        private void fPSUnlockerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fPSUnlockerToolStripMenuItem.Checked == true)
            {
                Process.Start("bin\\rbxfpsunlocker.exe");
            }

            else if (fPSUnlockerToolStripMenuItem.Checked == false)
            {
                {
                    foreach (var process in Process.GetProcessesByName("rbxfpsunlocker"))
                    {
                        process.Kill();
                    }
                }
            }
        }

        private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    process.Kill();
                }
            }
        }

        private void gobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
      {
                "gob"
      });
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
      {
                "github"
      });
        }

        private void tomorrownighteightiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
    {
                "tomorrow_night_eighties"
    });
        }

        private void themeTomorrowNightBrightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
    {
                "tomorrow_night_bright"
    });
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reLaunchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void idlefingersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
   {
                "idle_fingers"
   });
        }

        private void iplasticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
       {
                "iplastic"
       });
        }

        private void katzenmilchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
     {
                "katzenmilch"
     });
        }

        private void ambianceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
     {
                "ambiance"
     });
        }

        private void chaosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
     {
                "chaos"
     });
        }

        private void draculaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
         {
                "dracula"
         });
            this.BackColor = ColorTranslator.FromHtml("#282a36");
            panel1.BackColor = ColorTranslator.FromHtml("#282a36");
            execute.BackColor = ColorTranslator.FromHtml("#282a36");
            clear.BackColor = ColorTranslator.FromHtml("#282a36");
            open.BackColor = ColorTranslator.FromHtml("#282a36");
            scripts.BackColor = ColorTranslator.FromHtml("#282a36");
            inject.BackColor = ColorTranslator.FromHtml("#282a36");
            close.BackColor = ColorTranslator.FromHtml("#282a36");
            minimize.BackColor = ColorTranslator.FromHtml("#282a36");
            settings.BackColor = ColorTranslator.FromHtml("#282a36");
            listBox1.BackColor = ColorTranslator.FromHtml("#282a36");
            themeing.BackColor = ColorTranslator.FromHtml("#282a36");
            contextMenuStrip1.BackColor = ColorTranslator.FromHtml("#282a36");
            contextMenuStrip2.BackColor = ColorTranslator.FromHtml("#282a36");

            close.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#282a36");
            minimize.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#282a36");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://krnl.ca/");
        }

        private void dreamweaverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
     {
                "dreamweaver"
     });
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void cobaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
     {
                "cobalt"
     });
        }

        private void crimsonEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
     {
                "crimson_editor"
     });
        }

        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
     {
                "chrome"
     });
        }

        private void dawnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
     {
                "dawn"
     });
        }

        private void cloudsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
                 {
                "clouds"
                 });
        }

        private void xcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Document.InvokeScript("SetTheme", new object[]
     {
                "xcode"
     });
        }

        private void editorClearPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlDocument document = editor.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            System.Windows.Forms.Clipboard.SetText(script);
        }

        private void contextMenuStrip2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void execute_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void execute_MouseEnter(object sender, EventArgs e)
        {
            execute.BackColor = ColorTranslator.FromHtml("47, 95, 160");
            execute.FlatAppearance.BorderColor = ColorTranslator.FromHtml("174, 175, 176");
        }

        private void execute_MouseLeave(object sender, EventArgs e)
        {
            execute.BackColor = ColorTranslator.FromHtml("31, 31, 31");
            execute.FlatAppearance.BorderColor = ColorTranslator.FromHtml("34, 34, 34");
        }

        private void clear_MouseEnter(object sender, EventArgs e)
        {
           clear.BackColor = ColorTranslator.FromHtml("47, 95, 160");
           clear.FlatAppearance.BorderColor = ColorTranslator.FromHtml("174, 175, 176");
        }

        private void clear_MouseLeave(object sender, EventArgs e)
        {
            clear.BackColor = ColorTranslator.FromHtml("31, 31, 31");
            clear.FlatAppearance.BorderColor = ColorTranslator.FromHtml("34, 34, 34");
        }

        private void themeing_MouseEnter(object sender, EventArgs e)
        {
            themeing.BackColor = ColorTranslator.FromHtml("47, 95, 160");
            themeing.FlatAppearance.BorderColor = ColorTranslator.FromHtml("174, 175, 176");
        }

        private void themeing_MouseLeave(object sender, EventArgs e)
        {
            themeing.BackColor = ColorTranslator.FromHtml("31, 31, 31");
            themeing.FlatAppearance.BorderColor = ColorTranslator.FromHtml("34, 34, 34");
        }

        private void open_MouseEnter(object sender, EventArgs e)
        {
            open.BackColor = ColorTranslator.FromHtml("47, 95, 160");
            open.FlatAppearance.BorderColor = ColorTranslator.FromHtml("174, 175, 176");
        }

        private void open_MouseLeave(object sender, EventArgs e)
        {
            open.BackColor = ColorTranslator.FromHtml("31, 31, 31");
            open.FlatAppearance.BorderColor = ColorTranslator.FromHtml("34, 34, 34");
        }

        private void inject_MouseEnter(object sender, EventArgs e)
        {
            inject.BackColor = ColorTranslator.FromHtml("47, 95, 160");
            inject.FlatAppearance.BorderColor = ColorTranslator.FromHtml("174, 175, 176");
        }

        private void inject_MouseLeave(object sender, EventArgs e)
        {
            inject.BackColor = ColorTranslator.FromHtml("31, 31, 31");
            inject.FlatAppearance.BorderColor = ColorTranslator.FromHtml("34, 34, 34");
        }

        private void scripts_MouseEnter(object sender, EventArgs e)
        {
            scripts.BackColor = ColorTranslator.FromHtml("47, 95, 160");
            scripts.FlatAppearance.BorderColor = ColorTranslator.FromHtml("174, 175, 176");
        }

        private void scripts_MouseLeave(object sender, EventArgs e)
        {
            scripts.BackColor = ColorTranslator.FromHtml("31, 31, 31");
            scripts.FlatAppearance.BorderColor = ColorTranslator.FromHtml("34, 34, 34");
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize.BackColor = ColorTranslator.FromHtml("47, 95, 160");
            minimize.FlatAppearance.BorderColor = ColorTranslator.FromHtml("174, 175, 176");
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackColor = ColorTranslator.FromHtml("28, 28, 28");
            minimize.FlatAppearance.BorderColor = ColorTranslator.FromHtml("28, 28, 28");
        }

        private void close_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = ColorTranslator.FromHtml("47, 95, 160");
            close.FlatAppearance.BorderColor = ColorTranslator.FromHtml("174, 175, 176");
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = ColorTranslator.FromHtml("28, 28, 28");
            close.FlatAppearance.BorderColor = ColorTranslator.FromHtml("28, 28, 28");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(System.IO.File.ReadAllText("scripts\\" + this.listBox1.SelectedItem.ToString()));
        }

        private void clear_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minimize_MouseEnter_1(object sender, EventArgs e)
        {
            minimize.BackColor = ColorTranslator.FromHtml("47, 95, 160");
            minimize.FlatAppearance.BorderColor = ColorTranslator.FromHtml("174, 175, 176");
        }

        private void minimize_MouseLeave_1(object sender, EventArgs e)
        {
            minimize.BackColor = ColorTranslator.FromHtml("28, 28, 28");
            minimize.FlatAppearance.BorderColor = ColorTranslator.FromHtml("28, 28, 28");
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
