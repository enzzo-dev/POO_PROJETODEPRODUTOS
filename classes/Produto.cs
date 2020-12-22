using System;
using System.Collections.Generic;

namespace POO_PROJETODEPRODUTOS.classes
{
    public class Produto
    {
        int Codigo {get;set;}
        public string NomeProduto {get;set;}
        public float Preco {get;set;}
    
        public DateTime DataCadastro {get;set;}
        public Marca Marca = new Marca();
        public Usuario CadastradoPor {get;set;}
        public List<Produto> ListaDeProdutos = new List<Produto>();
        


        public void Cadastrar(){
            Produto novoProduto = new Produto();

            System.Console.WriteLine("Digite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();
            
            System.Console.WriteLine("Digite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.UtcNow;

            Marca = Marca.CadastrarMarca();
 

            ListaDeProdutos.Add(novoProduto);
        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Produto item in ListaDeProdutos)
            {
                System.Console.WriteLine("----------------------------------------------------------");
                System.Console.WriteLine($"Código: {item.Codigo}");
                System.Console.WriteLine($"Produto: {item.NomeProduto}");
                System.Console.WriteLine($"Preço: {item.Preco.ToString("n2")}");
                System.Console.WriteLine($"Data de cadastro: {item.DataCadastro}");
                System.Console.WriteLine($"Marca:  {Marca.NomeMarca}");
                System.Console.WriteLine("----------------------------------------------------------");
                System.Console.WriteLine("");
            }
            Console.ResetColor();
        }

        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);

        }
    }   
}