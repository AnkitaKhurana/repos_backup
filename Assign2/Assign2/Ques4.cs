using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace Assign2
{
    class Ques4
    {
        string customerSent = "";
        Queue PrivilegedCustomer = new Queue();
        Queue NormalCustomer = new Queue();
        int totalCounters;

        // Add Customer to Waiting queue
        private void addToWait(int priority, string name)
        {
            if (priority == 1)
                PrivilegedCustomer.Enqueue(name);
            else if (priority == 0)
                NormalCustomer.Enqueue(name);
        }

        // Free Counter 
        private void freeCounter(string[] Counters)
        {
            int workDone = 0;

            foreach (string seat in Counters)
            {
                customerSent = "";
                if (seat == "free")
                {
                    if (PrivilegedCustomer.Count > 0)
                    {
                        customerSent = PrivilegedCustomer.Dequeue().ToString();
                    }
                    else if (NormalCustomer.Count > 0)
                    {
                        customerSent = NormalCustomer.Dequeue().ToString();
                    }
                    if (customerSent != "")
                    {
                        Console.WriteLine(customerSent + " please goto counter " + (Array.IndexOf(Counters, seat) + 1));
                        Counters[Array.IndexOf(Counters, seat)] = customerSent;
                        workDone = 1;
                    }
                }
            }
            if (workDone == 0)
            {
                Console.WriteLine("Enter the Index of free Counter");
                int index;
                if (!int.TryParse(Console.ReadLine(), out index))
                {
                    throw (new MyExceptions("Input string was not  in a correct format."));
                }
                if (index - 1 < totalCounters && index - 1 >= 0)
                {
                    Counters[index - 1] = "free";
                }
            }
        }
        
        // Add new customer
        private void addCustomer()
        {
            string name = "";
            int enteredPriority;
            Console.WriteLine("Enter Customer Priority (1:Privileged , 0: Normal)");
            if (!int.TryParse(Console.ReadLine(), out enteredPriority))
            {
                throw (new MyExceptions("Input string was not in a correct format."));
            }
            if (enteredPriority != 1 && enteredPriority != 0)
                throw (new MyExceptions("Invalid Priority."));
            Console.WriteLine("Enter Customer Name");
            name = Console.ReadLine();

            if (name == "")
            {
                throw (new MyExceptions("Name cannot be blank"));
            }
            addToWait(enteredPriority, name);
        }
        // Send Data to main function
        public void SendData()
        {
            Console.WriteLine("Enter Total number of Counters");
            if (!int.TryParse(Console.ReadLine(), out totalCounters))
            {
                throw (new MyExceptions("Input string was not in a correct format."));

            }
            string[] Counters = Enumerable.Repeat("free", totalCounters).ToArray();
            int consoleStatus = 1;
            while (consoleStatus == 1 || consoleStatus == 0)
            {
            l1:
                Console.WriteLine("Press 1 to add Customer, Press 0 to free a Counter/Send Customer to Empty Counters, any other number to exit");
                if (!int.TryParse(Console.ReadLine(), out consoleStatus))
                {
                    throw (new MyExceptions("Input string was not in a correct format."));
                }
                if (consoleStatus == 1)
                {
                    addCustomer();
                    goto l1;
                }
                if (consoleStatus == 0)
                {
                    freeCounter(Counters);
                    goto l1;
                }
            }
        }
    }
}
