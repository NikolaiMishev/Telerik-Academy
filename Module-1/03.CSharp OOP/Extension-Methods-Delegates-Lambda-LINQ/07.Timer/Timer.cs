namespace _07.Timer
{
    using System;
    using System.Threading;

    public delegate void RepeatDelegate(int t);

    class Timer
    {
        static void Main()
        {
            RepeatDelegate t = delegate(int time)
            {
                while (true)
                {
                    Thread.Sleep(time);
                    Console.WriteLine("1 sec passed, now it's: {0:T}", DateTime.Now);
                }
            };
            t(30);
        }
    }
}
