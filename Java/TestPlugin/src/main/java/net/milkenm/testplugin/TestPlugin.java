package net.milkenm.testplugin;

import net.milkenm.legacylib.paper.commands.CommandsManager;
import net.milkenm.testplugin.bossbar.TestCommand;
import net.milkenm.testplugin.bossbar.TestWardenBar;
import net.milkenm.testplugin.chunks.TestChunkGenCommand;
import net.milkenm.testplugin.chunks.TestTeleportToWorld;
import net.milkenm.testplugin.gui.PagedGui;
import net.milkenm.testplugin.gui.TestGui;
import net.milkenm.testplugin.gui.TestGuiUnstealable;
import org.bukkit.Bukkit;
import org.bukkit.event.Listener;
import org.bukkit.plugin.java.JavaPlugin;

import java.util.logging.Level;

public final class TestPlugin extends JavaPlugin implements Listener
{
	private static TestPlugin instance;

	public static TestPlugin getInstance()
	{
		return instance;
	}

	public TestPlugin()
	{
		instance = this;
	}

	@Override
	public void onEnable()
	{
		// Plugin startup logic
		this.getLogger().log(Level.INFO, "Meow");

		this.registerEvent(new TestWardenBar(this));
		this.registerEvent(new TestInfiniteArrow());

		CommandsManager.registerCommand(new TestCommand());
		CommandsManager.registerCommand(new TestGui());
		CommandsManager.registerCommand(new TestGuiUnstealable());
		CommandsManager.registerCommand(new TestChunkGenCommand());
		CommandsManager.registerCommand(new TestTeleportToWorld());
		CommandsManager.registerCommand(new PagedGui());
	}

	@Override
	public void onDisable()
	{
		// Plugin shutdown logic
		Bukkit.getLogger().log(Level.INFO, "Bye");
	}

	private void registerEvent(Listener listener)
	{
		this.getServer().getPluginManager().registerEvents(listener, this);
	}
}
