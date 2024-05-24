
using McDonalds;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int Respuesta;
        do
        {
            Console.WriteLine("Bienvenido a McDonalds\n\nElija una opción\n\n1- Realizar pedido\n0- Salir");

            Respuesta = ExtraerOpcion(Console.ReadLine());

            if (Respuesta == 0)
            {
                Console.Clear();
                Console.WriteLine("Adios");
            }
            else if (Respuesta == 1)
            {
                int RespuestaFinal;

                Console.Clear();
                do
                {                    
                    ArrayList ListaComida = new ArrayList();
                    ListaComida.Add(new Item("Hamburguer", 200));
                    ListaComida.Add(new Item("Cheeseburguer", 250));
                    ListaComida.Add(new Item("Double Hamburguer", 300));
                    ListaComida.Add(new Item("McDouble", 350));
                    ListaComida.Add(new Item("Quarter Pounder", 450));
                    ListaComida.Add(new Item("Big Mac", 550));
                    ListaComida.Add(new Item("McChicken", 300));
                    ListaComida.Add(new Item("Filet-O-Fish", 320));

                    ArrayList ListaBebida = new ArrayList();
                    ListaBebida.Add(new Item("Coca Cola", 100));
                    ListaBebida.Add(new Item("Sprite", 80));
                    ListaBebida.Add(new Item("Fanta", 80));
                   
                    int OpcionComida;             
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Seleccione una de las siguientes opciones de comida\n");
                        ImprimirMenu(ListaComida);
                        OpcionComida = ExtraerOpcion(Console.ReadLine());
                    } while (OpcionComida < 1 || OpcionComida > 8);
                    Item ComidaSeleccionada = (Item) ListaComida[OpcionComida -1];

                    int OpcionBebida;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Seleccione una de las siguientes opciones de bebida\n");
                        ImprimirMenu(ListaBebida);
                        OpcionBebida = ExtraerOpcion(Console.ReadLine());

                    } while (OpcionBebida < 1 || OpcionBebida > 3);
                    Item BebidaSeleccionada = (Item) ListaBebida[OpcionBebida - 1];

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1- Retirar ticket\n2- Volver a pedir menú");
                        RespuestaFinal = ExtraerOpcion(Console.ReadLine());
                    } while (RespuestaFinal != 1 && RespuestaFinal != 2);
                    

                    if (RespuestaFinal == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("-----------Mc Donalds----------");
                        Console.WriteLine("Orden\n");
                        Console.WriteLine(ComidaSeleccionada.Nombre + "   $" + ComidaSeleccionada.Precio);
                        Console.WriteLine(BebidaSeleccionada.Nombre + "   $" + BebidaSeleccionada.Precio);
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Total   $" + (ComidaSeleccionada.Precio + BebidaSeleccionada.Precio));
                        Console.WriteLine("\n\n¡Vuelva pronto esperamos que disfrute de su comida en McDonalds!");
                    }
                    else
                    {
                        Console.Clear();
                    }
                } while (RespuestaFinal == 2);
            }
            else
            {
                Console.Clear();
            }            
        } while (Respuesta != 0 && Respuesta != 1);    
    }

    public static int ExtraerOpcion(string Respuesta)
    {
        if (Respuesta.Equals("")) return -1;

        int respuestaNumerica;
        if (!int.TryParse(Respuesta, out respuestaNumerica)) return -1; 
        
        return respuestaNumerica;
    }

    public static void ImprimirMenu(ArrayList Menu)
    {
        int opcion = 1;
        foreach (Item item in Menu)
        {
            Console.WriteLine(opcion++ + "- " + item.Nombre + "  $" + item.Precio);
        }
    }
}