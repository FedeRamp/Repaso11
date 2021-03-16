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
                Console.WriteLine("Ingresar edad, nombre y apellido (en cualquier orden)");
                ingreso = Console.ReadLine();
                if (ingreso == "") Console.WriteLine("Algo, no vacio");
            } while (ingreso == "");

            string[] palabras = ingreso.Split(' ');
            int indexEdad = -1;
            int indexNombre = -1;
            int indexApellido = -1;
            if (palabras.Length == 3)
            {
                for(int i = 0; i < 2; i++)
                {
                    if(int.TryParse(palabras[i], out int x))
                    {
                        indexEdad = i;
                        break;
                    }
                }
                if (indexEdad == -1)
                {
                    Console.WriteLine("No se encontro una edad");
                } else
                {
                    for(int i = 0; i < 2; i++)
                    {
                        if (i != indexEdad && LeerArchivo.esNombre(palabras[i]))
                        {
                            indexNombre = i;
                            break;
                        }
                    }
                    if (indexNombre == -1)
                    {
                        Console.WriteLine("No se encontro un nombre");
                    } else
                    {
                        for(int i = 0; i < 3; i++)
                        {
                            if(i != indexEdad && i != indexNombre)
                            {
                                indexApellido = i;
                            }
                        }
                        Console.WriteLine("Tu nombre es: " + palabras[indexNombre]);
                        Console.WriteLine("Tu apellido es: " + palabras[indexApellido]);
                        Console.WriteLine("Tu edad es: " + palabras[indexEdad]);
                    }
                }
                
            } else
            {
                Console.WriteLine("Solo 3 palabras, por favor");
            }

            
        }
    }
}
