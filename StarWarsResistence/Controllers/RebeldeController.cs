using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatorSimples.Application;
using MediatorSimples.Application.Commands;
using MediatorSimples.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorSimples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RebeldeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RebeldeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Rebelde>>> Post([FromBody] InsereRebeldeCommand command)
        {
            var resultado = await _mediator.Send(command);
            return Ok(resultado);
        }
    }
}
