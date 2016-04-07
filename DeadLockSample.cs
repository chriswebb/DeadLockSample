using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreDumpApplicationTest
{

    public class CoreDumpClient
    {
        private static readonly object lock1 = new object();
        private static readonly object lock2 = new object(); 
        public static void Main(string[] args)
        {

            while (true)
            {
                System.Threading.ThreadPool.QueueUserWorkItem(state =>
                {
                    DeadLock();
                });
            }

        }

        public static void DeadLock()
        {

            lock (lock1)
            {
                lock (lock2)
                {
                    System.Threading.Thread.Sleep(500);
                }
            }

            lock (lock2)
            {
                lock (lock1)
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

    }
}
