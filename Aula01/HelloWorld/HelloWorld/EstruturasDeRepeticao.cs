using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class EstruturasDeRepeticao
    {
        static void Main(string[] argumentos)
        {
            foreach (var argumento in argumentos)
            {
                Console.WriteLine($"Argumento lido no foreach: {argumento}");
            }

            for (var loops = 0; loops < argumentos.Length; loops++)
            {
                var argumento = argumentos[loops];
                Console.WriteLine($"Argumento lido no for: {argumento}");
            }

            var loops2 = 0;
            while (loops2 < argumentos.Length)
            {
                var argumento = argumentos[loops2];
                Console.WriteLine($"Argumento lido no while: {argumento}");
                loops2++;
            }

            var loops3 = 0;
            do
            {
                var argumento = argumentos[loops3];
                Console.WriteLine($"Argumento lido no do while: {argumento}");
                loops3++;
            } while (loops3 < argumentos.Length);
            
        }
    }
}
