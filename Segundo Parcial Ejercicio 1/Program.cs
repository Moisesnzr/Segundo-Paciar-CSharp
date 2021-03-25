using System;

namespace Segundo_Parcial_Ejercicio_1
{
class producto
{
    public string nombre { get; set; }
    public int precio { get; set; }
    public int existencia { get; set; }
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            producto producto1 = new producto();
            producto1.nombre = "Galletas";
            producto1.precio = 5;
            producto1.existencia = 10;

            producto producto2 = new producto();
            producto2.nombre = "Frito Lay";
            producto2.precio = 25;
            producto2.existencia = 10;

            producto producto3 = new producto();
            producto3.nombre = "Hershey's";
            producto3.precio = 50;
            producto3.existencia = 10;

            producto producto4 = new producto();
            producto4.nombre = "Agua";
            producto4.precio = 10;
            producto4.existencia = 10;

            producto producto5 = new producto();
            producto5.nombre = "Jugo";
            producto5.precio = 50;
            producto5.existencia = 10;

            producto producto6 = new producto();
            producto6.nombre = "Refresco";
            producto6.precio = 15;
            producto6.existencia = 10;

            producto producto7 = new producto();
            producto7.nombre = "Snickers";
            producto7.precio = 50;
            producto7.existencia = 10;

            producto producto8 = new producto();
            producto8.nombre = "Many";
            producto8.precio = 50;
            producto8.existencia = 10;

            producto producto9 = new producto();
            producto9.nombre = "Vive100";
            producto9.precio = 100;
            producto9.existencia = 10;

            producto producto10 = new producto();
            producto10.nombre = "Energy 360";
            producto10.precio = 100;
            producto10.existencia = 10;
    
        
        int dinero, menu,devuelta,Ganancia = 0;
        int ventagalleta = 0, ventaFritoLay = 0,ventasHershey = 0,ventagua = 0,ventejugo = 0,ventarefresco = 0,
        ventaSnickers = 0, ventaMany = 0, ventaVive100 = 0, ventareEnergy = 0;
        
        do
        {
            Console.WriteLine("\n------ Maquina Dispensadora de Alimentos ------");   
            Console.WriteLine("Solo aceptamos monedas de 5,10,25 y billetes de 50, 100 y 200 pesos");
            Console.Write("\nIntroduzca dinero: ");
            dinero = int.Parse(Console.ReadLine());
       

            if (dinero == 5 || dinero == 10 || dinero == 25 || dinero == 50 || dinero== 100|| dinero == 200)
            {
            Console.WriteLine("\nUsted introdijo $" + dinero );
            Console.WriteLine("Que comprará ?\n");
            Console.WriteLine("1- Galletas = ${0}" , producto1.precio  );
            Console.WriteLine("2- Frito Lay = ${0}", producto2.precio);
            Console.WriteLine("3- Hershey's = ${0}", producto3.precio);
            Console.WriteLine("4- Agua = ${0}", producto4.precio);
            Console.WriteLine("5- Jugo = ${0}", producto5.precio);
            Console.WriteLine("6- Refresco = ${0}", producto6.precio);
            Console.WriteLine("7- Snickers = ${0}", producto7.precio);
            Console.WriteLine("8- Many = ${0}", producto8.precio);
            Console.WriteLine("9- Vive100 = ${0}", producto9.precio);
            Console.WriteLine("10- Energy 360 = ${0}", producto10.precio);
            Console.WriteLine("11- Registro de venta y Salir");
            Console.Write("\nEscriba el # producto que quiere: ");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                if (dinero >= producto1.precio)
                {
                Console.WriteLine("Entregando tu " + producto1.nombre);
                devuelta = dinero - producto1.precio;
                Ganancia += producto1.precio;
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto1.existencia -= 1;
                ventagalleta += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        

                break;
                case 2:
                if (dinero >= producto2.precio)
                {
                Console.WriteLine("Entregando tu " + producto2.nombre);
                devuelta = dinero - producto2.precio;
                Ganancia += producto2.precio;
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto2.existencia -= 1;
                ventaFritoLay += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        
                break;
                case 3:
                if (dinero >= producto3.precio)
                {
                Console.WriteLine("Entregando tu " + producto3.nombre);
                devuelta = dinero - producto3.precio;
                Ganancia += producto3.precio;
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto3.existencia -= 1;
                ventasHershey += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        
                break;
                case 4:
                if (dinero >= producto4.precio)
                {
                Console.WriteLine("Entregando tu " + producto4.nombre);
                devuelta = dinero - producto4.precio;
                Ganancia += producto4.precio;
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto4.existencia -= 1;
                ventagua += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        
                break;
                case 5:
                if (dinero >= producto5.precio)
                {
                Console.WriteLine("Entregando tu " + producto5.nombre);
                devuelta = dinero - producto5.precio;
                Ganancia += producto5.precio;
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto5.existencia -= 1;
                ventejugo += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        
                break;
                case 6:
                if (dinero >= producto6.precio)
                {
                Console.WriteLine("Entregando tu " + producto6.nombre);
                devuelta = dinero - producto6.precio;
                Ganancia += producto6.precio; 
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto6.existencia -= 1;
                ventarefresco += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        
                break;
                case 7:
                if (dinero >= producto7.precio)
                {
                Console.WriteLine("Entregando tu " + producto7.nombre);
                devuelta = dinero - producto7.precio;
                Ganancia += producto7.precio; 
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto7.existencia -= 1;
                ventaSnickers += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        
                break;
                case 8:
                if (dinero >= producto8.precio)
                {
                Console.WriteLine("Entregando tu " + producto8.nombre);
                devuelta = dinero - producto8.precio;
                Ganancia += producto8.precio; 
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto8.existencia -= 1;
                ventaMany += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        
                break;
                case 9:
                if (dinero >= producto9.precio)
                {
                Console.WriteLine("Entregando tu " + producto9.nombre);
                devuelta = dinero - producto9.precio;
                Ganancia += producto9.precio; 
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto9.existencia -= 1;
                ventaVive100 += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        
                break;
                case 10:
                if (dinero >= producto10.precio)
                {
                Console.WriteLine("Entregando tu " + producto10.nombre);
                devuelta = dinero - producto10.precio;
                Ganancia += producto10.precio; 
                Console.WriteLine("Su devuelta es: " + devuelta);
                producto10.existencia -= 1;
                ventareEnergy += 1;
                Console.WriteLine("Gracias por si compra!!\n");
                }
                else
                {
                    Console.WriteLine("El dinero no le alcanza para comprar este producto");
                }
        
                break;
                case 11:
                Console.Clear();
                Console.WriteLine("En el dia se vendieron " + ventagalleta +"Galletas, "+ ventaFritoLay + "Frito Lay, " + ventasHershey
                + " Hershey, " + ventagua + " Agua, "+ ventejugo + "Jugos, " + ventarefresco+ "Refresco, " + ventaSnickers 
                + "Snickers, " + ventaMany + "ventaMany, " + ventaVive100 + "Vive100, " + ventareEnergy + "Energy 360");
                Console.WriteLine(" Y " + Ganancia+ " pesos de ganancias");
                Console.WriteLine("Programa Finalizado");
                break;
            }
            } else
            {
                Console.WriteLine("No hacectamos esa cantidad de dinero");
            }
        } while(true);
        }
    }
}