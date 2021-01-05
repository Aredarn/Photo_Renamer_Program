using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                eleresi_ut.Text = FolderBrowserDialog.SelectedPath;
            }

            DirectoryInfo d = new DirectoryInfo(eleresi_ut.Text);
            FileInfo[] Files = d.GetFiles("*"); //Getting Text files
            string str = "";

            foreach (FileInfo file in Files)
            {
                listBoxphotosBefore.Items.Add(file);
                str = str + ", " + file.Name;
            }
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


        private void Change_Names_Click(object sender, EventArgs e)
        {

            string sourcePath = eleresi_ut.Text;
            string targetPath = eleresi_ut_2.Text;

            
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            foreach (var srcPath in Directory.GetFiles(sourcePath))
            {

                string CreatedON = "" + File.GetCreationTime(srcPath);
             
                //replaces the ( ':' and the '.' in the files name
                CreatedON = CreatedON.Replace("." , "_");
                CreatedON = CreatedON.Replace(":", "_");

                //Gets the file's format (like png or jpeg
                string ext = Path.GetExtension(srcPath);

                //Adds the targetpath, the date of creation and the file's format
                string pathMove = targetPath + @"\"+(CreatedON) + ext;
                
                //Copy the file from sourcepath and place into mentioned target path, 
                //Overwrite the file if same file is exist in target path               
                File.Copy(srcPath, pathMove, true);
            
            }            

        }

        private void listBoxphotosBefore_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxphotosBefore.IndexFromPoint(e.Location);
            listBoxphotosAfter.Items.Add(listBoxphotosBefore.SelectedItem); 
        }
    }
}
