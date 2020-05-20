using Microsoft.Win32.SafeHandles;
using System;

namespace Cadastro_basico
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome; //String = letras e caracteres
           // String sobrenome; 
            double idade; //Usado para numeros. (Lembrar de estudar mais o double)

            Console.WriteLine("Qual o seu nome ?");
            nome = Console.ReadLine();

            //Console.WriteLine("E o seu sobrenome ?");
            //sobrenome = Console.ReadLine();

            Console.WriteLine("E a sua idade ?");
            idade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Olá Senhor "+nome);

            if (idade >= 18)
            {
                Console.WriteLine("Maioridade confirmada");
            }

            if (idade <= 17)
            {
                Console.WriteLine("Ainda de menor");
            }


            Console.ReadKey();
        }
    }
}
