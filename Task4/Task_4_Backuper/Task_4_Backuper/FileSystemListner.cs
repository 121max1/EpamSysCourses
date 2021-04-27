using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4_Backuper
{
    class FileSystemListner: IDisposable
    {
        public string DirectoryPath { get; private set; }

        private FileSystemWatcher _fileSystemWatcher;
        public FileSystemListner(string directoryPath)
        {
            DirectoryPath = directoryPath;
            _fileSystemWatcher = new FileSystemWatcher(DirectoryPath);
        }
        public void Start()
        {
            _fileSystemWatcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;


            _fileSystemWatcher.Changed += MoveToConservation;
            _fileSystemWatcher.Deleted += MoveToConservation;
            _fileSystemWatcher.Renamed += MoveToConservation;
            _fileSystemWatcher.Created += MoveToConservation;

            _fileSystemWatcher.Filter = "*.txt";
            _fileSystemWatcher.IncludeSubdirectories = true;
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        private void MoveToConservation(object sender, FileSystemEventArgs e)
        {
            string timeOfCreation = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss").Replace(":", "_");
            Directory.CreateDirectory($"../../../Conservation/{timeOfCreation}");
            DirectoryWorker directoryWorker = new DirectoryWorker($"../../../Main");
            directoryWorker.CopyTo($"../../../Conservation/{timeOfCreation}");
        }

        public void Dispose()
        {
            _fileSystemWatcher?.Dispose();
        }
    }
}

