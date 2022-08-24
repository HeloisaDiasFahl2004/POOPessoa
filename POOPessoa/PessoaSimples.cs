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
            long CPF;
            long telefone;

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
            public void setCPF(long CPF)
            {
                this.CPF = CPF;
            }
            public void setTelefone(long telefone)
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
            public long getCPF()
            {
                return CPF;
            }
            public long getTelefone()
            {
                return telefone;
            }
        }
    }



