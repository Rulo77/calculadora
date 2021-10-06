using System;


namespace calculadora_en_clases
{
    class Cientifica
    {
        public void Sumacuadrada(ref double res)
        {
            res = Math.Pow(res, 2);
        }
        public void Raizresta(ref double res)
        {
            res = Math.Sqrt(res);
        }

        public void Divmuti(ref double res)
        {
            res = res / 2;
        }

    }
}
