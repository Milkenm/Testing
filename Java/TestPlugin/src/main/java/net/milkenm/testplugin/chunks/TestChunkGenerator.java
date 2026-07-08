package net.milkenm.testplugin.chunks;

import org.bukkit.Material;
import org.bukkit.World;
import org.bukkit.block.Biome;
import org.bukkit.generator.ChunkGenerator;
import org.bukkit.util.noise.SimplexOctaveGenerator;

import java.util.Random;

public class TestChunkGenerator extends ChunkGenerator
{
	private static final int PLOT_SIZE = 16; // Adjust based on your desired plot size
	private static final int BORDER_WIDTH = 1; // Width of the border

	@Override
	public ChunkData generateChunkData(World world, Random random, int chunkX, int chunkZ, BiomeGrid biome)
	{
		ChunkData chunk = createChunkData(world);
		SimplexOctaveGenerator generator = new SimplexOctaveGenerator(new Random(world.getSeed()), 8);
		generator.setScale(0D); // Scale for terrain variation, adjust as needed

		for (int x = 0; x < 16; x++)
		{
			for (int z = 0; z < 16; z++)
			{
				// Set the base terrain
				chunk.setBlock(x, 0, z, Material.BEDROCK);
				for (int y = 1; y < 15; y++)
				{
					biome.setBiome(x, y, z, Biome.PLAINS);
					chunk.setBlock(x, y, z, Material.DIRT);
				}
				chunk.setBlock(x, 15, z, Material.GRASS_BLOCK);

				// Generate borders
				if (x % PLOT_SIZE < BORDER_WIDTH || z % PLOT_SIZE < BORDER_WIDTH)
				{
					for (int y = 1; y <= 15; y++)
					{ // Adjust the height to match terrain or fixed height
						chunk.setBlock(x, y, z, Material.STONE); // Border block type
					}
				}
			}
		}
		return chunk;
	}
}
