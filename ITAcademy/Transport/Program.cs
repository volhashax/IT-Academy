namespace Transport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();

            human.SetTransport(new Boat());

            human.TransportInfo();
        }
    }
}
