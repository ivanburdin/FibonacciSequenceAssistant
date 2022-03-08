namespace FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor.Contracts
{
    public class ContinueFibonacciSequenceExternal
    {
        public readonly int RequestedLength;
        public readonly long[] Sequence;

        public ContinueFibonacciSequenceExternal(long[] sequence, int requestedLength)
        {
            Sequence = sequence;
            RequestedLength = requestedLength;
        }
    }
}