using System;

namespace Assign3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Option :");
                Console.WriteLine("1....Ques1");
                Console.WriteLine("2....Ques2");
                Console.WriteLine("3....Ques3");
                Console.WriteLine("4....Exit");
                int ans;
                if (!int.TryParse(Console.ReadLine(), out ans))
                {
                    throw (new MyExceptions("Input string was not in a correct format."));

                }
                switch (ans)
                {
                    case 1:
                        Ques1 ques1 = new Ques1();
                        ques1.Program();
                        break;
                    case 2:
                        Ques2 ques2 = new Ques2();
                        ques2.Program();
                        break;
                    case 3:
                        Ques3 ques3 = new Ques3();
                        ques3.Program();
                        break;
                    case 4:
                        System.Environment.Exit(1);
                        break;
                    default:
                        System.Environment.Exit(1);
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
