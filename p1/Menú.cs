public class Menú
{
    public int opcion { get; set; }
    public string? opcion1 { get; set; }   
    public void Menu()
    {
        do
        {
            Console.WriteLine("*****                   Bienvenido a DelCastellano                     *****\n");
            Console.WriteLine("*****                             Menú                                 *****\n");
            Console.WriteLine("1. Clases de Palabras\n2. Funciones Sintácticas\n3. Analizar oraciones\n4. Textos expositivos\n5. Créditos\n");
            Console.WriteLine("Ingrese su elección:");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    CPalabras p1 = new CPalabras();
                    p1.Palabras();
                    break;
                case 2:
                    VyF p2 = new VyF();
                    p2.preguntas();
                    break;
                case 3:
                    AOraciones p3 = new AOraciones();
                    p3.Oraciones();
                    break;
                case 4:
                    TExpositivos p4 = new TExpositivos();
                    p4.Expositivos();
                    break;
                case 5:
                    Console.WriteLine("                   Créditos                     \n");
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**        Ángel Erian Hernández Alemán.         **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("\n");
                    break;
                default:
                    Console.WriteLine("No se ha seleccionado ninguna opción.");
                    break;
            }
            Console.WriteLine("¿Desea regresar al inicio?");
            Console.WriteLine("Si.");
            Console.WriteLine("No");
            opcion1 = Console.ReadLine();
            Console.Clear();
        } while (opcion1 == "Si" || opcion1 == "si");
    }
}

