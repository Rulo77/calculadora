using System;


namespace calculadora_en_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Prueba p;
            int opc;
            do
            {
                p = new Prueba();
                Console.WriteLine("presiona enter para continuar......");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("deseas volver a entrar al programa? 1.- si, 2.- no");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (opc!=2);
            Console.WriteLine("saliendo......");
            Console.ReadKey();

        }
    }
}
