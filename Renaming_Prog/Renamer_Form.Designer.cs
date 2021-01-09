namespace Renaming_Prog
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
            this.SuspendLayout();
            // 
            // Select_Photos
            // 
            this.Select_Photos.BackColor = System.Drawing.Color.Crimson;
            this.Select_Photos.Location = new System.Drawing.Point(12, 12);
            this.Select_Photos.Name = "Select_Photos";
            this.Select_Photos.Size = new System.Drawing.Size(216, 63);
            this.Select_Photos.TabIndex = 0;
            this.Select_Photos.Text = "Select a folder (From where to copy)";
            this.Select_Photos.UseVisualStyleBackColor = false;
            this.Select_Photos.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxphotosBefore
            // 
            this.listBoxphotosBefore.FormattingEnabled = true;
            this.listBoxphotosBefore.Location = new System.Drawing.Point(12, 107);
            this.listBoxphotosBefore.Name = "listBoxphotosBefore";
            this.listBoxphotosBefore.Size = new System.Drawing.Size(217, 264);
            this.listBoxphotosBefore.TabIndex = 1;
            this.listBoxphotosBefore.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxphotosBefore_MouseDoubleClick);
            // 
            // Copy_Files
            // 
            this.Copy_Files.Location = new System.Drawing.Point(12, 386);
            this.Copy_Files.Name = "Copy_Files";
            this.Copy_Files.Size = new System.Drawing.Size(455, 46);
            this.Copy_Files.TabIndex = 2;
            this.Copy_Files.Text = "Copy_Files";
            this.Copy_Files.UseVisualStyleBackColor = true;
            this.Copy_Files.Click += new System.EventHandler(this.Change_Names_Click);
            // 
            // listBoxphotosAfter
            // 
            this.listBoxphotosAfter.FormattingEnabled = true;
            this.listBoxphotosAfter.Location = new System.Drawing.Point(250, 107);
            this.listBoxphotosAfter.Name = "listBoxphotosAfter";
            this.listBoxphotosAfter.Size = new System.Drawing.Size(218, 264);
            this.listBoxphotosAfter.TabIndex = 3;
            // 
            // eleresi_ut
            // 
            this.eleresi_ut.Location = new System.Drawing.Point(12, 81);
            this.eleresi_ut.Name = "eleresi_ut";
            this.eleresi_ut.Size = new System.Drawing.Size(216, 20);
            this.eleresi_ut.TabIndex = 4;
            this.eleresi_ut.Text = "C:\\\\";
            // 
            // select_folder
            // 
            this.select_folder.BackColor = System.Drawing.Color.Crimson;
            this.select_folder.Location = new System.Drawing.Point(250, 12);
            this.select_folder.Name = "select_folder";
            this.select_folder.Size = new System.Drawing.Size(218, 63);
            this.select_folder.TabIndex = 5;
            this.select_folder.Text = "Select a folder (To where to copy)";
            this.select_folder.UseVisualStyleBackColor = false;
            this.select_folder.Click += new System.EventHandler(this.select_folder_Click);
            // 
            // eleresi_ut_2
            // 
            this.eleresi_ut_2.Location = new System.Drawing.Point(249, 81);
            this.eleresi_ut_2.Name = "eleresi_ut_2";
            this.eleresi_ut_2.Size = new System.Drawing.Size(218, 20);
            this.eleresi_ut_2.TabIndex = 6;
            this.eleresi_ut_2.Text = "...";
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Location = new System.Drawing.Point(333, 439);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(139, 13);
            this.Credit.TabIndex = 7;
            this.Credit.Text = "Developer: Martin Mészáros";
            // 
            // Renamer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.eleresi_ut_2);
            this.Controls.Add(this.select_folder);
            this.Controls.Add(this.eleresi_ut);
            this.Controls.Add(this.listBoxphotosAfter);
            this.Controls.Add(this.Copy_Files);
            this.Controls.Add(this.listBoxphotosBefore);
            this.Controls.Add(this.Select_Photos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Renamer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy_Rename_Program7";
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
    }
}

