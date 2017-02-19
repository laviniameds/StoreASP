using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Endereco { get; set; }
        public string CpfCnpj { get; set; }
        public bool Pessoa { get; set; }
        public string Email { get; set; }

        // Construtor
        public Cliente()
        {
            this.Id = 0;
            this.Nome = "";
            this.Telefone = "";
            this.Cidade = "";
            this.Estado = "";
            this.Endereco = "";
            this.CpfCnpj = "";
            this.Pessoa = true;
            this.Email = "";
        }
        public Cliente(int Id, string Nome, string Telefone, string Cidade, 
            string Estado, string Endereco, string CpfCnpj, bool Pessoa, string Email)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Cidade = Cidade;
            this.Estado = Estado;
            this.Endereco = Endereco;
            this.CpfCnpj = CpfCnpj;
            this.Pessoa = Pessoa;
            this.Email = Email;
        }
    }
}