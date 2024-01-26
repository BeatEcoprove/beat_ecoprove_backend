using System.Text.Json;

namespace BeatEcoprove.Infrastructure.WebSockets;

public enum MessageType
{
    GroupMessage
}

public class Message
{
    public MessageType MessageType { get; set; }
}

public class MessageBody<T>
{
    private readonly MessageType _messageType;

    public MessageBody(MessageType messageType, T content)
    {
        _messageType = messageType;
        Content = content;
    }

    public T Content { get; init; }
    public MessageType MessageType => _messageType;

    public string Type
    {
        get => _messageType.ToString();
        init
        {
            if (Enum.TryParse(value, out MessageType messageType))
            {
                _messageType = messageType;
            }
        }
    }

    public override string ToString() => JsonSerializer.Serialize(this);

    public static implicit operator string(MessageBody<T> messageBody)=> messageBody.ToString();
}