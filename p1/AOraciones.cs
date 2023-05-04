using System.Collections;
public class AOraciones
{
    public int respuesta3 { get; set; }
    public ArrayList oraciones = new ArrayList() {"- Luis fue elogiado por el profesor en el aula.\n",
    "- Por este camino llegué antes a casa.\n",
    "- Tienes razón, te haremos caso.\n"};
    public void Oraciones()
    {
        Console.WriteLine("*****                   Analice las siguientes oraciones, y seleccione si son simples o compuestas.                     *****\n");
        for (var i = 0; i < 1; i++)
        {
            Console.WriteLine(oraciones[0]);
            Console.WriteLine("1) Oración simple.");/*Respuesta correcta*/
            Console.WriteLine("2 Oración compuesta.\n");
            Console.WriteLine("Ingrese su elección:");
            respuesta3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta3 == 1)
            {
                Console.WriteLine("El enunciado está correcto.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: Oración simple.\n");
            }

            Console.WriteLine("Presione space para continuar.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(1500);

            Console.WriteLine(oraciones[1]);
            Console.WriteLine("1) Oración simple.");
            Console.WriteLine("2) Oración compuesta.\n");/*Respuesta correcta*/
            Console.WriteLine("Ingrese su elección:");
            respuesta3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta3 == 1)
            {

                
                Console.WriteLine("El enunciado está correcto.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: Oración compuesta.\n");
            }

            Console.WriteLine("Presione space para continuar.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(1500);

            Console.WriteLine(oraciones[2]);
            Console.WriteLine("1) Oración simple.");
            Console.WriteLine("2) Oración compuesta.\n");/*Respuesta correcta*/
            Console.WriteLine("Ingrese su elección:");
            respuesta3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta3 == 1)
            {
                Console.WriteLine("El enunciado está correcto.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: Oración compuesta.\n");
            }
        }
    }
}