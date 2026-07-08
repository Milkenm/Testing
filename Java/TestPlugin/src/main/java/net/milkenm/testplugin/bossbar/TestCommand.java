package net.milkenm.testplugin.bossbar;

import net.milkenm.legacylib.paper.commands.AbstractBukkitCommand;
import net.milkenm.legacylib.paper.ui.BossBar;
import net.milkenm.testplugin.commands.TestCommandA;
import org.bukkit.boss.BarColor;
import org.bukkit.boss.BarFlag;
import org.bukkit.boss.BarStyle;
import org.bukkit.entity.Player;
import org.jetbrains.annotations.NotNull;

import java.util.List;

public class TestCommand extends AbstractBukkitCommand
{
	public TestCommand()
	{
		super("teste");

		this.addSubCommands(new TestCommandA());
	}

	@Override
	public @NotNull List<String> getHelp()
	{
		return null;
	}

	@Override
	public void onRunByPlayer(@NotNull Player player, @NotNull List<String> args)
	{
		BossBar bb = new BossBar("Teste", BarColor.BLUE, BarStyle.SEGMENTED_20, BarFlag.PLAY_BOSS_MUSIC);
		bb.addPlayer(player);
	}
}
