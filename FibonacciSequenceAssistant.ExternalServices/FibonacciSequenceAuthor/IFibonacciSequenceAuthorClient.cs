using FibonacciSequenceAssistant.GenericSubdomain;

namespace FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor
{
    public interface IFibonacciSequenceAuthorClient
    {
        void Continue(FibonacciSequenceDto fibonacciSequence, int requestedLength);
    }
}