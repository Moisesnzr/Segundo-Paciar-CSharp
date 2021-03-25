using System;

namespace Segundo_Parcial_Ejercicio_1
{
    public class Productos
    {
        struct Datproductos
        {
            public int opcion;
            public string nombre;
            public double precio;
            public int existencia;
        }

        private int opcompra;

        Datproductos[] aProductos = new Datproductos[9];

        public void speproduct()
        {
            aProductos[0].opcion = 0;
            aProductos[0].nombre = "Galleta";
            aProductos[0].precio = 5;
            aProductos[0].existencia = 10;

            aProductos[1].opcion = 1;
            aProductos[1].nombre = "Agua";
            aProductos[1].precio = 10;
            aProductos[1].existencia = 10;

            aProductos[2].opcion = 2;
            aProductos[2].nombre = "Jugo";
            aProductos[2].precio = 50;
            aProductos[2].existencia = 10;

            aProductos[3].opcion = 3;
            aProductos[3].nombre = "Refresco";
            aProductos[3].precio = 15;
            aProductos[3].existencia = 10;

            aProductos[4].opcion = 4;
            aProductos[4].nombre = "Frito Lay";
            aProductos[4].precio = 50;
            aProductos[4].existencia = 10;

            aProductos[5].opcion = 5;
            aProductos[5].nombre = "360 Energy";
            aProductos[5].precio = 100;
            aProductos[5].existencia = 10;

            aProductos[6].opcion = 6;
            aProductos[6].nombre = "Vive100";
            aProductos[6].precio = 100;
            aProductos[6].existencia = 10;

            aProductos[7].opcion = 7;
            aProductos[7].nombre = "Mani";
            aProductos[7].precio = 5;
            aProductos[7].existencia = 10;

            aProductos[8].opcion = 8;
            aProductos[8].nombre = "Hershey's";
            aProductos[8].precio = 50;
            aProductos[8].existencia = 10;

            aProductos[9].opcion = 9;
            aProductos[9].nombre = "Snickers";
            aProductos[9].precio = 50;
            aProductos[9].existencia = 10;
        }

        public void compra()
        {
            Console.WriteLine("0- Galleta");
            Console.WriteLine("1- Agua");
            Console.WriteLine("2- Jugo");
            Console.WriteLine("3- Refresco");
            Console.WriteLine("4- Frito Lay");
            Console.WriteLine("5- 360 Energy");
            Console.WriteLine("6- Vive100");
            Console.WriteLine("7- Mani");
            Console.WriteLine("8- Hershey's");
            Console.WriteLine("9- Snickers");

            Console.Write("Escriba la opcion del producto que desea comprar: ");
            opcompra = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < aProductos.Length; i++)
            {
                if (opcompra == aProductos[i].opcion)
                {
                    Console.WriteLine("Su precio es: $" + aProductos[i].precio);
                    
                    Console.WriteLine("Ingrese su dinero: ");
                    int pago = int.Parse(Console.ReadLine());

                    if (pago == 5 || pago == 10 || pago == 25 || pago == 50 || pago == 100 || pago == 200)
                    {
                        aProductos[i].existencia = aProductos[1].existencia - 1;
                        
                        if (pago < aProductos[i].precio)
                        {
                            Console.WriteLine("Te faltan ", aProductos[i].precio - pago);
                            pago = pago + int.Parse(Console.ReadLine());
                        }
                    } else{
                        Console.WriteLine("Solo se aceptan monedas de 5, 10 y 25");
                        Console.WriteLine("Solo se aceptan billetes de 50, 100 y 200");
                    }
                }
            }
        }

    }
    
    class Maquina : Productos
    {
        private int menu_maq;
        public void menu()
        {
            do
            {
                Console.WriteLine("\n1- Comprar");
                Console.WriteLine("2- Mostrar Informe");
                Console.WriteLine("3- Salir");

                Console.Write("\nEscoja una opcion: ");
                menu_maq = int.Parse(Console.ReadLine());

                switch (menu_maq)
                {
                    case 1 : 
                        compra();
                    break;
                    
                    case 2 : 
                    
                    break;

                    case 3 : 
                        Console.Clear();
                        Console.WriteLine("Finalizando Programa...");
                    break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Caracter ingresado no valido");
                    break;
                }
            } while (menu_maq != 3);
            
        }
        static void Main(string[] args)
        {
            Maquina maq = new Maquina();
            maq.menu();
        }
    }
}
