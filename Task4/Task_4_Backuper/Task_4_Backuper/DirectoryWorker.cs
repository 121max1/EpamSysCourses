using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Backuper
{
    public class DirectoryWorker
    {
        public string SourceDirectoryPath { get; private set; }

        public DirectoryWorker(string path)
        {
            SourceDirectoryPath = path;
        }

        public void CopyTo(string destinationPath)
        {
            foreach (string dirPath in Directory.GetDirectories(SourceDirectoryPath, "*",
                                                    SearchOption.AllDirectories))
            {
                try
                {
                    Directory.CreateDirectory(dirPath.Replace(SourceDirectoryPath, destinationPath));
                }
                catch(Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            foreach (string newPath in Directory.GetFiles(SourceDirectoryPath, "*.*",
                                        SearchOption.AllDirectories))
            {
                try
                {
                    File.Copy(newPath, newPath.Replace(SourceDirectoryPath, destinationPath), true);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public void CleanDirectory()
        {
            var dir = new DirectoryInfo(SourceDirectoryPath);


            foreach (var file in dir.GetFiles())
            {
                File.Delete(file.FullName);
            }

            foreach (var subDir in dir.GetDirectories())
            {
                if (subDir.FullName.Contains(SourceDirectoryPath))
                    continue;

                Directory.Delete(subDir.FullName, true);
            }
        }


    }
}
