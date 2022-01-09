using System.Collections.Generic;
using BepInEx;
using ItemManager;
using CreatureManager;

namespace GoodestBoy
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class GoodestBoy : BaseUnityPlugin
	{
		private const string ModName = "GoodestBoy";
		private const string ModVersion = "0.0.4";
		private const string ModGUID = "org.bepinex.plugins.goodestboy";

		public void Awake()
		{

			Item YummyBone = new("gsd", "YummyBone");
			YummyBone.Crafting.Add(CraftingTable.None, 1);

			Creature AssholeBunny = new("gsd", "AssholeBunny")
			{
				Biome = Heightmap.Biome.Meadows,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 600,
				RequiredWeather = new List<Weather> { Weather.Rain },
				Maximum = 2
			};
			AssholeBunny.Drops["YummyBone"].Amount = new Range(1, 2);
			AssholeBunny.Drops["YummyBone"].DropChance = 100f;

			Creature BestestDog = new("gsd", "BestestDog")
			{
				Biome = Heightmap.Biome.BlackForest,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 600,
				RequiredWeather = new List<Weather> { Weather.ClearSkies },
				Maximum = 2
			};
			BestestDog.Drops["BoneFragments"].Amount = new Range(1, 2);
			BestestDog.Drops["BoneFragments"].DropChance = 100f;

			ItemManager.PrefabManager.RegisterPrefab("gsd", "dead_rabbit");
			ItemManager.PrefabManager.RegisterPrefab("gsd","Bestest_Pup");
			ItemManager.PrefabManager.RegisterPrefab("gsd", "GermanShepherd_Rag");

			Item BestestStick = new("gsd", "BestestStick");
			BestestStick.Crafting.Add(CraftingTable.Workbench, 1);
			BestestStick.RequiredItems.Add("Wood", 1);
			BestestStick.CraftAmount = 1;
		}
	}
}
