using System;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            //area = π . raio2
            //(4 / 3.0) * pi * R3.
            double area, raio1,volume;
            double P = 3.14159;
            float raio = float.Parse(Console.ReadLine());

            raio1 = double.Parse(raio.ToString("#0.00"));

            volume = (4 / 3.0) * P * (raio * raio * raio);

            //area = P * (raio1 * raio1);

            Console.WriteLine("VOLUME = " + volume.ToString("#0.000"));

        }
    }
}
