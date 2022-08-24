using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POrientacaoObjetos
{
    internal class Pessoa
    {
        String nome;//atributo da classe
        int dataNascimento;
        int CPF;
        int telefone;
        
        public Pessoa()//método construtor sem parametro para instanciar objetos sem parametros
        {
            nome = "Zé Ninguém";
            idade = 0;
            cidade = "Araraquara";
            Console.WriteLine("Objeto construído com sucesso");
        }
        public Pessoa(string nome, int idade, string cidade)//método construtor com parametros para instanciar objetos com parametros
        {
            this.nome = nome;
            this.idade = idade;
            this.cidade = cidade;
        }
        public override string ToString()
        {
            return "Nome: " + nome + "\nIdade: " + idade + "\nCidade: " + cidade;
        }
        public void setNome(String nome)//set, sem retorno, permite q determinada pessoa altere o conteudo no programa principal.
        {
            this.nome = nome;
        }
        public void setIdade(int idade)//metodo set recebe parametro e insere no atriuto do objeto
        {
            this.idade = idade;
        }
        public String getNome()//get, necessario retorno.
        {
            return nome;
        }
        public int getIdade()//metodo get
        {
            return idade;
        }
    }
}

