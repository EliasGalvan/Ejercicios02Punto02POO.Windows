using Ejercicios02Punto02POO.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios02Punto02EliasGalvan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informar el área y el volumen de un cono conociendo la generatriz, la
            //altura y el radio de giro.
            try
            {
                

                Console.WriteLine("Ingrese la generatriz del cono:");
                var generatriz = double.Parse(Console.ReadLine());
                if (generatriz > 0)
                {
                    Console.WriteLine("Ingrese la altura del cono:");
                    var altura = double.Parse(Console.ReadLine());
                    if (altura > 0)
                    {
                        Console.WriteLine("Ingrese el radio de giro del cono:");
                        var radio = double.Parse(Console.ReadLine());
                        if (radio > 0)
                        {
                            Cono cono = new Cono();
                            cono.Altura = altura;
                            cono.Generatriz = generatriz;
                            cono.Radio = radio;
                            Console.WriteLine($"El área del cono es: {cono.GetArea()}");
                            Console.WriteLine($"El volumen del cono es: {cono.GetVolumen()}");
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar un valor mayor a cero");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un valor mayor a cero");
                    }

                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor mayor a cero");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe ingresar un valor numerico");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Valor numerico demaciado grande");
            }
            Console.ReadLine();
        }
    }
}
