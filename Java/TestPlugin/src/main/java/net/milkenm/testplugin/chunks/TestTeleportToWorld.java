package net.milkenm.testplugin.chunks;

import net.milkenm.legacylib.paper.commands.AbstractBukkitCommand;
import org.bukkit.Bukkit;
import org.bukkit.command.CommandSender;
import org.bukkit.entity.Player;
import org.jetbrains.annotations.NotNull;

import java.util.List;

public class TestTeleportToWorld extends AbstractBukkitCommand
{
	public TestTeleportToWorld()
	{
		super("tpw");
	}

	@Override
	public @NotNull List<String> getHelp()
	{
		return List.of("/tpw <world>");
	}

	@Override
	public void onRunByPlayer(@NotNull Player player, @NotNull List<String> args)
	{
		Bukkit.getWorlds().add(Bukkit.createWorld(new org.bukkit.WorldCreator(args.get(0))));

		player.teleport(Bukkit.getWorld(args.get(0)).getSpawnLocation());
	}

	@Override
	public @NotNull List<String> tabComplete(@NotNull CommandSender sender, @NotNull String alias, String[] args) throws IllegalArgumentException
	{
		return Bukkit.getWorlds().stream().map(world -> world.getName()).toList();
	}
}
