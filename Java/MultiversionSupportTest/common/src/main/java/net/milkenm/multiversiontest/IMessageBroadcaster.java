package net.milkenm.multiversiontest;

public interface IMessageBroadcaster
{
	String getMessage();

	void broadcastMessage(String message);
}
