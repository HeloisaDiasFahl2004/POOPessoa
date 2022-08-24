using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPessoa
{
        internal class PessoaSimples
        {
        //atributos das classes
            String nome;
            String dataNascimento;
            int CPF;
            int telefone;

            public override string ToString()
            {
                return "Nome: " + nome + "\nDataNascimento: " + dataNascimento + "\nCPF: " + CPF + "\nTelefone: " + telefone;
            }
            public void setNome(String nome)//set, sem retorno, permite q determinada pessoa altere o conteudo no programa principal.
            {
                this.nome = nome;
            }
            public void setDataNascimento(String dataNascimento)//metodo set recebe parametro e insere no atriuto do objeto
            {
                this.dataNascimento = dataNascimento;
            }
            public void setCPF(int CPF)
            {
                this.CPF = CPF;
            }
            public void setTelefone(int telefone)
            {
                this.telefone = telefone;
            }

            public String getNome()//get, necessario retorno.
            {
                return nome;
            }
            public String getdataNascimento()//metodo get
            {
                return dataNascimento;
            }
            public int getCPF()
            {
                return CPF;
            }
            public int getTelefone()
            {
                return telefone;
            }
        }
    }



