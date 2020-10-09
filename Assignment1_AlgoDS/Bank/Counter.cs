using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    // Counter status
    enum AssignedStatus
    {
        vacant = 0,
        occupied = 1
    }

    // Counter Class
    class Counter
    {
        public Customer AssignedTo;
        public AssignedStatus Status;
        public Counter()
        {
            AssignedTo = null;
            Status = AssignedStatus.vacant;
        }
    }
}
