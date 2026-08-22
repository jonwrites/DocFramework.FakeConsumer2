namespace JLib.Messaging;

/// <summary>
/// Defines an object capable of sending a message.
/// </summary>
public interface IMessageSender
{
    /// <summary>
    /// Sends the specified message.
    /// </summary>
    /// <param name="message">The message to send.</param>
    void Send(string message);
}