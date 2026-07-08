package net.milkenm.testplugin.gui;

import net.kyori.adventure.text.Component;
import net.milkenm.legacylib.paper.commands.AbstractBukkitCommand;
import net.milkenm.legacylib.paper.ui.gui.PagedItemsGUIInventory;
import net.milkenm.testplugin.TestPlugin;
import org.bukkit.Material;
import org.bukkit.entity.Player;
import org.bukkit.event.inventory.InventoryClickEvent;
import org.bukkit.inventory.ItemStack;
import org.jetbrains.annotations.NotNull;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class PagedGui extends AbstractBukkitCommand
{
	public static PagedItemsGUIInventory gui;

	static
	{
		List<Material> guiMaterials = List.of(Material.IRON_INGOT, Material.GOLD_INGOT, Material.DIAMOND, Material.NETHERITE_INGOT, Material.EMERALD, Material.COAL, Material.REDSTONE, Material.LAPIS_LAZULI);

		gui = new PagedItemsGUIInventory(TestPlugin.getInstance(), Component.text("paged gui"), 4, new ItemStack(Material.DIRT), new ItemStack(Material.COBBLESTONE))
		{
			@Override
			public void onItemClick(int slotIndex, int absoluteIndex, InventoryClickEvent e)
			{
				ItemStack item = this.getItemAt(slotIndex);
				if (item != null)
				{
					System.out.println("clicked item: " + item.getType() + " at slot " + slotIndex + " absolute index " + absoluteIndex + " right click: " + e.isRightClick());
				}
				else
				{
					System.out.println("item not found");
				}
			}
		};
		gui.setUnstealable(false);

		List<ItemStack> itemsList = new ArrayList<>();
		for (int i = 0; i < 100; i++)
		{
			int index = new Random().nextInt(guiMaterials.size());
			Material material = guiMaterials.get(index);
			itemsList.add(new ItemStack(material));
		}

		gui.setItemsList(itemsList);
	}

	public PagedGui()
	{
		super("guip");
	}

	@Override
	public void onRunByPlayer(@NotNull Player player, @NotNull List<String> args)
	{
		gui.openTo(player);
	}

	@Override
	public @NotNull List<String> getHelp()
	{
		return List.of();
	}
}
