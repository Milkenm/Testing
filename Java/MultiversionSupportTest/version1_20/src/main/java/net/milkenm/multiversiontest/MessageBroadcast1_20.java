package net.milkenm.multiversiontest;

import net.kyori.adventure.text.Component;
import org.bukkit.Bukkit;

public class MessageBroadcast1_20 implements IMessageBroadcaster
{
	@Override
	public String getMessage()
	{
		return "Hello from 1.20!";
	}

	@Override
	public void broadcastMessage(String message)
	{
		Bukkit.getServer().broadcast(Component.text(message));
	}
}
