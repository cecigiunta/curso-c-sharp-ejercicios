using System;

namespace ej_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //* SWITCH: Le pasas una variable y la evalúa en CASOS
            char letra = 'A';
            switch (letra){
                case 'A':
                    Console.WriteLine("Es A");
                    break;
                case 'B':
                    Console.WriteLine("Es B");
                    break;
                default:
                    Console.WriteLine("No es A ni B");
                    break;
        }
    }
}
