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
    public class ReportaTraicaoCommandHandler : IRequestHandler<ReportaTraicaoCommand, Rebelde>
    {
        public Task<Rebelde> Handle(ReportaTraicaoCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(
                ReportaTraicao(request.Rebelde)
            );
        }

        private Rebelde ReportaTraicao(Rebelde rebelde)
        {
            return rebelde.ReportaComoTraidor(rebelde);
        }
    }
}