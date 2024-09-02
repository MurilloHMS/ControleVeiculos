using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVeiculos.Models
{
    internal class Bussiness : Address
    {
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string IE { get; set; }
    }
}
