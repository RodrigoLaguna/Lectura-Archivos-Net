using System;

namespace LecturaDeArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string fila;
                int contador = 0;
                string path = @"prueba.txt";

                archivo = new System.IO.StreamReader(path);

                while ( (fila = archivo.ReadLine()) != null )
                {
                    Console.WriteLine(fila);
                    contador++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la lectura del archivo");
            }
            finally
            {
                if ( archivo != null)
                {
                    archivo.Close();
                    Console.WriteLine("Conexión cerrada");
                }
            }
        }
    }
}
