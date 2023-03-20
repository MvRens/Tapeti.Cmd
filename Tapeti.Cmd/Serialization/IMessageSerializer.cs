using System;
using System.Collections.Generic;
using RabbitMQ.Client;

namespace Tapeti.Cmd.Serialization
{
    public class Message
    {
        public required ulong DeliveryTag;
        public required bool Redelivered;
        public required string Exchange;
        public required string RoutingKey;
        public required string Queue;
        public required IBasicProperties Properties;
        public required byte[] Body;
    }


    public interface IMessageSerializer : IDisposable
    {
        void Serialize(Message message);

        int GetMessageCount();
        IEnumerable<Message> Deserialize(IModel channel);
    }
}
