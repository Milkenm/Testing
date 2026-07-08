package net.milkenm.testplugin.chunks;

import net.milkenm.legacylib.paper.commands.AbstractBukkitCommand;
import org.bukkit.WorldCreator;
import org.bukkit.command.CommandSender;
import org.jetbrains.annotations.NotNull;

import java.util.List;

import static org.apache.logging.log4j.LogManager.getLogger;

public class TestChunkGenCommand extends AbstractBukkitCommand
{
	public TestChunkGenCommand()
	{
		super("testgen");
	}

	@Override
	public void onRun(@NotNull CommandSender sender, @NotNull List<String> args)
	{
		WorldCreator wc = new WorldCreator(args.get(0));
		wc.generator(new TestChunkGenerator()); // Set the custom generator
		wc.createWorld();
		getLogger().info("Plot world with custom borders created!");
	}

	@Override
	public @NotNull List<String> getHelp()
	{
		return List.of("meow");
	}
}
