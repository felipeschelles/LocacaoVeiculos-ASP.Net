using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models.MVC
{
    public class Veiculocs
    {

        public int VeiculoID { get; set; }

        public string Nome { get; set; }

        public string Fabricante { get; set; }

        public string Cor { get; set; }

        public int Ano { get; set; }
    }
}