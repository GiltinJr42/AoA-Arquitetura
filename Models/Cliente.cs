using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AoA_Arquitetura.Models
{
    public class Cliente
    {
        public long ClienteID { get; set; }
        public string Nome { get; set; }
        public DateTime DataEnvio { get; set; }
        public string Email { get; set; }
        public string Descricao { get; set; }
        public string Numero { get; set; }

    }
}