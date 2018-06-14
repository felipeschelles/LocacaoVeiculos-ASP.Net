using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models.MVC
{
    public class Cliente
    {
        public int UsuarioID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        public int Cpf { get; set; }

        public bool Ativo { get; set; }

    }
}