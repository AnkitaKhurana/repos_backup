using System;

namespace Bank
{


    class Program
    {
        static PriorityQueue customers = new PriorityQueue();
       
        // Send Token to Customer
        static void SendToken(Counter[] BankCounter, int size)
        {
            for (int index = 0; index < size; index++)
            {
                if (BankCounter[index].Status == AssignedStatus.vacant)
                {
                    if (customers.Top() != null)
                    {
                        Console.WriteLine(customers.Top().GetName() + " please goto counter " + (index + 1));
                        BankCounter[index].AssignedTo = customers.Top();
                        customers.Pop();
                        BankCounter[index].Status = AssignedStatus.occupied;

                    }

                }
            }
        }

        // Display Current Status of counter
        static void Status(Counter[] BankCounter, int size)
        {
            for (int index = 0; index < size; index++)
            {
                if (BankCounter[index].Status == AssignedStatus.occupied)
                    Console.Write(BankCounter[index].AssignedTo.GetName());
                else
                    Console.Write("Vacant");
                Console.Write(" || ");
            }
        }

        // Add New Customer
        static void AddCustomer(Counter[] BankCounter, int size)
        {
            Console.WriteLine("Enter Customer Name ");
            string name = Console.ReadLine();
            if (name == "") //___ space == null or empty check string.isNullOrEmpty
            {
                throw (new Exception("Name Cannot be blank"));
            }
            Console.WriteLine("Enter Customer Priority(0: Priveleged, 1:Normal)");
            if (!int.TryParse(Console.ReadLine(), out int key))
            {
                throw (new Exception("Input string was not in a correct format."));
            }
            Customer newCustomer = new Customer(name, key);
            customers.Push(newCustomer);
            SendToken(BankCounter, size);
            Console.ReadKey();
        }

        // Waiting Customer List
        static void WaitingCustomers()
        {
            Console.WriteLine("Waiting Customers: " + customers.GetSize());
            Console.ReadKey();
        }
        // Change Status of Counter
        static void ChangeStatus(Counter[] BankCounter, int size)
        {
            Status(BankCounter, size);
            Console.WriteLine("\nEnter Counter Number:");
            if (!int.TryParse(Console.ReadLine(), out int CounterNumber))
            {
                throw (new Exception("Input string was not in a correct format."));
            }
            if (BankCounter[CounterNumber - 1].Status == AssignedStatus.occupied)
            {
                BankCounter[CounterNumber - 1].Status = AssignedStatus.vacant;
                if (customers.Top() != null)
                {
                    Console.WriteLine(customers.Top().GetName() + " please goto counter " + (CounterNumber));
                    BankCounter[CounterNumber - 1].AssignedTo = customers.Top();
                    customers.Pop();
                    BankCounter[CounterNumber - 1].Status = AssignedStatus.occupied;
                }

            }
            Status(BankCounter, size);
            Console.ReadKey();
        }

        // Display Menu
        static void Menu(Counter[] bankCounter, int counters)
        {
            Console.Clear();
            Console.WriteLine("1.........Add New Customer");
            Console.WriteLine("2.........Check Counter Status");
            Console.WriteLine("3.........Change Counter Status");
            Console.WriteLine("4.........Check total Waiting Customers");
            Console.WriteLine("5.........Exit");
            if (!int.TryParse(Console.ReadLine(), out int key))
            {
                throw (new Exception("Input string was not in a correct format."));
            }
            switch (key)
            {
                case 1:
                    AddCustomer(bankCounter, counters);
                    Menu(bankCounter, counters);
                    break;
                case 2:
                    Status(bankCounter, counters);
                    Console.ReadKey();
                    Menu(bankCounter, counters);
                    break;
                case 3:
                    ChangeStatus(bankCounter, counters);
                    Menu(bankCounter, counters);
                    break;
                case 4:
                    WaitingCustomers();
                    Menu(bankCounter, counters);
                    break;
                case 5:
                    System.Environment.Exit(1);
                    break;
                default:
                    Menu(bankCounter, counters);
                    break;
            }
        }

        // Get Total Counters 
        static int EnterTotalCounters()
        {
            Console.WriteLine("Enter Total Number of Counters");
            if (!int.TryParse(Console.ReadLine(), out int counters))
            {
                throw (new Exception("Input string was not in a correct format."));
            }
            return counters;
        }
        static void Main(string[] args)
        {
            int Counters = EnterTotalCounters();
            Counter[] BankCounter = new Counter[Counters];
            for (int index = 0; index < Counters; index++)
            {
                BankCounter[index] = new Counter();
            }
            Menu(BankCounter, Counters);

            Console.ReadKey();
        }
    }
}
