using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Class1
    {

        static void Main(string[] args)
        {
            var isRunning = true;
            var isPaused = true;

            while (true)
            {
                if (isRunning == false) break;

                while (isPaused)
                {
                    Thread.Sleep(0);

                }

                Play();

                Thread.Sleep(0);
            }
        }

        private static void Play()
        {

        }
    }
}
