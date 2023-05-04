using System.Collections;
class VyF
{
    public string? respuesta { get; set; }
    public ArrayList Preguntas = new ArrayList() {"- El sujeto es la función que desempeña un sintagma nominal a propósito de cuál se dice algo (afirmando, negando, preguntando, etc.).\n",
    "- En la oración no se realiza una acción, es decir que no lleva un verbo.\n",
    "- Las oraciones compuestas llevan solo un verbo impersonal, un predicado.\n"};
    public void preguntas()
    {
        Console.WriteLine("*****                   Responde en enunciado, si crees que es verdadero o falso.                     *****\n");
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine(Preguntas[0]);
            Console.WriteLine("V) Verdadero");/*Respuesta correcta*/
            Console.WriteLine("F) Falso\n");
            Console.WriteLine("Ingrese su elección:");
            respuesta=Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta == "V" || respuesta == "v")
            {
                Console.WriteLine("El enunciado está correcto.\n");
                Console.WriteLine("Ejemplo: Pollito: El pollito corrió por el cauce.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: Verdadero.\n");
                Console.WriteLine("Ejemplo: Pollito: El pollito corrió por el cauce.\n");
            }

            Console.WriteLine("Presione space para continuar.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(1500);

            Console.WriteLine(Preguntas[1]);
            Console.WriteLine("V) Verdadero");
            Console.WriteLine("F) Falso\n");/*Respuesta correcta*/
            Console.WriteLine("Ingrese su elección:");
            respuesta=Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta == "F" || respuesta == "f")
            {
                Console.WriteLine("El enunciado está correcto.\n");
                Console.WriteLine("Ejemplo: Tiró: Andrés Castro tiró una piedra.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: Falso.\n");
                Console.WriteLine("Ejemplo: Tiró: Andrés Castro tiró una piedra.\n");
            }

            Console.WriteLine("Presione space para continuar.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(1500);

            Console.WriteLine(Preguntas[2]);
            Console.WriteLine("V) Verdadero");
            Console.WriteLine("F) Falso\n");/*Respuesta correcta*/
            Console.WriteLine("Ingrese su elección:");
            respuesta=Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta == "F" || respuesta == "f")
            {
                Console.WriteLine("El enunciado está correcto.\n");
                Console.WriteLine("Ejemplo: María - José, miró - tirar:");
                Console.WriteLine("María miro a José tirar un pedo\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: Falso.\n");
                Console.WriteLine("Ejemplo: María - José, miró - tirar:");
                Console.WriteLine("María miro a José tirar un pedo\n");
            }
        }
    }
}
