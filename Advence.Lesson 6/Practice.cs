using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Advence.Lesson_6
{
    public partial class Practice
    {
        /// <summary>
        /// AL6-P1/7-DirInfo. Вывести на консоль следующую информацию о каталоге “c://Program Files”:
        /// Имя
        /// Дата создания
        /// </summary>
        public static void AL6_P1_7_DirInfo()
        {
            var dirInfo = new DirectoryInfo("c://Program Files");
            Console.WriteLine(dirInfo.Name);
            Console.WriteLine(dirInfo.CreationTime);
        }


        /// <summary>
        /// AL6-P2/7-FileInfo. Получить список файлов каталога и для каждого вывести значение:
        /// Имя
        /// Дата создания
        /// Размер 
        /// </summary>
        public static void AL6_P2_7_FileInfo()
        {
            var dirInfo = new DirectoryInfo("C://Users/User/Desktop/A-4(6)-Files, Streams, Serialziation/Advence.Lesson 6");
            foreach (var file in dirInfo.GetFiles("*.cs"))
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.CreationTime);
                Console.WriteLine(file.Length);
            }
        }

        /// <summary>
        /// AL6-P3/7-CreateDir. Создать пустую директорию “c://Program Files Copy”.
        /// </summary>
        public static void AL6_P3_7_CreateDir()
        {
            Directory.CreateDirectory("c://Program Files Copy");
        }


        /// <summary>
        /// AL6-P4/7-CopyFile. Скопировать первый файл из Program Files в новую папку.
        /// </summary>
        public static void AL6_P4_7_CopyFile()
        {
            var dirInfo = new DirectoryInfo("C://Users/User/Desktop/A-4(6)-Files, Streams, Serialziation/Advence.Lesson 6");
            var files = dirInfo.GetFiles("*.cs");
            Directory.CreateDirectory("C://Users/User/Desktop/A-4(6)-Files, Streams, Serialziation/Advence.Lesson 6 Copy");
            files[0].CopyTo("C://Users/User/Desktop/A-4(6)-Files, Streams, Serialziation/Advence.Lesson 6 Copy/" + files[0].Name);
        }

        /// <summary>
        /// AL6-P5/7-FileChat. Написать программу имитирующую чат. 
        /// Пускай в ней будут по очереди запрашивается реплики для User 1 и User 2 (используйте цикл из 5-10 итераций).  Сохраняйте данные реплики с ником пользователя и датой в файл на диске.
        /// </summary>
        public static void AL6_P5_7_FileChat()
        {
            var adapter = new StreamWriter("D:/History.txt", true );
            string str;
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("User 1");
                }
                else
                {
                    Console.WriteLine("User 2");
                }

                str = Console.ReadLine();
                adapter.WriteLine(DateTime.Now.ToString());
                if (i % 2 == 0)
                {
                    adapter.WriteLine("User 1: ");
                }
                else
                {
                    adapter.WriteLine("User 2: ");
                }
                adapter.WriteLine(str);

            }
            adapter.Close();
        }

        /// <summary>
        /// AL6-P6/7-ConsoleSrlz. (Демонстрация). 
        /// Сериализовать обьект класса Song в XML.Вывести на консоль.
        /// Десериализовать XML из строковой переменной в объект.
        /// </summary>
        public static void AL6_P6_7_ConsoleSrlzn()
        {
            Song song = new Song()
            {
                Title = "Title 1",
                Duration = 247,
                Lyrics = "Lyrics 1"
            };
           

        }

        /// <summary>
        /// AL6-P7/7-FileSrlz.
        /// Отредактировать предыдущий пример для поддержки сериализации и десериализации в файл.
        /// </summary>
        public static void AL6_P7_7_FileSrlz()
        {

        }

    }
}
