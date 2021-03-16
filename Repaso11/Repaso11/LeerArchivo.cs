using System;
using System.IO;

namespace Repaso11
{
    public class LeerArchivo
    {
        public LeerArchivo()
        {
        }

        public static bool esNombre(string palabra)
        {
            palabra += @"\";
            foreach(string linea in File.ReadAllLines("Nombres.txt"))
            {
                if (palabra == linea)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
