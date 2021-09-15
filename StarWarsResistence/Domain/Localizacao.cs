using System;
using System.ComponentModel.DataAnnotations;

namespace MediatorSimples.Domain
{
    public class Localizacao : BaseDomain
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Galaxia { get; set; }

        [Required]
        public string Latitude { get; set; }

        [Required]
        public string Longitude { get; set; }

        public Localizacao(string nome, string galaxia, string latitude, string longitude)
        {
            Nome = nome;
            Galaxia = galaxia;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
