using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiariosModel
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string CPF { get; set; }

        [Required]
        public string Nome { get; set; }
        public int IdCliente { get; set; }

    }
}