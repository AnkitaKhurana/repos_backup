using System;

namespace Assign2
{
    class Program 
    {

        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter Option :");
                Console.WriteLine("1...........Ques 1");
                Console.WriteLine("2...........Ques 2");
                Console.WriteLine("3...........Ques 3");
                Console.WriteLine("4...........Ques 4");
                Console.WriteLine("5...........Exit");
                int n;
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    throw (new MyExceptions("Input string was not in a correct format."));
                   
                }
                switch (n)
                {
                    case 1:
                        Ques1 ques1 = new Ques1();
                        Console.WriteLine("Enter File Name");
                        string fileName = Console.ReadLine();
                        Console.WriteLine("Enter Path");
                        string Path = Console.ReadLine();
                        if (Uri.IsWellFormedUriString(Path,UriKind.Absolute)) 
                        {
                            throw new MyExceptions("Path Entered is Invalid");
                        }
                        Console.WriteLine(value: ques1.FileExists(fileName, Path));
                        break;
                    case 2:
                        Ques2 ques2 = new Ques2();
                        Console.WriteLine("Enter Size of Cache ");
                        int size;
                        if (!int.TryParse(Console.ReadLine(), out size))
                        {
                            throw (new MyExceptions("Input string was not in a correct format."));

                        }
                        ques2.SendData(size);
                        break;
                    case 3:
                        Ques3 ques3 = new Ques3();
                        ques3.program();
                        break;
                    case 4:
                        Ques4 ques4 = new Ques4();                        
                        ques4.SendData();
                        break;
                    case 5: System.Environment.Exit(1);
                        break;
                    default: System.Environment.Exit(1);
                        break;

                }

                Console.ReadKey();

            }
            catch (MyExceptions e)
            {
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}
