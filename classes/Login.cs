using System;

namespace POO_Projeto_Produtos.classes
{
    public class Login
    {
        public bool Logado { get; set; }

        //MÉTODOS
        public Login(){
            Usuario user = new Usuario();
            Logar(user);

            if(Logado){
                GerarMenu();
            }
        }

        public void GerarMenu(){
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao = "n";

            do
            {
                Console.WriteLine("Escolha a operação que deseja fazer");
                Console.WriteLine("1 - cadastrar Marca");
                Console.WriteLine("2 - Listar Marca");
                Console.WriteLine("3 - Deletar Marca");
                Console.WriteLine("4 - Cadastrar Produto");
                Console.WriteLine("5 - Listar Produto");
                Console.WriteLine("6 - Deletar Produto");
                Console.WriteLine("0 - sair da aplicação");
                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                        marca.CadastrarMarca();
                        break;

                    case "2":
                    marca.Listar();
                        break;

                    case "3":
                        Console.WriteLine("Digite o código da Marca que dejesa deletar");
                        int codMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codMarca);
                        break;

                    case "4":
                        produto.Cadastrar();
                        break;

                    case "5":
                        produto.Listar();
                        break;

                    case "6":
                        Console.WriteLine("Digite o código do produto que dejesa deletar");
                        int cod = int.Parse(Console.ReadLine());
                        produto.Deletar(cod);
                        break;

                    case "0":
                        break;

                    default:
                        break;
                }
                
            } while (opcao != "0");
        }
        
        public  void Logar(Usuario usuario){

            Console.WriteLine("Digite seu Email :");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine("Digite sua senha");
            string senhaLogin = Console.ReadLine();
            
            if (emailLogin == usuario.Email && senhaLogin == usuario.Senha)
            {
                Logado = true;
                Console.WriteLine("Login efetuao com sucesso");
            }else{
                Console.WriteLine("Erro na aplicação");
            }
        }
        public string Deslogar(){
            return "";
        }
        
        
    }
}