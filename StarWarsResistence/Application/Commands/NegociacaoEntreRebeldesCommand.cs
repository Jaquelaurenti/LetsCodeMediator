using System;
using System.Collections.Generic;
using MediatorSimples.Domain;
using MediatorSimples.Utils;
using MediatR;

namespace MediatorSimples.Application.Commands

{
    public class NegociacaoEntreRebeldesCommand : IRequest<Tuple<Rebelde, Rebelde, ItensInventario, ItensInventario>>
    {
        public Rebelde RebeldeNegociante { get; private set; }
        public ItensInventario ItensInventarioNegociante { get; private set; }
        public Rebelde RebeldeNegocidor { get; private set; }
        public ItensInventario ItensInventarioNegociador { get; private set; }

        public NegociacaoEntreRebeldesCommand(
            Rebelde rebeldeNegociante,
            Rebelde rebeldeNegociador,
            ItensInventario itemNegociante,
            ItensInventario itemNegociador
        )
        {
            RebeldeNegociante = rebeldeNegociante;
            RebeldeNegocidor = rebeldeNegociador;
            ItensInventarioNegociador = itemNegociador;
            ItensInventarioNegociante = itemNegociante;
        }
    }
}