using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Singleton
{
    class Log
    {
        Log() { } // закрытый конструктор

        static Log myLog = null;

        public static Log MyLog // статическое свойство для контроля за созданием объекта
        {
            get
            {
                if (myLog == null)
                {
                    myLog = new Log();
                }
                return myLog;
            }
        }

        public void LogExecution(string mes)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Loger(mes, w);
               // w.Close();//Файл будет закрыт автоматически при выходе из блока using
            }
        }

        private static void Loger(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("Действие: {0}", logMessage);
            w.WriteLine("-------------------------------");
        }
    }
}
