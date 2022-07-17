using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            if(10 > 5){
                Console.WriteLine("Es mayor");
            }else {
                Console.WriteLine("No es mayor");
            }

            //* AND (&&), OR( || ), NOT ( ! )
            int edad = 20;
            char inicial = 'A';

            if (edad > 20 && inicial == 'A'){
                Console.WriteLine("Es mayor de edad y su inicial es A");
            }

            if (edad > 20 || inicial == 'A'){
                Console.WriteLine("Es mayor de edad o su inicial es A");
            }

            //*Ejemplo con OR y AND usando paréntesis
            if ((inicial == 'H'|| inicial == 'B') && edad > 20){
                Console.WriteLine("Fin programa");
            }

        }
    }
}
