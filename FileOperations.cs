using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasicOfCSharp
{
    class FileOperations
    {
        public void WriteFile()
        {
            string content = "Name, Id, Dept";
            File.WriteAllText("C://Users//K_Swati_Subudhi//Desktop//employee.txt", content);
        }

        public void UpdateFile()
        {
            string employee = "\nJonDoe, 1, Finance";
            File.AppendAllText("C://Users//K_Swati_Subudhi//Desktop//employee.txt", employee);
        }

        public void ReadFile()
        {
            string content = File.ReadAllText("D//employee.txt");
            Console.WriteLine(content);
            string[] contents = File.ReadAllLines("C://Users//K_Swati_Subudhi//Desktop//employee.txt");
            foreach(string line in contents)
            {
                Console.WriteLine(line);
            }
        }

        public void DeleteFile()
        {
            if (File.Exists("C://Users//K_Swati_Subudhi//Desktop//employee.txt"))
            {
                File.Delete("C://Users//K_Swati_Subudhi//Desktop//employee.txt");
            }
        }
    }
}
