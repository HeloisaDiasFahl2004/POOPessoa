using System;

namespace POOPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando 3 objetos
            int i = 0;
            int[] vet = new int[3];
            
            
            for (i = 0; i < vet.Length; i++)
            {
                PessoaSimples pessoa = new PessoaSimples();
                Console.WriteLine("\nInforme os seguintes dados ");
                Console.Write("Nome: ");
                pessoa.setNome(Console.ReadLine());

                Console.Write("Data de nascimento: ");
                pessoa.setDataNascimento(Console.ReadLine());

                Console.Write("CPF: ");
                pessoa.setCPF(long.Parse(Console.ReadLine()));

                Console.Write("Telefone: ");
                pessoa.setTelefone(long.Parse(Console.ReadLine()));

                Console.WriteLine();
                Console.Write(pessoa.ToString());

                Console.ReadKey();
                Console.Clear();
              
            }
            
        }
    }
}
