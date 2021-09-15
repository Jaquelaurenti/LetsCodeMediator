using System;
using System.Collections.Generic;
using MediatorSimples.Domain;
using MediatorSimples.Utils;
using MediatR;

namespace MediatorSimples.Application.Commands

{
    public class InsereRebeldeCommand: IRequest<Rebelde>
    {
        public Localizacao Localizacao { get; private set; }
        public Inventario Inventario { get; private set; }
        public Rebelde Rebelde { get; private set; }
        public ItensInventario ItensInventario { get; private set; }

        public InsereRebeldeCommand(
            Localizacao localizacao,
            Inventario inventario,
            Rebelde rebelde,
            ItensInventario itens
        )
        {
            Localizacao = localizacao;
            Inventario = inventario;
            Rebelde = rebelde;
            ItensInventario = itens;
        }
    }
}