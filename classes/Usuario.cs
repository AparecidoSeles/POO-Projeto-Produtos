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
        public Usuario(){
            Nome  = "Aparecido Seles";
            Email = "admin@gmail.com";
            Senha = "78947894";
            DataCadastro = DateTime.UtcNow;
        }
        public Usuario(int cod, string nome, string email, string senha){}
        public void Cadastrar(){}
        public void Deletar(){
            
            Nome  = "";
            Email = "";
            Senha = "";
            // 2020-12-21-T09:44:25
            DataCadastro = DateTime.Parse("0000-00-00-00T00:00:00");

        }     
        
    }
}