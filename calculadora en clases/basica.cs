

namespace calculadora_en_clases
{
    class Basica
    {
        public void Sumar(double x,double y,ref double r)
        {
            r = x + y;
        }

        public void Restar(double x, double y, ref double r)
        {
            r = x - y;
        }

        public void Multiplicar(double x, double y, ref double r)
        {
            r = x * y;
        }

        public void Dividir(double x, double y, ref double r)
        {
            r = x / y;
        }
    }
}
