using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
           double Base;
           double Altura;
           double Area;

            Console.Write("1 Coloque o valor da base: ");
          Base = double.Parse( Console.ReadLine());

            Console.Write("2 Coloque o valor de altura: ");
            Altura = double.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine($"A área do triangulo é: {Area = Base * Altura / 2} (cm²)");



            
            


        }
    }
}
