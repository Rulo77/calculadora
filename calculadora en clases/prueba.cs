using System;


namespace calculadora_en_clases
{
    class Prueba
    {
        double n1, n2, res;
        Cientifica C;
        Basica B;
        
        public Prueba()
        {
            Console.WriteLine("introduce los dos numeros");
            Console.WriteLine("introduce el primer número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("introduce el segundo número:");
            n2 = double.Parse(Console.ReadLine());
            Menu();

        }

        private void Menu()
        {
            int opc;
            B = new Basica();
            C = new Cientifica();
            Console.WriteLine("selecciona una opción");
            Console.WriteLine("1.- sumar");
            Console.WriteLine("2.- restar");
            Console.WriteLine("3.- multiplicar");
            Console.WriteLine("4.- dividir");
            Console.WriteLine("5.- elevar al cuadrado la suma de dos numeros");
            Console.WriteLine("6.- raiz de la resta de dos numeros");
            Console.WriteLine("7.- dividir la multiplicacion de dos numeros");
            opc = int.Parse(Console.ReadLine());

            switch(opc)
            {
                case 1:
                    B.Sumar(n1,n2,ref res);
                    break;

                case 2:
                    B.Restar(n1, n2, ref res);
                    break;

                case 3:
                    B.Multiplicar(n1, n2, ref res);
                    break;

                case 4:
                    B.Dividir(n1, n2, ref res);
                    break;

                case 5:
                    B.Sumar(n1, n2, ref res);
                    C.Sumacuadrada(ref res);
                    break;


                case 6:
                    B.Restar(n1, n2, ref res);
                    C.Raizresta(ref res);
                    break;

                case 7:
                    B.Multiplicar(n1, n2, ref res);
                    C.Divmuti(ref res);
                    break;


                default:
                    Console.WriteLine("opcion incorrecta");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
          

            }

            Imprimir();
            
            
        }

        private void Imprimir()
        {
            Console.WriteLine("el resultado de la operacion es: " + res);
        }

    }
}
