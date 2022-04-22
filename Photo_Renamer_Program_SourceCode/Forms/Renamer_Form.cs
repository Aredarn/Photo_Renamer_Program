using Renaming_Prog.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Renaming_Prog
{



    //MAIN ACTIVITIES//
    public partial class Renamer_Form : Form
    {
        //VARIABLES//

        //declarates an OpenFile Dialog and a FolderBrowserDialog for the program.
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();

        int CopiedFiles = 0;

        string CorrectTime = DateTime.Now.ToString();
        string str;

        FileInfo[] Files;
        //END OF VARIABLES//

        public Renamer_Form()
        {
            InitializeComponent();
        }

        //These lines are responsible for the 2 main buttons in the program.
        //These open a File explorer to select a folder
        //***********************************************************************//
        private void Select_Photos_Click(object sender, EventArgs e)
        {
            listBoxphotosBefore.Items.Clear();
            Lenght.Text = "";
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

                Lenght.Text = "Items in the folder: " + db;
            }
        }
        private void select_folder_Click(object sender, EventArgs e)
        {
            listBoxphotosAfter.Items.Clear();
            Copied_files.Text = "";
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                eleresi_ut_2.Text = FolderBrowserDialog.SelectedPath;
                DirectoryInfo d = new DirectoryInfo(eleresi_ut_2.Text);
                FileInfo[] Files = d.GetFiles("*"); //This line detects the files
            }
        }
        //***********************************************************************//
        //***********************************************************************//



        //This method does the whole renaming and copying process
        //First it gets the two paths
        //Counts the files in the first folder and after copy process it counts the files which has been copied
        //


        private void test()
        {
            this.Invoke((MethodInvoker)delegate () { listBoxphotosAfter.Items.Add("hiakgsjfnm,"); });
        }


        private void change()
        {
            CopiedFiles = 0;
            string pathMove = "";
            string sourcePath = eleresi_ut.Text;
            string targetPath = eleresi_ut_2.Text;
            //used for date naming:
            string LastFile = "";
            int LastFileCount = 0;



            

            //Edits the CorrectTime string so it can be a TXT file name for a StreamWriter.
            CorrectTime = CorrectTime.Replace(".", "_");
            CorrectTime = CorrectTime.Replace(":", "_");
            StreamWriter InfoWriter = new StreamWriter($"{targetPath}\\{CorrectTime}.txt");

            //Writes the Path of the folder where the files were and where they are going to be.
            InfoWriter.WriteLine("Sourcepath: " + sourcePath);
            InfoWriter.WriteLine("Targetpath: " + targetPath);

            Stopwatch timeElapsed = new Stopwatch();
            timeElapsed.Start();

            if (customFileNameTextBox.Text == "")
            {
                try
                {
                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                       
                    }
                    foreach (var srcPath in Directory.GetFiles(sourcePath))
                    {

                        string[] createdDatesList = new string[CopiedFiles + 1];

                        //Names the variable to the creation time of the correct file.
                        string CreatedON = "" + File.GetLastWriteTime(srcPath);



                        //Gets the file's format (like png or jpeg)
                        string ext = Path.GetExtension(srcPath);

                        bool allowFile = false;

                        //This line examines the correct file's format, if it's not correct it won't copy it.
                        if (ext == ".png" || ext == ".jpeg" || ext == ".jpg" || ext == ".mp4" || ext == ".PNG" || ext == ".JPEG" || ext == ".JPG" || ext == ".MP4")
                            allowFile = true;


                        if (allowFile)
                        {
                            //replaces the ':' and the '.' in the files name to '_'
                            CreatedON = CreatedON.Replace(".", "_");
                            CreatedON = CreatedON.Replace(":", "_");

                            string[] dates = CreatedON.Split('_');


                            //If the correct copied file is created on the same date as the previous file
                            //these lines add 2 underlines and how many times the file was found (the same)
                            //after the filename to prevent duplication and overwriting the file

                            if (CreatedON == LastFile)
                            {
                                LastFileCount++;
                                CreatedON = CreatedON + "_" + LastFileCount;
                            }
                            else
                            {
                                LastFile = CreatedON;
                                LastFileCount = 0;
                            }


                            if (allowFolderSort.Checked)
                            {
                                bool containsTheDate = false;

                                for (int i = 0; i < createdDatesList.Length; i++)
                                {
                                    if (dates[0] + "" + dates[1] == createdDatesList[i])
                                    {
                                        containsTheDate = true;
                                    }
                                }

                                if (containsTheDate)
                                {
                                    pathMove = targetPath + @"\" + dates[0] + "" + dates[1] + @"\" + (CreatedON) + ext;
                                }
                                else
                                {
                                    Directory.CreateDirectory(targetPath + @"\" + dates[0] + "" + dates[1]);
                                    createdDatesList[createdDatesList.Length - 1] = dates[0] + "" + dates[1];
                                    pathMove = targetPath + @"\" + dates[0] + "" + dates[1] + @"\" + (CreatedON) + ext;
                                }
                            }
                            else
                            {
                                pathMove = targetPath + @"\" + (CreatedON) + ext;
                            }


                            //Add +1 to the copied files
                            //Writes out how many files got copied
                            //adds the copied files name to the targetpath listbox
                            //Copy the file from sourcepath and place into mentioned target path,
                            CopiedFiles++;
                            this.Invoke((MethodInvoker)delegate () { Copied_files.Text = $"Files copied: {CopiedFiles}"; });
                            this.Invoke((MethodInvoker)delegate () { listBoxphotosAfter.Items.Add(CreatedON + ext); });
                            
                            File.Copy(srcPath, pathMove, true);

                            //Gets the name of the file before the rename
                            string[] parts = srcPath.Split('\\');
                            string beforeRenameName = parts[parts.Length - 1];


                            //Write's the name of the correctly copied file into the TXT file before and after the rename
                            InfoWriter.WriteLine($"Copied file before rename: {beforeRenameName} \t Copied file after rename: {CreatedON}{ext}\n");

                        }
                    }
                }
                catch (Exception ex)
                {
                    InfoWriter.WriteLine("The program could not copy.\n" + ex.ToString());
                }
            }
            else
            {
                try
                {
                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                    }
                    foreach (var srcPath in Directory.GetFiles(sourcePath))
                    {
                        //Names the variable to the user specified name.
                        string fileName = customFileNameTextBox.Text + CopiedFiles;

                        //Gets the file's format (like png or jpeg)
                        string ext = Path.GetExtension(srcPath);

                        bool allowFile = false;

                        //This line examines the correct file's format, if it's not correct it won't copy it.
                        if (ext == ".png" || ext == ".jpeg" || ext == ".jpg" || ext == ".mp4" || ext == ".PNG" || ext == ".JPEG" || ext == ".JPG" || ext == ".MP4")
                            allowFile = true;


                        if (allowFile)
                        {
                            //If the correct copied file is created on the same date as the previous file
                            //these lines add 2 underlines and how many times the file was found (the same)
                            //after the filename to prevent duplication and overwriting the file

                            if (fileName == LastFile)
                            {
                                LastFileCount++;
                                fileName = fileName + "_" + LastFileCount;
                            }
                            else
                            {
                                LastFile = fileName;
                                LastFileCount = 0;
                            }


                            //Adds the targetpath, the custom name and the file's format
                            pathMove = targetPath + @"\" + (fileName) + ext;

                            //Add +1 to the copied files
                            //Writes out how many files got copied
                            //adds the copied files name to the targetpath listbox
                            //Copy the file from sourcepath and place into mentioned target path,
                            CopiedFiles++;
                            this.Invoke((MethodInvoker)delegate () { Copied_files.Text = $"Files copied: {CopiedFiles}"; });
                            this.Invoke((MethodInvoker)delegate () { listBoxphotosAfter.Items.Add(fileName + ext); });
                            File.Copy(srcPath, pathMove, true);

                            //Gets the name of the file before the rename
                            string[] parts = srcPath.Split('\\');
                            string beforeRenameName = parts[parts.Length - 1];


                            //Write's the name of the correctly copied file into the TXT file before and after the rename
                            InfoWriter.WriteLine($"Copied file before rename: {beforeRenameName} \t Copied file after rename: {fileName}{ext}\n");

                        }

                    }
                }
                catch (Exception ex)
                {
                    InfoWriter.WriteLine("The program could not copy." + ex);
                }

            }
            
            Info_Form info_Form = new Info_Form();
            info_Form.Show(); 

            //Stoppes the stop watch

            timeElapsed.Stop();
            TimeSpan ts = timeElapsed.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //Writes out the elapsed time and the files the number of files that the program wrote, to the TXT file
            InfoWriter.WriteLine("\nElapsed time: " + elapsedTime);
            InfoWriter.WriteLine("The program copied: " + CopiedFiles + " files.");

            InfoWriter.Close();
        }

        private void Change_Names_Click(object sender, EventArgs e)
        {
            listBoxphotosAfter.Items.Clear();
            Thread thread = new Thread(change);
            thread.Start();
        }

        //This method allows the user to copy only one photo by clicking on it.
        private void listBoxphotosBefore_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            string selectedFile = listBoxphotosBefore.GetItemText(listBoxphotosBefore.SelectedItem);                   
            
            string srcPath = eleresi_ut.Text + "\\" + selectedFile;
            //Gets the file's format (like png or jpeg)
            string ext = Path.GetExtension(srcPath);

            //Determines the file types which are allowed.
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
                CopiedFiles++;
                Copied_files.Text = $"Files copied: {CopiedFiles}";
            }
        }

        //Open the HELP Form
        private void Help_button_Click(object sender, EventArgs e)
        {
            HowToUse help = new HowToUse();
            help.Show();
        }


        // The following lines changes the action buttons' color if the user is above it with the mouse or not.
        //***********************************************************************//
        //***********************************************************************//
        private void Select_Photos_MouseHover(object sender, EventArgs e)
        {
            Select_Photos.BackColor = Color.Aquamarine;
        }
        private void Select_Photos_MouseLeave(object sender, EventArgs e)
        {
            Select_Photos.BackColor = Color.Blue;
        }
        private void select_folder_MouseHover(object sender, EventArgs e)
        {
            select_folder.BackColor = Color.Aquamarine;
        }
        private void select_folder_MouseLeave(object sender, EventArgs e)
        {
            select_folder.BackColor = Color.Blue;
        }
        private void Copy_Files_MouseHover(object sender, EventArgs e)
        {
            Copy_Files.BackColor = Color.Aquamarine;
        }
        private void Copy_Files_MouseLeave(object sender, EventArgs e)
        {
            Copy_Files.BackColor = Color.White;
        }


        //Language Setting
        private void ChangeLanguage_Click(object sender, EventArgs e)
        {
            string whichLang = ChangeLanguage.Text;

            if(whichLang == "English")
            {
                changeToHun();
            }
            else
            {

            }
        }


        private void changeToHun()
        {
            LiveHead_Label.Text = "Fotó Másoló Program";
            Help_button.Text = "Segítség";
            Select_Photos.Text = "Válassz ki egy mappát (Ahonnan a fotókat másolod)";
            select_folder.Text = "Válassz ki egy mappát (Ahova a fotókat másolod)";
            Src_LBL.Text = "Forrás fájlok";
            Cpy_LBL.Text = "Másolt fájlok";
            customFileLabel.Text = "Választható: Saját fájl név:";
            Copy_Files.Text = "Kattints ide a fájlok másolásához!";
            ChangeLanguage.Text = "Magyar";
        }

        private void allowFolderSort_CheckedChanged(object sender, EventArgs e)
        {
            if (allowFolderSort.Checked)
            {
                customFileNameTextBox.Text = "";
                customFileNameTextBox.Enabled = false;
            }
            else
            {
                customFileNameTextBox.Enabled = true;
            }
         
        }

        private void Open_From_Folder_Click(object sender, EventArgs e)
        {
            if(eleresi_ut.Text=="")
            {

            }
            else
                Process.Start("explorer.exe", eleresi_ut.Text);
        }

        private void Open_To_Folder_Click(object sender, EventArgs e)
        {
            if (eleresi_ut_2.Text == "")
            {

            }
            else
                Process.Start("explorer.exe", eleresi_ut_2.Text);
        }


        //************************************************************************//
        //************************************************************************//
    }
}
