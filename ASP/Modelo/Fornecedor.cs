using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Modelo
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public bool Pessoa { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        // Construtor
        public Fornecedor()
        {
            this.Id = 0;
            this.Descricao = "";
            this.Telefone = "";
            this.Cidade = "";
            this.Estado = "";
            this.Endereco = "";
            this.CpfCnpj = "";
            this.Pessoa = true;
            this.Email = "";
        }
        public Fornecedor(int Id, string Descricao, string Telefone, string Cidade,
            string Estado, string Endereco, string CpfCnpj, bool Pessoa, string Email)
        {
            this.Id = Id;
            this.Descricao = Descricao;
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