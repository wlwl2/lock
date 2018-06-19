using System;
using System.Threading;

namespace Lock
{
    // A simple use of threads without locking in C#.
    public class NoLocking
    {
        // Constructor.
        // public NoLocking()
        // {
        // }

        public void NoLockingExample()
        {
            Thread t = new Thread(RunMe);
            t.Start();
        }

        public void RunMe() {
            Console.WriteLine("RunMe called");
        }
    }
}
