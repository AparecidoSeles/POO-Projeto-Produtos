using System;
using System.Collections.Generic;

namespace POO_Projeto_Produtos.classes
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        DateTime DataCadastro { get; set; }

        List<Marca> Marcas = new List<Marca>();

        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o código da marca :");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca :");
            novaMarca.NomeMarca = Console.ReadLine();
            
            novaMarca.DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }
        
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in Marcas)
            {
                Console.WriteLine($"Código {item.Codigo}");
                Console.WriteLine($"Nome {item.NomeMarca}");
                Console.WriteLine($"Data de  cadastro {DataCadastro}");
            }
            Console.ResetColor();
        }
        
        public void Deletar(int codMArca){
            
        }
    }
}