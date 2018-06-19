using System;

namespace Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            var noLock = new NoLocking();
            noLock.RunMe();
        }
    }
}
