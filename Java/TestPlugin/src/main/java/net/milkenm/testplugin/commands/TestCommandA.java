package net.milkenm.testplugin.commands;

import net.milkenm.legacylib.paper.commands.AbstractBukkitCommand;
import org.bukkit.entity.Player;
import org.jetbrains.annotations.NotNull;

import java.util.List;

public class TestCommandA extends AbstractBukkitCommand
{
	public TestCommandA()
	{
		super("a");
	}

	@Override
	public @NotNull List<String> getHelp()
	{
		return null;
	}

	@Override
	public void onRunByPlayer(@NotNull Player player, @NotNull List<String> args)
	{
		player.sendMessage("Hello, world! (A)");
	}
}
