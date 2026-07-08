package net.milkenm.testplugin.gui;

import net.milkenm.legacylib.paper.commands.AbstractBukkitCommand;
import net.milkenm.legacylib.paper.ui.gui.ProtectedGUIInventory;
import org.bukkit.entity.Player;
import org.bukkit.event.EventHandler;
import org.bukkit.event.inventory.InventoryCloseEvent;
import org.jetbrains.annotations.NotNull;

import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

public class TestGuiUnstealable extends AbstractBukkitCommand
{
	private final List<UUID> openGuis = new ArrayList<>();

	public TestGuiUnstealable()
	{
		super("guiu");
	}

	@Override
	public @NotNull List<String> getHelp()
	{
		return List.of("gui unstealable");
	}

	@Override
	public void onRunByPlayer(@NotNull Player player, @NotNull List<String> args)
	{
		TestGui.gui.setUnstealable(player, true);
		TestGui.gui.openTo(player);

		this.openGuis.add(player.getUniqueId());
	}

	@EventHandler
	public void onInventoryClose(InventoryCloseEvent e)
	{
		if (e.getInventory().getHolder() instanceof ProtectedGUIInventory guiInventory)
		{
			guiInventory.setUnstealable((Player) e.getPlayer(), false);
		}
	}
}
