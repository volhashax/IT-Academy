using System;

namespace Transport
{
    public class Boat : BasicTransport
    {
        override public void Move()
        {
            Console.WriteLine($"лодка");
        }
    }
}
