﻿namespace Renaming_Prog
{
    partial class Renamer_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renamer_Form));
            this.Select_Photos = new System.Windows.Forms.Button();
            this.listBoxphotosBefore = new System.Windows.Forms.ListBox();
            this.Copy_Files = new System.Windows.Forms.Button();
            this.listBoxphotosAfter = new System.Windows.Forms.ListBox();
            this.eleresi_ut = new System.Windows.Forms.TextBox();
            this.select_folder = new System.Windows.Forms.Button();
            this.eleresi_ut_2 = new System.Windows.Forms.TextBox();
            this.Credit = new System.Windows.Forms.Label();
            this.Lenght = new System.Windows.Forms.Label();
            this.Copied_files = new System.Windows.Forms.Label();
            this.Help_button = new System.Windows.Forms.Button();
            this.LiveHead_Label = new System.Windows.Forms.Label();
            this.Version_Label = new System.Windows.Forms.Label();
            this.Src_LBL = new System.Windows.Forms.Label();
            this.Cpy_LBL = new System.Windows.Forms.Label();
            this.customFileLabel = new System.Windows.Forms.Label();
            this.customFileNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeLanguage = new System.Windows.Forms.Button();
            this.allowFolderSort = new System.Windows.Forms.CheckBox();
            this.Open_From_Folder = new System.Windows.Forms.Button();
            this.Open_To_Folder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Select_Photos
            // 
            this.Select_Photos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(15)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.Select_Photos, "Select_Photos");
            this.Select_Photos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Select_Photos.Name = "Select_Photos";
            this.Select_Photos.UseVisualStyleBackColor = false;
            this.Select_Photos.Click += new System.EventHandler(this.Select_Photos_Click);
            this.Select_Photos.MouseLeave += new System.EventHandler(this.Select_Photos_MouseLeave);
            this.Select_Photos.MouseHover += new System.EventHandler(this.Select_Photos_MouseHover);
            // 
            // listBoxphotosBefore
            // 
            this.listBoxphotosBefore.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxphotosBefore, "listBoxphotosBefore");
            this.listBoxphotosBefore.Name = "listBoxphotosBefore";
            this.listBoxphotosBefore.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxphotosBefore_MouseDoubleClick_1);
            // 
            // Copy_Files
            // 
            this.Copy_Files.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.Copy_Files, "Copy_Files");
            this.Copy_Files.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Copy_Files.Name = "Copy_Files";
            this.Copy_Files.UseVisualStyleBackColor = false;
            this.Copy_Files.Click += new System.EventHandler(this.Change_Names_Click);
            this.Copy_Files.MouseLeave += new System.EventHandler(this.Copy_Files_MouseLeave);
            this.Copy_Files.MouseHover += new System.EventHandler(this.Copy_Files_MouseHover);
            // 
            // listBoxphotosAfter
            // 
            this.listBoxphotosAfter.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxphotosAfter, "listBoxphotosAfter");
            this.listBoxphotosAfter.Name = "listBoxphotosAfter";
            // 
            // eleresi_ut
            // 
            resources.ApplyResources(this.eleresi_ut, "eleresi_ut");
            this.eleresi_ut.Name = "eleresi_ut";
            // 
            // select_folder
            // 
            this.select_folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(15)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.select_folder, "select_folder");
            this.select_folder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.select_folder.Name = "select_folder";
            this.select_folder.UseVisualStyleBackColor = false;
            this.select_folder.Click += new System.EventHandler(this.select_folder_Click);
            this.select_folder.MouseLeave += new System.EventHandler(this.select_folder_MouseLeave);
            this.select_folder.MouseHover += new System.EventHandler(this.select_folder_MouseHover);
            // 
            // eleresi_ut_2
            // 
            resources.ApplyResources(this.eleresi_ut_2, "eleresi_ut_2");
            this.eleresi_ut_2.Name = "eleresi_ut_2";
            // 
            // Credit
            // 
            resources.ApplyResources(this.Credit, "Credit");
            this.Credit.Name = "Credit";
            // 
            // Lenght
            // 
            resources.ApplyResources(this.Lenght, "Lenght");
            this.Lenght.Name = "Lenght";
            // 
            // Copied_files
            // 
            resources.ApplyResources(this.Copied_files, "Copied_files");
            this.Copied_files.Name = "Copied_files";
            // 
            // Help_button
            // 
            this.Help_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.Help_button, "Help_button");
            this.Help_button.Name = "Help_button";
            this.Help_button.UseVisualStyleBackColor = true;
            this.Help_button.Click += new System.EventHandler(this.Help_button_Click);
            // 
            // LiveHead_Label
            // 
            resources.ApplyResources(this.LiveHead_Label, "LiveHead_Label");
            this.LiveHead_Label.Name = "LiveHead_Label";
            // 
            // Version_Label
            // 
            resources.ApplyResources(this.Version_Label, "Version_Label");
            this.Version_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Version_Label.Name = "Version_Label";
            // 
            // Src_LBL
            // 
            resources.ApplyResources(this.Src_LBL, "Src_LBL");
            this.Src_LBL.BackColor = System.Drawing.Color.Blue;
            this.Src_LBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Src_LBL.Name = "Src_LBL";
            // 
            // Cpy_LBL
            // 
            resources.ApplyResources(this.Cpy_LBL, "Cpy_LBL");
            this.Cpy_LBL.BackColor = System.Drawing.Color.Blue;
            this.Cpy_LBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cpy_LBL.Name = "Cpy_LBL";
            // 
            // customFileLabel
            // 
            resources.ApplyResources(this.customFileLabel, "customFileLabel");
            this.customFileLabel.Name = "customFileLabel";
            // 
            // customFileNameTextBox
            // 
            resources.ApplyResources(this.customFileNameTextBox, "customFileNameTextBox");
            this.customFileNameTextBox.Name = "customFileNameTextBox";
            // 
            // ChangeLanguage
            // 
            this.ChangeLanguage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.ChangeLanguage, "ChangeLanguage");
            this.ChangeLanguage.Name = "ChangeLanguage";
            this.ChangeLanguage.UseVisualStyleBackColor = true;
            this.ChangeLanguage.Click += new System.EventHandler(this.ChangeLanguage_Click);
            // 
            // allowFolderSort
            // 
            resources.ApplyResources(this.allowFolderSort, "allowFolderSort");
            this.allowFolderSort.Name = "allowFolderSort";
            this.allowFolderSort.UseVisualStyleBackColor = true;
            this.allowFolderSort.CheckedChanged += new System.EventHandler(this.allowFolderSort_CheckedChanged);
            // 
            // Open_From_Folder
            // 
            this.Open_From_Folder.BackColor = System.Drawing.Color.White;
            this.Open_From_Folder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.Open_From_Folder, "Open_From_Folder");
            this.Open_From_Folder.Name = "Open_From_Folder";
            this.Open_From_Folder.UseVisualStyleBackColor = false;
            this.Open_From_Folder.Click += new System.EventHandler(this.Open_From_Folder_Click);
            // 
            // Open_To_Folder
            // 
            this.Open_To_Folder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.Open_To_Folder, "Open_To_Folder");
            this.Open_To_Folder.Name = "Open_To_Folder";
            this.Open_To_Folder.UseVisualStyleBackColor = true;
            this.Open_To_Folder.Click += new System.EventHandler(this.Open_To_Folder_Click);
            // 
            // Renamer_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.Open_To_Folder);
            this.Controls.Add(this.Open_From_Folder);
            this.Controls.Add(this.allowFolderSort);
            this.Controls.Add(this.ChangeLanguage);
            this.Controls.Add(this.customFileNameTextBox);
            this.Controls.Add(this.customFileLabel);
            this.Controls.Add(this.Cpy_LBL);
            this.Controls.Add(this.Src_LBL);
            this.Controls.Add(this.Version_Label);
            this.Controls.Add(this.LiveHead_Label);
            this.Controls.Add(this.Help_button);
            this.Controls.Add(this.Copied_files);
            this.Controls.Add(this.Lenght);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.eleresi_ut_2);
            this.Controls.Add(this.select_folder);
            this.Controls.Add(this.eleresi_ut);
            this.Controls.Add(this.listBoxphotosAfter);
            this.Controls.Add(this.Copy_Files);
            this.Controls.Add(this.listBoxphotosBefore);
            this.Controls.Add(this.Select_Photos);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Renamer_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Select_Photos;
        private System.Windows.Forms.ListBox listBoxphotosBefore;
        private System.Windows.Forms.Button Copy_Files;
        private System.Windows.Forms.ListBox listBoxphotosAfter;
        private System.Windows.Forms.TextBox eleresi_ut;
        private System.Windows.Forms.Button select_folder;
        private System.Windows.Forms.TextBox eleresi_ut_2;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.Label Lenght;
        private System.Windows.Forms.Label Copied_files;
        private System.Windows.Forms.Button Help_button;
        private System.Windows.Forms.Label LiveHead_Label;
        private System.Windows.Forms.Label Version_Label;
        private System.Windows.Forms.Label Src_LBL;
        private System.Windows.Forms.Label Cpy_LBL;
        private System.Windows.Forms.Label customFileLabel;
        private System.Windows.Forms.TextBox customFileNameTextBox;
        private System.Windows.Forms.Button ChangeLanguage;
        private System.Windows.Forms.CheckBox allowFolderSort;
        private System.Windows.Forms.Button Open_From_Folder;
        private System.Windows.Forms.Button Open_To_Folder;
    }
}

