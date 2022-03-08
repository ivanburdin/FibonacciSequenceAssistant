using FibonacciSequenceAssistant.Domain;

namespace FibonacciSequenceAssistant.GenericSubdomain
{
    public class FibonacciSequenceDto
    {
        public readonly long[] Sequence;

        public FibonacciSequenceDto(long[] sequence)
        {
            Sequence = sequence;
        }
        
        public FibonacciSequence ToDomain()
        {
            return new FibonacciSequence(Sequence);
        }
    }
}