# Getting Started

## Sending a message

Create an implementation of `IMessageSender` and call its `Send` method with the message to be delivered.

For example:

```csharp
IMessageSender sender = new MessageQueue(textTransformer);
sender.Send("Hello from JLib Messaging!");
```

The library currently provides [MessageQueue](../../JLib.Messaging.MessageQueue.html) and [LiveMessage](../../JLib.Messaging.LiveMessage.html) implementations.

Both implementations use a text transformer from the JLib Tools library to prepare messages before delivery.