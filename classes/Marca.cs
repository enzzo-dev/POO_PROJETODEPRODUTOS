using System;
using System.Collections.Generic;


namespace POO_PROJETODEPRODUTOS.classes
{
    public class Marca
    {
        int Codigo {get;set;}
        string NomeMarca {get;set;}
        DateTime DataCadastro {get;set;}

        List<Marca> Marcas {get;set;}

            public void CadastrarMarca(){
                Marca novaMarca = new Marca();

                System.Console.WriteLine("Digite o código da marca: ");
                Codigo = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Nome da marca: ");
                NomeMarca = Console.ReadLine();

                novaMarca.DataCadastro = DateTime.UtcNow;

                Marcas.Add(novaMarca);
            }

            public void Listar(){
                System.Console.WriteLine("Marcas cadastradas: ");

                foreach (Marca m in Marcas)
                {   
                    Console.WriteLine("---------------------------------------------------------------------");
                    System.Console.WriteLine($"Nome da marca: {m.NomeMarca} - Código da Marca: {m.Codigo} -  Data de cadastro: {m.DataCadastro}");
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("")
                    
                }
            }
    }
}
