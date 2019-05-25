using System.Runtime.InteropServices;
using System.Text;

namespace NetCoreExample
{
    public static class NativeMethods
    {
        //====================CONSTANTES====================
        const int STRING_MAX_LENGHT = 1024;

        //====================DECLARACION DE LLAMADAS NATIVAS===================================
        [DllImport("EjemploNativo", EntryPoint = "GetStringMessage")]
        public static extern void GetStringMessageNativo(StringBuilder sb, int StringLenght);

        [DllImport("EjemploNativo", EntryPoint = "Suma")]
        public static extern int SumaNativo(int A, int B);

        //Obtenemos el mensaje desde C++
        public static string GetStringMessage()
        {
            //Declaramos el objeto que nos devolvera el mensaje
            StringBuilder sb = new StringBuilder(STRING_MAX_LENGHT);
            //Llamamos a la libreria nativa
            GetStringMessageNativo(sb, STRING_MAX_LENGHT);

            return sb.ToString();
        }
    }
}
