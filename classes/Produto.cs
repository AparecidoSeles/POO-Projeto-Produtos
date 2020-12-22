using System;
using System.Collections.Generic;

namespace POO_Projeto_Produtos.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string NomeProduto { get; set; }
        
        public float Preco { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        public Marca Marca = new Marca();

        public Usuario CadastradoPor = new Usuario();

        public List<Produto> ListaProduto = new List<Produto>();

        //MÉTODOS
        public void Cadastrar(){
            Produto novoProduto = new Produto();

            Console.WriteLine("Digite om código do produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto");
            novoProduto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine("Digite o preço do produto");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.UtcNow;

            // atribuimos nossa marca atraves de um método criado para  cadastro
            novoProduto.Marca = Marca.CadastrarMarca();

            //atribuimos o usuario através do método construtor
            novoProduto.CadastradoPor = new Usuario();

            ListaProduto.Add(novoProduto);

        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in ListaProduto)
            {
                Console.WriteLine($"Código {item.Codigo}");
                Console.WriteLine($"Nome {item.NomeProduto}");
                Console.WriteLine($"Preço {item.Preco}");
                Console.WriteLine($"Data de  cadastro {item.DataCadastro}");
                Console.WriteLine($"Marca {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por : {item.CadastradoPor.Nome}");

            }
            Console.ResetColor();
        }

        public void Deletar(int cod){

        }

    }
}