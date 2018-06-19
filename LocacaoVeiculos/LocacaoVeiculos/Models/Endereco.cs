using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models
{
    public class Endereco
    {
        public int EnderecoID { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }
    }
}