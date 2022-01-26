using System;

namespace Transport
{
    public class Car : BasicTransport
    {
        override public void Move()
        {
            Console.WriteLine($"машина");
        }
    }
}
