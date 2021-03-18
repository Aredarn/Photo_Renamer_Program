using Renaming_Prog.Forms;
using System;
using System.IO;
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
            string str;
            FileInfo[] Files;
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                eleresi_ut.Text = FolderBrowserDialog.SelectedPath;
                DirectoryInfo d = new DirectoryInfo(eleresi_ut.Text);
                Files = d.GetFiles("*"); //Getting all files
                str = "";
                int db = 0;
                foreach (FileInfo file in Files)
                {
                    db++;
                    listBoxphotosBefore.Items.Add(file);
                    str = str + ", " + file.Name;
                }

                Lenght.Text = "" + db;
            }
        }

        private void select_folder_Click(object sender, EventArgs e)
        {
            listBoxphotosAfter.Items.Clear();
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                eleresi_ut_2.Text = FolderBrowserDialog.SelectedPath;
                DirectoryInfo d = new DirectoryInfo(eleresi_ut_2.Text);
                FileInfo[] Files = d.GetFiles("*"); //This line detects the files
            }
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

            try
            {
                if (!Directory.Exists(targetPath) || eleresi_ut.Text != "No path given")
                {
                    Directory.CreateDirectory(targetPath);
                    loading.Show();
                }
                foreach (var srcPath in Directory.GetFiles(sourcePath))
                {
                    size = srcPath.Length;
                    string CreatedON = "" + File.GetLastWriteTime(srcPath);

                    //Gets the file's format (like png or jpeg)
                    string ext = Path.GetExtension(srcPath);

                    bool allowFile = false;

                    if (ext == ".png" || ext == ".jpeg" || ext == ".jpg" || ext == ".mp4" || ext == ".PNG" || ext == ".JPEG" || ext == ".JPG" || ext == ".MP4")
                        allowFile = true;


                    if (allowFile)
                    {
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


                        //Adds the targetpath, the date of creation and the file's format
                        string pathMove = targetPath + @"\" + (CreatedON) + ext;

                        //Copy the file from sourcepath and place into mentioned target path, 
                        //Overwrite the file if same file is exist in target path               
                        CopiedFiles++;
                        Copied_files.Text = $"Files copied: {CopiedFiles}";
                        listBoxphotosAfter.Items.Add(CreatedON + ext);
                        File.Copy(srcPath, pathMove, true);
                    }
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


        //This method allows the user to copy only one photo if clicked on
        private void listBoxphotosBefore_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            string selectedFile = listBoxphotosBefore.GetItemText(listBoxphotosBefore.SelectedItem);                   
            
            string srcPath = eleresi_ut.Text + "\\" + selectedFile;
            //Gets the file's format (like png or jpeg)
            string ext = Path.GetExtension(srcPath);

            bool allowFile = false;
            if ((ext == ".png" || ext == ".jpeg" || ext == ".jpg" || ext == ".mp4" || ext == ".PNG" || ext == ".JPEG" || ext == ".JPG" || ext == ".MP4") && eleresi_ut.Text != "" && eleresi_ut_2.Text != "")               
            allowFile = true;


            if (allowFile)
            {
                string CreatedON = "\\" + File.GetLastWriteTime(srcPath);
                CreatedON = CreatedON.Replace(".", "_");
                CreatedON = CreatedON.Replace(":", "_");


                string pathMove = eleresi_ut_2.Text + CreatedON + ext;

                File.Copy(srcPath, pathMove, true);

                listBoxphotosAfter.Items.Add(CreatedON + ext);
            }
            else
            {
                Error error = new Error();
                error.Show();
            }
        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            HowToUse help = new HowToUse();
            help.Show();
        }

        private void Renamer_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
