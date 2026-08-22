# Message Types

JLib Messaging provides two simple message delivery implementations.

## MessageQueue

`MessageQueue` represents a queued delivery mechanism. Messages are transformed before being added to the queue.

## LiveMessage

`LiveMessage` represents immediate delivery. Messages are transformed before being sent.

Both implementations implement the `IMessageSender` interface, allowing applications to depend on the abstraction rather than a specific delivery mechanism.