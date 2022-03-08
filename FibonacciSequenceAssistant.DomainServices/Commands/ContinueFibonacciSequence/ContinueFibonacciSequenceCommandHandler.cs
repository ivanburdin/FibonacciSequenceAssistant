using System.Text.Json;
using FibonacciSequenceAssistant.DomainServices.Commands.ContinueFibonacciSequence.Contracts;
using FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor;
using FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor.Converters;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FibonacciSequenceAssistant.DomainServices.Commands.ContinueFibonacciSequence
{
    public class ContinueFibonacciSequenceCommandHandler : RequestHandler<ContinueFibonacciSequenceCommand>
    {
        private readonly IFibonacciSequenceAuthorClient _fibonacciSequenceAuthorClient;
        private readonly ILogger<ContinueFibonacciSequenceCommandHandler> _logger;

        public ContinueFibonacciSequenceCommandHandler(
            ILogger<ContinueFibonacciSequenceCommandHandler> logger,
            IFibonacciSequenceAuthorClient fibonacciSequenceAuthorClient)
        {
            _logger = logger;
            _fibonacciSequenceAuthorClient = fibonacciSequenceAuthorClient;
        }


        protected override void Handle(ContinueFibonacciSequenceCommand request)
        {
            var sequence = request.FibonacciSequence.ToDomain();

            if (request.FibonacciSequence.Sequence.Length < request.RequestedLength)
            {
                sequence.Continue();

                _fibonacciSequenceAuthorClient.Continue(sequence.FromDomain(), request.RequestedLength);
            }
            else
            {
                var message = $"Finished Fibonacci sequence {JsonSerializer.Serialize(sequence.Sequence)}";

                _logger.LogInformation(message);
            }
        }
    }
}