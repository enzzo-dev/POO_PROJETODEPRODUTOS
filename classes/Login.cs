using System;

namespace POO_PROJETODEPRODUTOS.classes
{
    public class Login
    {

         public Login(){
            
             Usuario user = new Usuario();

             Logar(user);

             if(Logado){
                GerarMenu();
             }
        }

        public bool Logado { get; set; }


        public void Logar(Usuario usuario){
            System.Console.WriteLine("Digite seu email: ");
            string emailLogin = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha){
                Logado = true;
                System.Console.WriteLine("Login efetuado com sucesso!");
            } else{
                System.Console.WriteLine("Falha ao logar!");
            }
        }

        public void Deslogar(){
            Logado = false;
        }
        
        public void GerarMenu(){
            Produto produto = new Produto();
            Marca marca = new Marca();
            int opcao;

            do{
                System.Console.WriteLine("Selecione uma opção: ");

                System.Console.WriteLine("[1] - Cadastrar Produto");
                System.Console.WriteLine("[2] - Listar Produtos ");
                System.Console.WriteLine("[3] - Deletar Produto");
                System.Console.WriteLine("[4] - Cadastrar Marca");
                System.Console.WriteLine("[5] - Listar Marca");
                System.Console.WriteLine("[6] - Deletar Marca ");
                System.Console.WriteLine("[0] - Sair da aplicação ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        produto.Cadastrar();
                    break;

                    case 2:
                        produto.Listar();
                    break;

                    case 3:
                        System.Console.WriteLine("Qual o código do produto que deseja deletar?");
                        int cod = int.Parse(Console.ReadLine());

                        produto.Deletar(cod);
                    break;

                    case 4:
                        marca.CadastrarMarca();
                    break;

                    case 5:
                        marca.Listar();
                    break;

                    case 6:
                        System.Console.WriteLine("Qual o código da marca da qual deseja deletar?");
                        int codMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codMarca);
                    break;

                    default:

                    break;
                }
                
            } while (opcao != 0);
        }
        
    }
}