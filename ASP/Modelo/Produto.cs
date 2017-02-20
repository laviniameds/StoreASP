using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Modelo
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        // Construtor
        public Produto()
        {
            this.Id = 0;
            this.Descricao = "";
        }
        public Produto(int Id, string Descricao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }
    }
}