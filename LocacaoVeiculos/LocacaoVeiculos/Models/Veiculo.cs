using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models
{
    public class Veiculo
    {

        public int VeiculoID { get; set; }


        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string Cor { get; set; }

        public int Ano { get; set; }

        public string Categoria { get; set; }

        public string Combustivel { get; set; }

        public string Detalhes { get; set; }

        public string Versao { get; set; }
    }
}