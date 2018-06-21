using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models
{
    public class Cliente
    {
        public int UsuarioID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        public int Cpf { get; set; }

        public string DtNascimento { get; set;}

        public int EnderecoID { get; set; }

        public virtual Endereco _Endereco { get; set; }





    }
}