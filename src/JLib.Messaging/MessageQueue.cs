using JLib.Tools;

namespace JLib.Messaging;

/// <summary>
/// Represents a simple message queue that transforms messages before sending them.
/// </summary>
public class MessageQueue : IMessageSender
{
    private readonly ITextTransformer _textTransformer;

    /// <summary>
    /// Initializes a new instance of the <see cref="MessageQueue"/> class.
    /// </summary>
    /// <param name="textTransformer">
    /// The text transformer used to prepare messages before they are queued.
    /// </param>
    public MessageQueue(ITextTransformer textTransformer)
    {
        _textTransformer = textTransformer;
    }

    /// <summary>
    /// Sends a message by transforming it and adding it to the queue.
    /// </summary>
    /// <param name="message">The message to send.</param>
    public void Send(string message)
    {
        string transformedMessage = _textTransformer.Transform(message);

        // This is only a demonstration implementation.
        Console.WriteLine($"Queued: {transformedMessage}");
    }
}