using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AoA_Arquitetura.Models;

namespace AoA_Arquitetura.Models
{
    public class Projeto
    {        public long ProjetoId { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
       public string Imagem { get; set; }
    }
}