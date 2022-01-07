using System.Collections.Generic;
using BepInEx;
using CreatureManager;

namespace GoodestBoy
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class GoodestBoy : BaseUnityPlugin
	{
		private const string ModName = "GoodestBoy";
		private const string ModVersion = "0.0.1";
		private const string ModGUID = "org.bepinex.plugins.goodestboy";

		public void Awake()
		{
			Creature GermanShepherd = new("gsd", "GermanShepherd")
			{
				Biome = Heightmap.Biome.Meadows,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 600,
				RequiredWeather = new List<Weather> { Weather.Rain },
				Maximum = 2
			};
			GermanShepherd.Drops["WolfFang"].Amount = new Range(1, 2);
			GermanShepherd.Drops["WolfFang"].DropChance = 100f;
		}
	}
}
