using System;

namespace Segundo_Parcial
{
    class Empleados
    {
        string[] empleados;
        float[] salarios;

        public void Cargar()
        {
            empleados = new String[6];
            salarios = new float[6];

            Console.WriteLine("\n----------- Registro Empleados -----------");

            for (int i = 1; i < empleados.Length; i++)
            {
                Console.Write("\nEscriba el nombre del empleado {0}: ", i);
                empleados[i] = Console.ReadLine();
                Console.Write("Escriba el salario del empleado {0}: ", i);
                salarios[i] = float.Parse(Console.ReadLine());
            }
        }

        public void SalarioMayor()
        {
            float Slmayor = salarios[0];
            int namempl = 0;

            for (int e = 0; e < salarios.Length; e++)
            {
                if (salarios[e] > Slmayor)
                {
                    Slmayor = salarios[e];
                    namempl = e;
                }
            }
            
            Console.WriteLine("\n----------- Empleado Sueldo Mayor -----------");
            Console.WriteLine("\nEl empleado con salario mayor es {0}", empleados[namempl]);
            Console.WriteLine("Tiene un salario de: "+ Slmayor + "\n");
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Empleados emp1 = new Empleados();
            emp1.Cargar();
            emp1.SalarioMayor();
        }
    }
}
