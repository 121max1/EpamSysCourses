using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Task_4_Backuper
{
    public static class FileSystemBackuper
    {
        
        public static void Rollback(DateTime dateTimeRollback, string backupFolderPath , string mainFolderPath)
        {
            var dirs = new DirectoryInfo(backupFolderPath).GetDirectories();
            var dirDateTimes = dirs.Select(d => DateTime.ParseExact(d.Name.Replace('_', ':'), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture));
            if(dateTimeRollback < dirDateTimes.FirstOrDefault())
            {
                throw new DirectoryNotFoundException("Directory can't be rollbacked to this date");
            }
            var backupDateTime = dirDateTimes.FirstOrDefault();

            foreach (var dt in dirDateTimes)
            {
                if (dateTimeRollback >= dt)
                    backupDateTime = dt;
                else
                    break;
            }

            DirectoryWorker directoryWorker = new DirectoryWorker(mainFolderPath);
            directoryWorker.CleanDirectory();
            DirectoryWorker directoryWorker1Conservation = new DirectoryWorker($"{backupFolderPath}/{backupDateTime.ToString("dd.MM.yyyy HH_mm_ss")}");
            directoryWorker1Conservation.CopyTo(mainFolderPath);
 
        }
    }
}
