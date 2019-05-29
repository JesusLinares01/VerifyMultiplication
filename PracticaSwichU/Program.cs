using System;

namespace PracticaSwichU
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamo a la clase Random
            Random number = new Random();

            //Definir mis variables
            int ramdonNumero1 = number.Next(1, 24);
            int ramdonNumero2 = number.Next(1, 24);

            Console.WriteLine("Cuanto es {0} multiplicado por {1}?", ramdonNumero1, ramdonNumero2);
            var result = Convert.ToInt32(Console.ReadLine());
            if (result == ramdonNumero1 * ramdonNumero2)
            {
                Console.WriteLine("Tu respuesta es correcta.");
            }
            else
            {
                int diferencia = Math.Abs(result - (ramdonNumero1 * ramdonNumero2));
                if (diferencia == 1) {
                    Console.WriteLine("Estuvistes cerca");
                }
                else if (diferencia <= 10) {
                        Console.WriteLine("Puedes hace algo mejor");
                }
                else {
                    Console.WriteLine("Demasiado lejos vuelve a intentarlo...");
                }
                //int seleccion = number.Next(1, 4);
                //switch (seleccion)
                //{
                //    case 1:
                //        Console.WriteLine("tu puedes hacer algo mas que eso...");
                //        break;
                //    case 2: 
                //        Console.WriteLine("Tu respuesta ha sido incorrecta.");
                //        break;
                //    default: 
                //        Console.WriteLine("intentalo de nuevo.");
                //        break;
                //}
            }
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
