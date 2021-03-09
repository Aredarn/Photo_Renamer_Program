
namespace Renaming_Prog.Forms
{
    partial class HowToUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToUse));
            this.Info_Label = new System.Windows.Forms.Label();
            this.PRG_Label = new System.Windows.Forms.Label();
            this.What_For_Label = new System.Windows.Forms.Label();
            this.Info_Label2 = new System.Windows.Forms.Label();
            this.Files_Lbl = new System.Windows.Forms.Label();
            this.Info_Label_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info_Label
            // 
            this.Info_Label.AutoSize = true;
            this.Info_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info_Label.Location = new System.Drawing.Point(4, 110);
            this.Info_Label.Name = "Info_Label";
            this.Info_Label.Size = new System.Drawing.Size(353, 48);
            this.Info_Label.TabIndex = 0;
            this.Info_Label.Text = "1. Select a folder where the photos are. \r\n2. Select a folder where would you lik" +
    "e to copy these files.\r\n3. Click copy and your photos will be copied and renamed" +
    ".";
            // 
            // PRG_Label
            // 
            this.PRG_Label.AutoSize = true;
            this.PRG_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PRG_Label.Location = new System.Drawing.Point(3, 90);
            this.PRG_Label.Name = "PRG_Label";
            this.PRG_Label.Size = new System.Drawing.Size(219, 20);
            this.PRG_Label.TabIndex = 1;
            this.PRG_Label.Text = "How to use this program?:";
            // 
            // What_For_Label
            // 
            this.What_For_Label.AutoSize = true;
            this.What_For_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.What_For_Label.Location = new System.Drawing.Point(3, 9);
            this.What_For_Label.Name = "What_For_Label";
            this.What_For_Label.Size = new System.Drawing.Size(240, 20);
            this.What_For_Label.TabIndex = 2;
            this.What_For_Label.Text = "What does this program do?:";
            // 
            // Info_Label2
            // 
            this.Info_Label2.AutoSize = true;
            this.Info_Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info_Label2.Location = new System.Drawing.Point(4, 29);
            this.Info_Label2.Name = "Info_Label2";
            this.Info_Label2.Size = new System.Drawing.Size(360, 32);
            this.Info_Label2.TabIndex = 3;
            this.Info_Label2.Text = "This program copies and renames photos to the date when \r\n they were taken to a u" +
    "ser specified folder.\r\n";
            // 
            // Files_Lbl
            // 
            this.Files_Lbl.AutoSize = true;
            this.Files_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Files_Lbl.Location = new System.Drawing.Point(3, 169);
            this.Files_Lbl.Name = "Files_Lbl";
            this.Files_Lbl.Size = new System.Drawing.Size(280, 20);
            this.Files_Lbl.TabIndex = 4;
            this.Files_Lbl.Text = "What files can this program copy?";
            // 
            // Info_Label_3
            // 
            this.Info_Label_3.AutoSize = true;
            this.Info_Label_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info_Label_3.Location = new System.Drawing.Point(4, 189);
            this.Info_Label_3.Name = "Info_Label_3";
            this.Info_Label_3.Size = new System.Drawing.Size(308, 80);
            this.Info_Label_3.TabIndex = 5;
            this.Info_Label_3.Text = "The following files can be copied with this program:\r\n- JPG\r\n- JPEG\r\n- PNG\r\n- MP4" +
    "\r\n";
            // 
            // HowToUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 271);
            this.Controls.Add(this.Info_Label_3);
            this.Controls.Add(this.Files_Lbl);
            this.Controls.Add(this.Info_Label2);
            this.Controls.Add(this.What_For_Label);
            this.Controls.Add(this.PRG_Label);
            this.Controls.Add(this.Info_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HowToUse";
            this.Text = "HowToUse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info_Label;
        private System.Windows.Forms.Label PRG_Label;
        private System.Windows.Forms.Label What_For_Label;
        private System.Windows.Forms.Label Info_Label2;
        private System.Windows.Forms.Label Files_Lbl;
        private System.Windows.Forms.Label Info_Label_3;
    }
}