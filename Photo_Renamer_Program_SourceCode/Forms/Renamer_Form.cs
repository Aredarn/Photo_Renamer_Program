﻿using Renaming_Prog.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Renaming_Prog
{
    public partial class Renamer_Form : Form
    {
        public Renamer_Form()
        {
            InitializeComponent();
        }

        //declarates an OpenFile Dialog and a FolderBrowserDialog for the program.
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();
        
        public int CopiedFiles = 0;
        string CorrectTime = DateTime.Now.ToString();

        

        //These lines are responsible for the 2 main buttons in the program.
        //These open a File explorer to select a folder
        //***********************************************************************//
        private void Select_Photos_Click(object sender, EventArgs e)
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
        //***********************************************************************//
        //***********************************************************************//



        //This method does the whole renaming and copying process
        //First it gets the two paths
        //Counts the files in the first folder and after copy process it counts the files which has been copied
        //

        private void Change_Names_Click(object sender, EventArgs e)
        { 
            string sourcePath = eleresi_ut.Text;
            string targetPath = eleresi_ut_2.Text;
            //used for date naming:
            string LastFile = "";         
            int LastFileCount = 0;
            
            Loading_TXT loading = new Loading_TXT();

            //Edits the CorrectTime string so it can be a TXT file name for a StreamWriter.
            CorrectTime = CorrectTime.Replace(".", "_");
            CorrectTime = CorrectTime.Replace(":", "_");
            StreamWriter InfoWriter = new StreamWriter($"{targetPath}\\{CorrectTime}.txt");

            //Writes the Path of the folder where the files were and where they are going to be.
            InfoWriter.WriteLine("Sourcepath: " + sourcePath);
            InfoWriter.WriteLine("Targetpath: " + targetPath);

            Stopwatch timeElapsed = new Stopwatch();
            timeElapsed.Start();

            if (customFileNameTextBox.Text == "") {
                try
                {
                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                        loading.Show();
                    }
                    foreach (var srcPath in Directory.GetFiles(sourcePath))
                    {
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
                            //replaces the ( ':' and the '.' in the files name
                            CreatedON = CreatedON.Replace(".", "_");
                            CreatedON = CreatedON.Replace(":", "_");

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


                            //Adds the targetpath, the date of creation and the file's format
                            string pathMove = targetPath + @"\" + (CreatedON) + ext;

                            //Add +1 to the copied files
                            //Writes out how many files got copied
                            //adds the copied files name to the targetpath listbox
                            //Copy the file from sourcepath and place into mentioned target path,
                            CopiedFiles++;
                            Copied_files.Text = $"Files copied: {CopiedFiles}";
                            listBoxphotosAfter.Items.Add(CreatedON + ext);
                            File.Copy(srcPath, pathMove, true);

                            //Gets the name of the file before the rename
                            string[] parts = srcPath.Split('\\');
                            string beforeRenameName = parts[parts.Length - 1];


                            //Write's the name of the correctly copied file into the TXT file before and after the rename
                            InfoWriter.WriteLine($"Copied file before rename: {beforeRenameName} \t Copied file after rename: {CreatedON}{ext}\n");

                        }

                    }
                }
                catch
                {
                    //If the copy can not be done it will open the ERROR Form
                    Error error = new Error();
                    error.Show();
                    InfoWriter.WriteLine("The program could not copy.");
                }
            }
            else
            {
                try
                {
                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                        loading.Show();
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
                            string pathMove = targetPath + @"\" + (fileName) + ext;

                            //Add +1 to the copied files
                            //Writes out how many files got copied
                            //adds the copied files name to the targetpath listbox
                            //Copy the file from sourcepath and place into mentioned target path,
                            CopiedFiles++;
                            Copied_files.Text = $"Files copied: {CopiedFiles}";
                            listBoxphotosAfter.Items.Add(fileName + ext);
                            File.Copy(srcPath, pathMove, true);

                            //Gets the name of the file before the rename
                            string[] parts = srcPath.Split('\\');
                            string beforeRenameName = parts[parts.Length - 1];


                            //Write's the name of the correctly copied file into the TXT file before and after the rename
                            InfoWriter.WriteLine($"Copied file before rename: {beforeRenameName} \t Copied file after rename: {fileName}{ext}\n");

                        }

                    }
                }
                catch
                {
                    //If the copy can not be done it will open the ERROR Form
                    Error error = new Error();
                    error.Show();
                    InfoWriter.WriteLine("The program could not copy.");
                }

            }
            loading.Close();
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
            else
            {
                Error error = new Error();
                error.Show();
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
            Select_Photos.BackColor = Color.Lime;
        }
        private void select_folder_MouseHover(object sender, EventArgs e)
        {
            select_folder.BackColor = Color.Aquamarine;
        }
        private void select_folder_MouseLeave(object sender, EventArgs e)
        {
            select_folder.BackColor = Color.Lime;
        }
        private void Copy_Files_MouseHover(object sender, EventArgs e)
        {
            Copy_Files.BackColor = Color.Aquamarine;
        }
        private void Copy_Files_MouseLeave(object sender, EventArgs e)
        {
            Copy_Files.BackColor = Color.Lime;
        }

        //************************************************************************//
        //************************************************************************//
    }
}
