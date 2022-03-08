using FibonacciSequenceAssistant.Domain;
using FibonacciSequenceAssistant.GenericSubdomain;

namespace FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor.Converters
{
    public static class FibonacciSequenceDtoConverter
    {
        public static FibonacciSequenceDto FromDomain(this FibonacciSequence fibonacciSequence)
        {
            return new FibonacciSequenceDto(fibonacciSequence.Sequence);
        }
    }
}