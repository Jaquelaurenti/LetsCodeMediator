using System;
using System.ComponentModel.DataAnnotations;
using MediatorSimples.Domain.Enums;
namespace MediatorSimples.Domain
{
    public class Rebelde : BaseDomain
    {
        [Required]
        public string Nome { get; private set; }

        [Required]
        public int Idade { get; private set; }

        public int Reports { get; set; }

        public bool Traidor { get; set; }

        [Required]
        public Generos Genero { get; private set; }

        public Localizacao Localizacao { get; set; }

        public Inventario Inventario { get; set; }

        public Rebelde(string nome, int idade, int genero, Localizacao localizacao, Inventario inventario)
        {
            Nome = nome;
            Idade = idade;
            Genero = (Generos)genero;
            Localizacao = localizacao;
            Inventario = inventario;
        }

        public Rebelde ReportaComoTraidor(Rebelde rebelde)
        {
            Reports = Reports++;
            if (rebelde.Reports >= 3) SetaTraidor(rebelde);
            return rebelde;
        }

        public void SetaTraidor(Rebelde rebelde)
        {
            rebelde.Traidor = true;
        }

    }
}