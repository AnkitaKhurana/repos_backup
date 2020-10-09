namespace Bank
{
    class Customer
    {
        // Customer Members
        string Name;
        int Priority1;
        public int Priority2;

        // Constructor for Customer class
        public Customer(string name, int priority)
        {
            this.Name = name;
            this.Priority1 = priority;
            this.Priority2 = 0;
        }

        // Returns Customer Priority 
        public int GetPriority()
        {
            return Priority1;
        }

        // Returns Customer Name
        public string GetName()
        {
            return Name;
        }

    }
}
