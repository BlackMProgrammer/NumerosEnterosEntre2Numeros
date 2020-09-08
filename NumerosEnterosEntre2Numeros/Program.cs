using System;

namespace NumerosEnterosEntre2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el Primer numero");
            string numero1val = Console.ReadLine();
            int numero1 = Convert.ToInt32(numero1val);

            Console.WriteLine("Digite el segundo numero");
            string numero2val = Console.ReadLine();
            int numero2 = Convert.ToInt32(numero2val);

            do
            {
                Console.WriteLine("{0}", numero1++);
            } while (numero1 < numero2);
        }
    }
}
