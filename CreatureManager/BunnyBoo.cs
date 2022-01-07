using System.Collections.Generic;
using BepInEx;
using CreatureManager;

namespace BunnyBoo
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class BunnyBoo : BaseUnityPlugin
	{
		private const string ModName = "BunnyBoo";
		private const string ModVersion = "1.0.0";
		private const string ModGUID = "org.bepinex.plugins.bunnyboo";

		public void Awake()
		{
			Creature BunnyYummy = new("bunnyyummy", "BunnyYummy")
			{
				Biome = Heightmap.Biome.Meadows,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 600,
				RequiredWeather = new List<Weather> { Weather.Rain },
				Maximum = 2
			};
			BunnyYummy.Drops["Wood"].Amount = new Range(1, 2);
			BunnyYummy.Drops["Wood"].DropChance = 100f;
		}
	}
}
