using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assign3
{
    class Ques3
    {
        public void Program()
        {
            try
            {
                Console.WriteLine("Enter File path");
                string Path = Console.ReadLine();
                if (Uri.IsWellFormedUriString(Path, UriKind.Absolute))
                {
                    throw new MyExceptions("Path Entered is Invalid");
                }
                if (!File.Exists(Path))
                {
                    throw new MyExceptions("File does not exists");
                }
                string value1 = File.ReadAllText(Path);
                Console.WriteLine("File Content :");
                Console.WriteLine(value1);
            }
            catch (MyExceptions) { }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadKey();
            }


        }
    }
}
