using Renaming_Prog.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renaming_Prog
{
    public partial class Renamer_Form : Form
    {
        public Renamer_Form()
        {
            InitializeComponent();
 
        }
        OpenFileDialog ofd = new OpenFileDialog();

        FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxphotosBefore.Items.Clear();

            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                eleresi_ut.Text = FolderBrowserDialog.SelectedPath;
            }

            DirectoryInfo d = new DirectoryInfo(eleresi_ut.Text);
            FileInfo[] Files = d.GetFiles("*"); //Getting Text files
            string str = "";

            int db = 0;
            foreach (FileInfo file in Files)
            {
                db++;
                listBoxphotosBefore.Items.Add(file);
                str = str + ", " + file.Name;
            }

            Lenght.Text = ""+ db;
        }

        private void select_folder_Click(object sender, EventArgs e)
        {

            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                eleresi_ut_2.Text = FolderBrowserDialog.SelectedPath;
            }

            DirectoryInfo d = new DirectoryInfo(eleresi_ut_2.Text);           
            FileInfo[] Files = d.GetFiles("*"); //This line detects the files
        }


        public void Change_Names_Click(object sender, EventArgs e)
        {

            string sourcePath = eleresi_ut.Text;
            string targetPath = eleresi_ut_2.Text;
            string LastFile = "";
            int LastFileCount = 0;
            long size = 0;
            int CopiedFiles = 0;


            Loading_TXT loading = new Loading_TXT();
            loading.Show();
            System.Threading.Thread.Sleep(400);

            try
            {
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }
                foreach (var srcPath in Directory.GetFiles(sourcePath))
                {
                    size = srcPath.Length;
                    string CreatedON = "" + File.GetLastWriteTime(srcPath);


                    //replaces the ( ':' and the '.' in the files name
                    CreatedON = CreatedON.Replace(".", "_");
                    CreatedON = CreatedON.Replace(":", "_");

                    if (CreatedON == LastFile) 
                    {
                        
                        LastFileCount++;
                        CreatedON = CreatedON + LastFile;
                    }
                    else
                    {
                        LastFile = CreatedON;
                        LastFileCount = 0;
                    }
                    


                    //Gets the file's format (like png or jpeg)
                    string ext = Path.GetExtension(srcPath);

                    //Adds the targetpath, the date of creation and the file's format
                    string pathMove = targetPath + @"\" + (CreatedON) + ext;

                    //Copy the file from sourcepath and place into mentioned target path, 
                    //Overwrite the file if same file is exist in target path               
                    CopiedFiles++;
                    Copied_files.Text = $"Files copied: {CopiedFiles}";
                    listBoxphotosAfter.Items.Add(CreatedON + ext);
                    File.Copy(srcPath, pathMove, true);
                }


                loading.Close();
                Info_Form info_Form = new Info_Form();
                info_Form.Show();
            }
            catch
            {
                Error error = new Error();
                error.Show();
            }

        }

        private void listBoxphotosBefore_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int index = this.listBoxphotosBefore.IndexFromPoint(e.Location);
            listBoxphotosAfter.Items.Add(listBoxphotosBefore.SelectedItem);
        }
    }
}
