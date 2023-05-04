public class TExpositivos
{
    public string? respuesta2 { get; set; }  
    public void Expositivos()
    {
        Console.WriteLine("*****                   Relacione la columna de la izquierda con una de la derecha.                     *****\n");
        for (var i = 0; i < 1; i++)
        {
            Console.WriteLine("                                a) Es aquel que transmite conocimientos sobre un tema");
            Console.WriteLine("                                   determinado de forma objetiva y ordenada.");
            Console.WriteLine("\n");
            Console.WriteLine("                                b) Es el texto propio de este género literario y que");
            Console.WriteLine("El texto expositivo:               se caracteriza por ser un tipo de escrito que está");
            Console.WriteLine("                                   pensado para ser representado.");
            Console.WriteLine("\n");
            Console.WriteLine("                                c) Se denomina todo aquel texto en el que se reconocen");
            Console.WriteLine("                                   las características propias de algún género literario.\n");
            Console.WriteLine("Ingrese su elección:");
            respuesta2 = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta2?.ToUpper() == "A")
            {
                Console.WriteLine("El enunciado está correcto.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: Es aquel que transmite conocimientos sobre un tema determinado de forma objetiva y ordenada.\n");
            }

            Console.WriteLine("Presione space para continuar.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(1500);

            Console.WriteLine("                                  a) No posee un objetivo específico, aunque el autor puede");
            Console.WriteLine("                                     atener una intención determinada.");
            Console.WriteLine("\n");
            Console.WriteLine("Unas de las principales           b) Agotar los rasgos o características de aquello que se");
            Console.WriteLine("aracterísticas son:                  explica o se expone.");
            Console.WriteLine("\n");
            Console.WriteLine("                                  c) No refleja sus sentimientos ni da su opinión, sino");
            Console.WriteLine("                                     que aporta datos e información veraz y contrastada,");
            Console.WriteLine("                                     es decir, que se puede comprobar.\n");
            Console.WriteLine("Ingrese su elección:");
            respuesta2 = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);

            if (respuesta2?.ToUpper() == "C")
            {
                Console.WriteLine("El enunciado está correcto.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: No refleja sus sentimientos ni da su opinión, sino que aporta datos e información veraz y contrastada, es decir, que se puede comprobar.\n");
            }

            Console.WriteLine("Presione space para continuar.");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(1500);

            Console.WriteLine("                                  a) Dan sustento a la tesis formulada por el autor mediante");
            Console.WriteLine("                                     la exposición coherente y lógica de justificaciones o ");
            Console.WriteLine("                                     razones, que tienen como propósito persuadir o convencer");
            Console.WriteLine("                                     al lector sobre un punto de vista predeterminado.");
            Console.WriteLine("\n");
            Console.WriteLine("                                  b) Transmiten información, pero no se limita simplemente a ");
            Console.WriteLine("Los textos expositivos               proporcionar datos, sino que además agrega explicaciones,");
            Console.WriteLine("son importantes porque:              describe con ejemplos y analogías.");
            Console.WriteLine("\n");
            Console.WriteLine("                                  c) Es la forma poética que expresa los sentimientos,");
            Console.WriteLine("                                     la imaginación y los pensamientos del autor.\n");
            Console.WriteLine("Ingrese su elección:");
            respuesta2 = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Presione space para confirmar respuesta.\n");
            Console.ReadKey(true);
            Thread.Sleep(1500);

            if (respuesta2?.ToUpper() == "C")
            {
                Console.WriteLine("El enunciado está correcto.\n");
            }
            else
            {
                Console.WriteLine("¡Fallaste! La respuesta correcta es: Es la forma poética que expresa los sentimientos, la imaginación y los pensamientos del autor.\n");
            }
        }
    }
}