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
    public partial class Form1 : Form
    {
        public Form1()
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
            FileInfo[] Files = d.GetFiles("*"); //Ez a sor észleli a fájlokat
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

                //Copy the file from sourcepath and place into mentioned target path, 
                //Overwrite the file if same file is exist in target path
                File.Copy(srcPath, srcPath.Replace(sourcePath, targetPath), true);
            }


            //Egy fájlt át tud nevezni:

            FileInfo fInfo = new FileInfo(eleresi_ut_2.Text + "\\ProfPic.jpg");
            fInfo.MoveTo(eleresi_ut_2.Text + "\\Motoros.jpg");

            

        }

        private void listBoxphotosBefore_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxphotosBefore.IndexFromPoint(e.Location);
            listBoxphotosAfter.Items.Add(listBoxphotosBefore.SelectedItem); 
        }
    }
}
