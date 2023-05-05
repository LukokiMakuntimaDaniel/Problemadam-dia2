using System;

namespace Problemadamédia2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            float soma = 0;
            int qtd = n;
            for (int cont=1;cont<=n; cont++)
            {
                int valor= Convert.ToInt32(Console.ReadLine());
                if(valor>= -1000 && valor <= 1000)
                {
                    soma =soma+ valor;
                }
                else
                {
                    qtd--;
                }
            }
            Console.WriteLine((soma / qtd).ToString("N1"));
        }
    }
}
