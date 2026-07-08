package net.milkenm.testplugin.gui;

import net.kyori.adventure.text.Component;
import net.milkenm.legacylib.paper.commands.AbstractBukkitCommand;
import net.milkenm.legacylib.paper.ui.gui.ProtectedGUIInventory;
import net.milkenm.testplugin.TestPlugin;
import org.bukkit.Bukkit;
import org.bukkit.entity.Player;
import org.bukkit.event.inventory.InventoryClickEvent;
import org.jetbrains.annotations.NotNull;

import java.util.List;

public class TestGui extends AbstractBukkitCommand
{
	public static ProtectedGUIInventory gui;

	static
	{
		gui = new ProtectedGUIInventory(TestPlugin.getInstance(), Component.text("gui"), 6)
		{
			@Override
			public void onInventoryClick(InventoryClickEvent e)
			{
				Bukkit.broadcastMessage("meow");
			}
		};
	}

	public TestGui()
	{
		super("gui");
	}

	@Override
	public @NotNull List<String> getHelp()
	{
		return List.of("gui");
	}

	@Override
	public void onRunByPlayer(@NotNull Player player, @NotNull List<String> args)
	{
		gui.openTo(player);
	}
}
