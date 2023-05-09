using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjecktArchiv
{
    internal class Class
    {
        //директория пустого архива
        private string archivePath;
        public Class() { }
        public Class(string archivePath)
        {
            this.archivePath = archivePath;
        }
        //создание пустого архива
        public string generate()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"C:\";
            save.RestoreDirectory = true;
            save.Title = "Generate empty archive";
            save.FileName = "Name.zip";
            save.Filter = "ZIP files (*.zip)|*.zip";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (var archive = ZipFile.Open(save.FileName, ZipArchiveMode.Create))
                {

                }
            }
            return save.FileName;
        }
        //сжатие одого файла в архив
        public void archiveFile()
        {
            string fileArchive;
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\";
            open.RestoreDirectory = true;
            open.Title = "Archive file";

            if (open.ShowDialog() == DialogResult.OK)
            {
                //директория и название файла который будет архивирован
                fileArchive = open.FileName;

                using (ZipArchive archive = ZipFile.Open(archivePath, ZipArchiveMode.Update))
                {
                    if (File.Exists(fileArchive))
                    {
                        archive.CreateEntryFromFile(fileArchive, Path.GetFileName(fileArchive), CompressionLevel.Optimal);
                    }
                }
            }
        }
        //сжать папку файлов(в папке не будет других папок) в архив
        public void archiveFolder()
        {
            var folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                using (ZipArchive archive = ZipFile.Open(archivePath, ZipArchiveMode.Update))
                {
                    foreach (string filePath in Directory.GetFiles(folderPath))
                    {
                        archive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
                    }
                }
            }
        }
        //разархивирование ВСЕХ файлов из архива
        public void extractFrom()
        {
            //директория архива
            string pathArchive;

            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\";
            open.RestoreDirectory = true;
            open.Title = "Unzip files";
            open.Filter = "ZIP files (*.zip)|*.zip";

            if (open.ShowDialog() == DialogResult.OK)
            {
                //директория архива
                pathArchive = open.FileName;

                var folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    ZipFile.ExtractToDirectory(pathArchive, folderPath);
                }
            }
        }
        //создание архива и сжатие в архив файл
        public void createAndArchiveFile()
        {
            string fileArchive;
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\";
            open.RestoreDirectory = true;
            open.Title = "Archive file";

            if (open.ShowDialog() == DialogResult.OK)
            {
                //директория файла с названием файла
                fileArchive = open.FileName;
                //директория файла
                string directoryName = Path.GetDirectoryName(fileArchive);
                //разделение директории файла
                string[] values = fileArchive.Split('\\');
                string value1 = values[values.Length - 1];
                //разделение файла и разшерения
                string[] values2 = value1.Split('.');
                string value2 = values2[0];
                //название файла
                //value2 + ".zip"
                //создание архива в директории файла с названием файла
                using (var archive = ZipFile.Open(directoryName + '\\' + value2 + ".zip", ZipArchiveMode.Create))
                {

                }
                //сжитие файла в архив
                using (ZipArchive archive = ZipFile.Open(directoryName + '\\' + value2 + ".zip", ZipArchiveMode.Update))
                {
                    if (File.Exists(fileArchive))
                    {
                        archive.CreateEntryFromFile(fileArchive, Path.GetFileName(fileArchive), CompressionLevel.Optimal);
                    }
                }
            }
        }
        //создание архива и сжатие в архив папку
        public void createAndArchiveFolder()
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                //директория папки
                string directoryName = Path.GetDirectoryName(folderPath);

                //разделение директории файла
                string[] values = folderPath.Split('\\');
                string value1 = values[values.Length - 1];

                //разделение файла и разшерения
                string[] values2 = value1.Split('.');
                string value2 = values2[0];

                //название файла
                //value2 + ".zip"

                //создание архива в директории файла с названием файла
                using (var archive = ZipFile.Open(directoryName + '\\' + value2 + ".zip", ZipArchiveMode.Create))
                {

                }
                using (ZipArchive archive = ZipFile.Open(directoryName + '\\' + value2 + ".zip", ZipArchiveMode.Update))
                {
                    foreach (string filePath in Directory.GetFiles(folderPath))
                    {
                        archive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
                    }
                }
            }
        }
    }
}
