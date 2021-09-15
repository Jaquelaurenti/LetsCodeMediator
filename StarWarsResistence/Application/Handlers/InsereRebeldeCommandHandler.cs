using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatorSimples.Application.Commands;
using MediatorSimples.Domain;
using MediatorSimples.Utils;
using MediatR;

namespace MediatorSimples.Application.Handlers
{
    public class InsereRebeldeCommandHandler : IRequestHandler<InsereRebeldeCommand, Rebelde>
    {
        Task<Rebelde> IRequestHandler<InsereRebeldeCommand, Rebelde>.Handle(InsereRebeldeCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}