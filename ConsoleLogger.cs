using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5_Maric
{
    public class ConsoleLogger
    {
        private static ConsoleLogger instance;
        private string filePath;

        public ConsoleLogger()
        {
            this.filePath = @"C:\Users\Ricma\Desktop\RPPOON - labosi\lv5_Maric\txt.txt";
        }

        public static ConsoleLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }
            return instance;
        }

        public void SetFilePath(string filePath) { this.filePath = filePath; }

        public void LogMessage(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now:dd-MM-yyyy} | {message}");
            }
        }
    }
}
