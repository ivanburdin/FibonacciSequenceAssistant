using FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor.Contracts;
using FibonacciSequenceAssistant.GenericSubdomain;

namespace FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor.Converters
{
    public static class FibonacciSequenceToExternalConverter
    {
        public static ContinueFibonacciSequenceExternal ToExternal(this FibonacciSequenceDto sequence,
            int requestedLength)
        {
            return new ContinueFibonacciSequenceExternal(sequence.Sequence, requestedLength);
        }
    }
}