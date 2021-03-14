using System;

namespace Repaso11
{
    class MainClass
    {
        //Identificar nombre, apellido, edad
        public static void Main(string[] args)
        {
            string ingreso = "";
            do
            {
                Console.WriteLine("Ingresar una palabra");
                ingreso = Console.ReadLine();
                if (ingreso == "") Console.WriteLine("Algo, no vacío");
            } while (ingreso == "");

            string[] palabras = ingreso.Split(' ');
            int indexEdad = -1;
            int indexNombre = -1;
            int indexApellido = -1;
            if (palabras.Length == 3)
            {
                for(int i = 0; i < 3; i++)
                {
                    if(int.TryParse(palabras[i], out int x))
                    {
                        indexEdad = i;
                        break;
                    }
                }
                if (indexEdad == -1) Console.WriteLine("No se encontró una edad");
                for  
            } else
            {
                Console.WriteLine("La próxima ingresar 3 palabras por favor");
            }

        }
    }
}
