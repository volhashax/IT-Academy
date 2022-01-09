using System;

namespace Transport
{
    public class Human
    {
        private BasicTransport _transportType;

        public void SetTransport(BasicTransport transport)
        {
            _transportType = transport;
        }

        public void TransportInfo()
        {
            Console.Write($"Тип транспорта - ");
            _transportType.Move();
        }
    }
}
