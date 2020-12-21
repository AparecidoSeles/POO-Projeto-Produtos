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
        
        public Marca Marca {get; set;}

        public Usuario CadastradoPor{get; set;}

        public List<Produto> ListaProduto ;

        //MÉTODOS
        public void Cadastrar(){

        }

        public void Listar(){

        }

        public void Deletar(int cod){

        }

    }
}