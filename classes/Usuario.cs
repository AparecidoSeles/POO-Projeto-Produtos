using System;

namespace POO_Projeto_Produtos.classes
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        //MÉTODOS CONSTRUTORES
        public Usuario(){}
        public Usuario(int cod, string nome, string email, string senha){}
        public void Cadastrar(){}
        public void Deletar(){}     
        
    }
}