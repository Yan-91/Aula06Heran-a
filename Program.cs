using System;

namespace POO
{
    class Program
   {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Yan";
            Console.WriteLine( cpf.Saudar() );

            cpf.cpf = "894.456.887-79";
            Console.WriteLine( cpf.ValidarCPF() );
        }
    }
}
