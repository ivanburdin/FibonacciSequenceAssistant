using FibonacciSequenceAssistant.GenericSubdomain;
using MediatR;

namespace FibonacciSequenceAssistant.DomainServices.Commands.ContinueFibonacciSequence.Contracts
{
    public class ContinueFibonacciSequenceCommand : IRequest
    {
        public readonly FibonacciSequenceDto FibonacciSequence;
        public readonly int RequestedLength;

        public ContinueFibonacciSequenceCommand(FibonacciSequenceDto fibonacciSequence, int requestedLength)
        {
            FibonacciSequence = fibonacciSequence;
            RequestedLength = requestedLength;
        }
    }
}