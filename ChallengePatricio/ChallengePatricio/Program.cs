using ChallengePatricio.Aplicaciones;
using ChallengePatricio.Clases;
using ChallengePatricio.Recursos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChallengePatricio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion4;

            do
            {
                Console.WriteLine("Select the language number you want: ");
                Console.WriteLine("1- Spanish\n" +
                                  "2- English\n" +
                                  "3- Portugues\n" +
                                  "5- EXIT");

                opcion4 = Convert.ToInt32(Console.ReadLine());

                switch (opcion4)
                {
                    case 1:
                        AppCastellano appCastellano = new AppCastellano();
                        appCastellano.MostrarAppEnCastellano();
                        break;

                    case 2:
                        AppEnIngles appEnIngles = new AppEnIngles();
                        appEnIngles.MostrarAppEnIngles();
                        break;

                    case 3:
                        AppEnPortugues appEnPortugues = new AppEnPortugues();
                        appEnPortugues.MostrarAppEnPortugues();
                        break;

                    case 5:
                        opcion4 = 5;
                        break;

                    default:
                        Console.WriteLine("Intentelo de nuevo / Try Again\n");
                        break;
                }

            } while (opcion4 != 5);

            Console.WriteLine("BYEE !!!");
            Console.ReadKey();
        }
    }
}
