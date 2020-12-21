using System;
using System.Collections.Generic;


namespace POO_PROJETODEPRODUTOS.classes
{
    public class Marca
    {
        int Codigo {get;set;}
        public string NomeMarca {get;set;}
        DateTime DataCadastro {get;set;}

        List<Marca> Marcas = new List<Marca>();

            public Marca CadastrarMarca(){
                Marca novaMarca = new Marca();

                System.Console.WriteLine("Digite o código da marca: ");
                novaMarca.Codigo = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Nome da marca: ");
                novaMarca.NomeMarca = Console.ReadLine();

                novaMarca.DataCadastro = DateTime.UtcNow;

                Marcas.Add(novaMarca);

                return novaMarca;
            }

            public void Listar(){
                System.Console.WriteLine("Marcas cadastradas: ");

                foreach (Marca m in Marcas)
                {   
                    Console.WriteLine("---------------------------------------------------------------------");
                    System.Console.WriteLine($"Nome da marca: {m.NomeMarca} - Código da Marca: {m.Codigo} -  Data de cadastro: {m.DataCadastro}");
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("");
                    
                    
                }
            }

            public void Deletar(int cod){
                Marca marcaDelete = Marcas.Find(m => m.Codigo == cod);
                Marcas.Remove(marcaDelete);

            }
    }
}
