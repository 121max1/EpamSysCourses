using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Backuper
{
    public enum WorkingMode
    {
        Listening,
        Backaping
    }

    public class Program
    {
        static WorkingMode workingMode = WorkingMode.Listening;
        private static void PrintModeMenu()
        {
            Console.WriteLine("1.Наблюдение" + Environment.NewLine + "2.Откат изменений");
        }
        static void Main()
        {
            Console.WriteLine("Выберите режим работы: ");
            PrintModeMenu();
            Console.Write("Ваш выбор:");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                workingMode = WorkingMode.Listening;
                FileSystemListner fileSystemListner = new FileSystemListner("../../../Main");
                fileSystemListner.Start();
                Console.WriteLine("Приложение запущено в режиме Прослушивания"
                    + Environment.NewLine + "Чтобы выйти нажмите любую кнопку");
                Console.ReadKey();
            }
            else
            {
                workingMode = WorkingMode.Backaping;

                Console.WriteLine("Приложение запущено в режиме отката Изменений!");
                while (true)
                {
                    DateTime backupDate = EnterDateTime();
                    FileSystemBackuper.Rollback(backupDate, "../../../Conservation", "../../../Main");
                }




            }
            

        }
        private static DateTime EnterDateTime()
        {
            do
            {
                Console.Write("Введите дату и время отката в формате 'дд.ММ.гггг чч:мм:сс': ");
                var dateTime = Console.ReadLine();
                if (DateTime.TryParseExact(dateTime, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                    return result;
                else
                    Console.WriteLine("Введенное время некорректное, введите еще раз:");

            } while (true);
        }


    }
}
