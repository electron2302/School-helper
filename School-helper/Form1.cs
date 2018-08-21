using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace School_helper
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> Folders = new Dictionary<string, string>();
        string DictionarySaveInAppDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\School-helper";
        string DictionarySaveInAppDataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\School-helper" + "\\FoldersSave.txt";
        string BlankFileInAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\School-helper" + "\\Blank.odt";

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(DictionarySaveInAppDataFile))
            {
                CreateDictionaryFromFile();
            }
            else
            {
                Folders.Add("Desktop", Environment.GetFolderPath(SpecialFolder.Desktop).ToString());
            }

            //Icon menü punkte erstellen
            MenuItem ProgNameMenuItem = new MenuItem("School-helper by SART");
            MenuItem ExitMenuItem = new MenuItem("Exit");
            MenuItem RestartMenuItem = new MenuItem("Restart");
            MenuItem OpenOptionsMenuItem = new MenuItem("Optionen Öffnen");
            MenuItem NewDocMenuItem = new MenuItem("Create New Doc");
            foreach (KeyValuePair<string,string> entry in Folders)// hinfufügen aller ortner aus Dictionary
            {
                NewDocMenuItem.MenuItems.Add(entry.Key);
            }
            
            //ein kontext menü das am icon hängt erstellen
            notifyIcon.ContextMenu = new ContextMenu();
            
            //dem kontext menü alle Menüpunkte hinzufügen
            notifyIcon.ContextMenu.MenuItems.Add(ProgNameMenuItem);
            notifyIcon.ContextMenu.MenuItems.Add(ExitMenuItem);
            notifyIcon.ContextMenu.MenuItems.Add(RestartMenuItem);
            notifyIcon.ContextMenu.MenuItems.Add(OpenOptionsMenuItem);
            notifyIcon.ContextMenu.MenuItems.Add(NewDocMenuItem);

            //einhängen der funktionen in das menü

            foreach (MenuItem TestItem in NewDocMenuItem.MenuItems)
            {
                TestItem.Click += CreateNewDocumentFunktion;
            }

            RestartMenuItem.Click += RestartMenuItem_Click;
            ExitMenuItem.Click += ExitMenuItem_Click;
            OpenOptionsMenuItem.Click += OpenOptionsMenuItem_Click;
            ProgNameMenuItem.Click += ProgNameMenuItem_Click;

            // Die eigentlice form verschwinden lassen.
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

        }

        private void ProgNameMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sart.solutions/");
        }

        private void RestartMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void OpenOptionsMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void FromDisappear_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Dispose();
            this.Close();
        }

        private void CreateNewDocumentFunktion(object sender, EventArgs e)
        {

            string SenderText = (sender as MenuItem).Text;

            string NewDocumentLocation = Folders[SenderText];

            string NewDocumentFileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".odt";

            string path = NewDocumentLocation + "\\" + NewDocumentFileName;

            if (!File.Exists(path))
            {
                if (File.Exists(BlankFileInAppData))
                {
                    System.IO.File.Copy(BlankFileInAppData, path, false);
                    TextBox.AppendText("BlankFile was Copied to " + path + " :)" + NewLine);
                }
                else
                {
                    File.Create(path).Close();
                    TextBox.AppendText("Empti file was created at " + path + " :)" + NewLine);
                }
                
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                TextBox.AppendText(path + " already Exists :(" + NewLine);
            }
        }

        private void SchoolSubjectAddButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Folders.Add(AddNameBox.Text, FolderBrowserDialog.SelectedPath);
                SaveDictionaryToFile();
                TextBox.AppendText(AddNameBox.Text +" "+ FolderBrowserDialog.SelectedPath + " were added :)" + NewLine);
                AddNameBox.Text = null;
            }
            else
            {
                TextBox.AppendText("Opening FolderBrowser didn´t work :(" + NewLine);
            }
        }

        private void SchoolSubjectRemoveButton_Click(object sender, EventArgs e)
        {

            string FolderKeyToRemove = SchoolSubjectRemoveBox.SelectedItem.ToString();

            try
            {
                if (Folders.ContainsKey(FolderKeyToRemove))
                {
                    Folders.Remove(FolderKeyToRemove);

                    if (!Folders.ContainsKey(FolderKeyToRemove))
                    {

                        SaveDictionaryToFile();
                        SchoolSubjectRemoveBox.Items.Remove(FolderKeyToRemove);
                        TextBox.AppendText("Remove " + FolderKeyToRemove + " succsesfully" + NewLine);
                    }
                    else
                        TextBox.AppendText("Remove " + FolderKeyToRemove + " faild :(" + NewLine);
                }
                else
                {
                    TextBox.AppendText(FolderKeyToRemove + " does not exist" + NewLine);
                }
            }
            catch
            {
                TextBox.AppendText("Remove " + FolderKeyToRemove + " was catched :(" + NewLine);
            }
            
        }

        private void SaveDictionaryToFile()
        {
            string FileContent = "";
            foreach (KeyValuePair<string, string> entry in Folders)// hinfufügen aller ortner aus Dictionary
            {
                FileContent = FileContent + entry.Key + ";" + entry.Value + NewLine;
            }

            if (!Directory.Exists(DictionarySaveInAppDataDirectory))
                Directory.CreateDirectory(DictionarySaveInAppDataDirectory);

            File.WriteAllText(DictionarySaveInAppDataFile, FileContent);

        }

        private void CreateDictionaryFromFile()
        {
            Folders.Clear();
            string[] readText = File.ReadAllLines(DictionarySaveInAppDataFile);
            foreach (string s in readText)
            {
                string[] sa = s.Split(';');
                Folders.Add(sa[0], sa[1]);
                SchoolSubjectRemoveBox.Items.Add(sa[0]);
                TextBox.AppendText(sa[0] + " was added with Directory " + sa[1] + NewLine);
            }
        }
    }
}