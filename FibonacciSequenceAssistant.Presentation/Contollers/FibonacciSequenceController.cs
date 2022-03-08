using System.Threading;
using System.Threading.Tasks;
using FibonacciSequenceAssistant.Presentation.Contollers.Contracts;
using FibonacciSequenceAssistant.Presentation.Contollers.Converters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciSequenceAssistant.Presentation.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class FibonacciSequenceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FibonacciSequenceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(nameof(Continue))]
        public async Task Continue([FromBody] ContinueFibonacciSequenceExternal request,
            CancellationToken cancellationToken)
        {
            var command = request.FromExternal();

            await _mediator.Send(command, cancellationToken);
        }
    }
}