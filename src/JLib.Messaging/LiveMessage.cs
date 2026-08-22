using JLib.Tools;

namespace JLib.Messaging;

/// <summary>
/// Represents a message sender that delivers messages immediately.
/// </summary>
public class LiveMessage : IMessageSender
{
    private readonly ITextTransformer _textTransformer;

    /// <summary>
    /// Initializes a new instance of the <see cref="LiveMessage"/> class.
    /// </summary>
    /// <param name="textTransformer">
    /// The text transformer used to prepare messages before they are sent.
    /// </param>
    public LiveMessage(ITextTransformer textTransformer)
    {
        _textTransformer = textTransformer;
    }

    /// <summary>
    /// Sends a message immediately after transforming it.
    /// </summary>
    /// <param name="message">The message to send.</param>
    public void Send(string message)
    {
        string transformedMessage = _textTransformer.Transform(message);

        // This is only a demonstration implementation.
        Console.WriteLine($"Live: {transformedMessage}");
    }
}