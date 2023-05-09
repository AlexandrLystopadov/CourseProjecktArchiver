namespace CourseProjecktArchiv
{
    partial class Form1
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
            this.generateArchive = new System.Windows.Forms.Button();
            this.fileToArchive = new System.Windows.Forms.Button();
            this.folderToArchive = new System.Windows.Forms.Button();
            this.extractFromArchive = new System.Windows.Forms.Button();
            this.archiveFile = new System.Windows.Forms.Button();
            this.archiveFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateArchive
            // 
            this.generateArchive.Location = new System.Drawing.Point(12, 32);
            this.generateArchive.Name = "generateArchive";
            this.generateArchive.Size = new System.Drawing.Size(180, 50);
            this.generateArchive.TabIndex = 0;
            this.generateArchive.Text = "Создать пустой архив";
            this.generateArchive.UseVisualStyleBackColor = true;
            this.generateArchive.Click += new System.EventHandler(this.generateArchive_Click);
            // 
            // fileToArchive
            // 
            this.fileToArchive.Location = new System.Drawing.Point(12, 116);
            this.fileToArchive.Name = "fileToArchive";
            this.fileToArchive.Size = new System.Drawing.Size(180, 50);
            this.fileToArchive.TabIndex = 1;
            this.fileToArchive.Text = "Сжать файл в архив";
            this.fileToArchive.UseVisualStyleBackColor = true;
            this.fileToArchive.Click += new System.EventHandler(this.fileToArchive_Click);
            // 
            // folderToArchive
            // 
            this.folderToArchive.Location = new System.Drawing.Point(254, 116);
            this.folderToArchive.Name = "folderToArchive";
            this.folderToArchive.Size = new System.Drawing.Size(180, 50);
            this.folderToArchive.TabIndex = 2;
            this.folderToArchive.Text = "сжать папку в архив";
            this.folderToArchive.UseVisualStyleBackColor = true;
            this.folderToArchive.Click += new System.EventHandler(this.folderToArchive_Click);
            // 
            // extractFromArchive
            // 
            this.extractFromArchive.Location = new System.Drawing.Point(254, 199);
            this.extractFromArchive.Name = "extractFromArchive";
            this.extractFromArchive.Size = new System.Drawing.Size(180, 50);
            this.extractFromArchive.TabIndex = 3;
            this.extractFromArchive.Text = "Разархивировать архив";
            this.extractFromArchive.UseVisualStyleBackColor = true;
            this.extractFromArchive.Click += new System.EventHandler(this.extractFromArchive_Click);
            // 
            // archiveFile
            // 
            this.archiveFile.Location = new System.Drawing.Point(254, 32);
            this.archiveFile.Name = "archiveFile";
            this.archiveFile.Size = new System.Drawing.Size(180, 50);
            this.archiveFile.TabIndex = 4;
            this.archiveFile.Text = "Архивировать файл";
            this.archiveFile.UseVisualStyleBackColor = true;
            this.archiveFile.Click += new System.EventHandler(this.archiveFile_Click);
            // 
            // archiveFolder
            // 
            this.archiveFolder.Location = new System.Drawing.Point(12, 199);
            this.archiveFolder.Name = "archiveFolder";
            this.archiveFolder.Size = new System.Drawing.Size(180, 50);
            this.archiveFolder.TabIndex = 6;
            this.archiveFolder.Text = "Архивировать папку";
            this.archiveFolder.UseVisualStyleBackColor = true;
            this.archiveFolder.Click += new System.EventHandler(this.archiveFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Создать пустой архив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сжать файл в пустой архив";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сжать папку в пустой архив";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сжать файл в архив";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Сжать папку в архив";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Разархивация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 259);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.archiveFolder);
            this.Controls.Add(this.archiveFile);
            this.Controls.Add(this.extractFromArchive);
            this.Controls.Add(this.folderToArchive);
            this.Controls.Add(this.fileToArchive);
            this.Controls.Add(this.generateArchive);
            this.Name = "Form1";
            this.Text = "Archiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateArchive;
        private System.Windows.Forms.Button fileToArchive;
        private System.Windows.Forms.Button folderToArchive;
        private System.Windows.Forms.Button extractFromArchive;
        private System.Windows.Forms.Button archiveFile;
        private System.Windows.Forms.Button archiveFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

