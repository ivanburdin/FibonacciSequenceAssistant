using FibonacciSequenceAssistant.DomainServices.Commands.ContinueFibonacciSequence.Contracts;
using FibonacciSequenceAssistant.GenericSubdomain;
using FibonacciSequenceAssistant.Presentation.Contollers.Contracts;

namespace FibonacciSequenceAssistant.Presentation.Contollers.Converters
{
    public static class ContinueFibonacciSequenceCommandFromExternalConverter
    {
        public static ContinueFibonacciSequenceCommand FromExternal(this ContinueFibonacciSequenceExternal request)
        {
            return new ContinueFibonacciSequenceCommand(new FibonacciSequenceDto(request.Sequence),
                request.RequestedLength);
        }
    }
}