package net.milkenm.testplugin.bossbar;

import net.milkenm.legacylib.paper.ui.BossBar;
import net.milkenm.legacylib.paper.util.Ticker;
import org.bukkit.Bukkit;
import org.bukkit.attribute.Attribute;
import org.bukkit.boss.BarColor;
import org.bukkit.boss.BarFlag;
import org.bukkit.boss.BarStyle;
import org.bukkit.entity.Entity;
import org.bukkit.entity.Player;
import org.bukkit.entity.Warden;
import org.bukkit.event.EventHandler;
import org.bukkit.event.Listener;
import org.bukkit.event.entity.EntitySpawnEvent;
import org.bukkit.event.world.EntitiesLoadEvent;
import org.bukkit.event.world.EntitiesUnloadEvent;
import org.bukkit.plugin.Plugin;

public class TestWardenBar implements Listener
{
	private final Plugin plugin;

	public TestWardenBar(Plugin plugin)
	{
		this.plugin = plugin;
	}

	@EventHandler(ignoreCancelled = true)
	private void onEntityLoad(EntitiesLoadEvent e)
	{
		for (Entity entity : e.getEntities())
		{
			if (entity instanceof Warden)
			{
				Bukkit.broadcastMessage("loaded warden");
			}
		}
	}

	@EventHandler(ignoreCancelled = true)
	private void onEntityUnloadEvent(EntitiesUnloadEvent e)
	{
		for (Entity entity : e.getEntities())
		{
			if (entity instanceof Warden)
			{
				Bukkit.broadcastMessage("unloaded warden");
			}
		}
	}

	@EventHandler(ignoreCancelled = true)
	private void onWardenSpawn(EntitySpawnEvent e)
	{
		if (!(e.getEntity() instanceof Warden warden))
		{
			return;
		}

		BossBar bar = new BossBar("Warden", BarColor.BLUE, BarStyle.SOLID, (BarFlag) null);
		new Ticker(this.plugin, 1, false)
		{
			@Override
			public void onTick()
			{
				if (warden.isDead())
				{
					for (Player player : bar.getPlayers())
					{
						bar.removePlayer(player);
					}

					this.stop();
					return;
				}

				bar.setValue(warden.getHealth() / warden.getAttribute(Attribute.GENERIC_MAX_HEALTH).getValue());

				for (Player player : Bukkit.getOnlinePlayers())
				{
					if (warden.getLocation().distance(player.getLocation()) <= 64)
					{
						bar.addPlayer(player);
					}
					else
					{
						bar.removePlayer(player);
					}
				}
			}
		};
	}
}
