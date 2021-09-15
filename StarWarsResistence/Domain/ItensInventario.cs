using System;
using System.ComponentModel.DataAnnotations;

namespace MediatorSimples.Domain
{
    public class ItensInventario : BaseDomain
    {
        [Required]
        public int Tipo { get; set; }

        public int Pontuacao { get; set; }
    }
}
