using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasicOfCSharp
{
    class StudentDetails
    {
        public void DoActions()
        {
            string[] contents;
            string id, details;
            bool t = true;
           
            while (t) {
                Console.WriteLine("Enter a No. to execute:");
                Console.WriteLine("1. Add Data");
                Console.WriteLine("2. Update Data");
                Console.WriteLine("3. Delete Data");
                Console.WriteLine("4. Delete File");
                Console.WriteLine("5. Display Data.");
                Console.WriteLine("6. Exit");
                string n = Console.ReadLine();
                if (n == "6")
                {
                    t = false;
                    break;
                }
                switch (n)
                {
                    case "1":
                        if (!File.Exists("C://Users//K_Swati_Subudhi//Desktop//employee.txt"))
                        {
                            File.Create("C://Users//K_Swati_Subudhi//Desktop//employee.txt");
                        }
                        details = File.ReadAllText("C://Users//K_Swati_Subudhi//Desktop//employee.txt");
                        Console.WriteLine("Enter details in this format: Id,Name, Dept:");
                        string str = Console.ReadLine();
                           
                        File.WriteAllText("C://Users//K_Swati_Subudhi//Desktop//employee.txt", details+"\n"+str);
                        break;
                    case "2":
                        Console.WriteLine("Enter Student Id to Update:");
                        id = Console.ReadLine();
                        Console.WriteLine("Enter Updated Student details in this format: Id,Name, Dept");
                        details = Console.ReadLine();
                        contents = File.ReadAllLines("C://Users//K_Swati_Subudhi//Desktop//employee.txt");
                        for (int i = 0; i < contents.Length; i++)
                        {
                            string[] st = contents[i].Split(',');
                            if (st[0] == id)
                            {
                                contents[i] = details ;
                                break;
                            }
                        }
                        string content = String.Empty;
                        for (int i = 0; i < contents.Length; i++)
                        {
                            content  = content+"\n"+contents[i];
                        }
                            File.WriteAllText("C://Users//K_Swati_Subudhi//Desktop//employee.txt", content);
                        break;
                    case "3":
                        Console.WriteLine("Enter Student Id to Delete:");
                        id = Console.ReadLine();
                        contents = File.ReadAllLines("C://Users//K_Swati_Subudhi//Desktop//employee.txt");
                        List<string> list = new List<string>(contents);
                        for (int i = 0; i < contents.Length; i++)
                        {
                            string[] st = contents[i].Split(',');

                            if (st[0] == id)
                            {
                                list.RemoveAt(i);
                                contents = list.ToArray();
                                break;
                            }
                        }
                        File.WriteAllText("C://Users//K_Swati_Subudhi//Desktop//employee.txt", contents + "\n");
                        break;
                    case "4":

                        if (File.Exists("C://Users//K_Swati_Subudhi//Desktop//employee.txt"))
                        {
                            File.Delete("C://Users//K_Swati_Subudhi//Desktop//employee.txt");
                        }
                        Console.WriteLine("File Deleted.");
                        break;
                    case "5":
                        if (File.Exists("C://Users//K_Swati_Subudhi//Desktop//employee.txt"))
                        {
                            contents = File.ReadAllLines("C://Users//K_Swati_Subudhi//Desktop//employee.txt");
                            foreach (string line in contents)
                            {
                                Console.WriteLine(line);
                            }
                        }
                        else
                        {
                            Console.WriteLine("File does not Exist.");
                        }
                        break;
                    case "6":
                        return;
                        
                }

            }
        }
    }
}
