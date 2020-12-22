using System;

namespace POO_PROJETODEPRODUTOS.classes
{
    public class Usuario
    {

        public Usuario(){
            Cadastrar();
        }

        public Usuario(int _codigo, string _nome , string _email , string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;

        }

        public int Codigo{get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataCadastro {get;set;}

        public void Cadastrar(){
            System.Console.WriteLine("Qual o seu nome?");
            Nome = Console.ReadLine();

            System.Console.WriteLine("");//Dar espaço

            System.Console.WriteLine($"Olá {Nome}, Qual o seu melhor E-mail?");
            Email = Console.ReadLine();

            System.Console.WriteLine("");//Dar espaço

            System.Console.WriteLine("Digite a sua senha: ");
            Senha = Console.ReadLine();

            System.Console.WriteLine(""); //Dar espaço

            System.Console.WriteLine($"Data de cadastro: {DataCadastro = DateTime.UtcNow}");           
        }

        public void Deletar(){
            
        }
    }
}