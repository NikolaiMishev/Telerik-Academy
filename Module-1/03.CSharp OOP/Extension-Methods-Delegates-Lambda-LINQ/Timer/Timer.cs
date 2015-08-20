namespace Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        static void Main()
        {
            Publisher pub = new Publisher();
            Handler hand = new Handler(pub);

            pub.Start(2, 10);
        }
    }
}
