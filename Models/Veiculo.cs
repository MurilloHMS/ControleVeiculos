using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVeiculos.Models
{
    internal class Veiculo : Validation
    {
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public string AnoModelo { get; set; }
        [Required]
        public string Modelo { get; set; }
        public string Motorista { get; set; }
        public string Observacoes { get; set; }
        public string NotaFiscalCompra {  get; set; }
        [Required]
        public string TipoVeiculo { get; set; }
        [Required]
        public char StatusVeiculo { get; set; }
    }
}
