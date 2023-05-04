using System.Collections;
public class CPalabras
{
    public int respuesta1 { get; set; }
    public ArrayList palabras = new ArrayList() {"- Los ________ son las clases de palabras que dan nombres o identifican a todas las cosas que conocemos.\n",
    "- El Artículo es la parte de la ______, se antepone al sustantivo para determinarlo y especificarlo.\n",
    "- El________ es una parte de la oración que complementa un sustantivo para calificarlo.\n"};
    public void Palabras()
    {
        Console.WriteLine("*****                   Completa el enunciado.                     *****\n");
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine(palabras[0]);
            Console.WriteLine("1) Sustantivo.");/*Respuesta correcta*/
            Console.WriteLine("2) Adjetivos.");
            Console.WriteLine("3) Pronombres.\n");
            Console.WriteLine("Ingrese su elección:");
            respuesta1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta1 == 1)
            {
                Console.WriteLine("El enunciado está correcto.\n");
                Console.WriteLine("Ejemplo de sustantivo: Zapato: Me hiede el zapato.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: Los sustantivos son las clases de palabras que dan nombres o identifican a todas las cosas que conocemos.\n");
                Console.WriteLine("Ejemplo de sustantivo: Zapato: Me hiede el zapato.\n");
            }

            Console.WriteLine("Presione space para continuar.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(1500);

            Console.WriteLine(palabras[1]);
            Console.WriteLine("1) Oración.");/*Respuesta correcta*/
            Console.WriteLine("2) Párrafo.");
            Console.WriteLine("3) Palabras.\n");
            Console.WriteLine("Ingrese su elección:");
            respuesta1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n"); 

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta1 == 1)
            {
                Console.WriteLine("El enunciado está correcto.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: El Artículo es la parte de la oración, se antepone al sustantivo para determinarlo y especificarlo.\n");
            }

            Console.WriteLine("Presione space para continuar.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(1500);

            Console.WriteLine(palabras[2]);
            Console.WriteLine("1) Sustantivo.");
            Console.WriteLine("2) Oración.");
            Console.WriteLine("3) Adjetivo.\n");/*Respuesta correcta*/
            Console.WriteLine("Ingrese su elección:");
            respuesta1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta1 == 3)
            {
                Console.WriteLine("El enunciado está correcto.\n");
                Console.WriteLine("Ejemplo: Bajita: La Fátima es bien bajita.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: El adjetivo es una parte de la oración que complementa un sustantivo para calificarlo.");
                Console.WriteLine("Ejemplo: Bajita: La Fátima es bien bajita○\n");
            }
        }
    }
}