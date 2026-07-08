package net.milkenm.testplugin;

import org.bukkit.entity.AbstractArrow;
import org.bukkit.entity.Arrow;
import org.bukkit.entity.Player;
import org.bukkit.event.EventHandler;
import org.bukkit.event.Listener;
import org.bukkit.event.entity.EntityShootBowEvent;

public class TestInfiniteArrow implements Listener
{
	@EventHandler(ignoreCancelled = true)
	public void onBowFire(EntityShootBowEvent e)
	{
		e.setConsumeItem(false);
		if (e.getEntity() instanceof Player player)
		{
			player.updateInventory();
		}

		((Arrow) e.getProjectile()).setPickupStatus(Arrow.PickupStatus.ALLOWED);
	}
}
