using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjecktArchiv
{
    public partial class Form1 : Form
    {
        //директория пустого архива
        private string archivePath;
        private bool step = false;
        public Form1()
        {
            InitializeComponent();
        }
        //создание пустого архива
        private void generateArchive_Click(object sender, EventArgs e)
        {
            Class cls = new Class();
            archivePath = cls.generate();
            step = true;
        }
        //сжатие файла в пустой архив
        private void fileToArchive_Click(object sender, EventArgs e)
        {
            if (step)
            {
                Class cls = new Class(archivePath);
                cls.archiveFile();
            }
        }
        //сжатие папку в пустой архив
        private void folderToArchive_Click(object sender, EventArgs e)
        {
            if (step)
            {
                Class cls = new Class(archivePath);
                cls.archiveFolder();
            }
        }
        //разархивация всех файлов
        private void extractFromArchive_Click(object sender, EventArgs e)
        {
            Class cls = new Class();
            cls.extractFrom();
        }
        //сжатие файла в архив
        private void archiveFile_Click(object sender, EventArgs e)
        {
            Class cls = new Class();
            cls.createAndArchiveFile();
        }
        //сжатие папки в архив
        private void archiveFolder_Click(object sender, EventArgs e)
        {
            Class cls = new Class();
            cls.createAndArchiveFolder();
        }
    }
}
