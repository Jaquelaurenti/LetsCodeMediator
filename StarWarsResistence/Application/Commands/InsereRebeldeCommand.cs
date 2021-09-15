using System;
using System.Collections.Generic;
using MediatorSimples.Domain;
using MediatorSimples.Utils;
using MediatR;

namespace MediatorSimples.Application.Commands

{
    public class ReportaTraicaoCommand: IRequest<Rebelde>
    {
        public Rebelde Rebelde { get; private set; }

        public ReportaTraicaoCommand(
            Rebelde rebelde
        )
        {
            Rebelde = rebelde;
        }
    }
}