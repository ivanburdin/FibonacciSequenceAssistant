using System.Text;
using FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor.Converters;
using FibonacciSequenceAssistant.GenericSubdomain;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace FibonacciSequenceAssistant.ExternalServices.FibonacciSequenceAuthor
{
    public class FibonacciSequenceAuthorClient : IFibonacciSequenceAuthorClient
    {
        private readonly RabbitOptions _rabbitOptions;

        public FibonacciSequenceAuthorClient(RabbitOptions rabbitOptions)
        {
            _rabbitOptions = rabbitOptions;
        }

        public void Continue(FibonacciSequenceDto fibonacciSequence, int requestedLength)
        {
            var factory = new ConnectionFactory
            {
                HostName = _rabbitOptions.Host,
                UserName = _rabbitOptions.User,
                Password = _rabbitOptions.Password
            };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(_rabbitOptions.Queue,
                    false,
                    false,
                    false,
                    null);

                var message = JsonConvert.SerializeObject(fibonacciSequence.ToExternal(requestedLength));

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish("",
                    _rabbitOptions.Queue,
                    null,
                    body);
            }
        }
    }
}