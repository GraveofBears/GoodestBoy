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
		private const string ModVersion = "0.0.7";
		private const string ModGUID = "org.bepinex.plugins.goodestboy";

		public void Awake()
		{
			Creature EvilBunny = new("gsd", "EvilBunny")              //add creature
			{
				Biome = Heightmap.Biome.Meadows,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 600,
				RequiredWeather = new List<Weather> { Weather.ClearSkies },
				Maximum = 2
			};
			EvilBunny.Drops["YummyBone"].Amount = new Range(1, 2);
			EvilBunny.Drops["YummyBone"].DropChance = 100f;
			EvilBunny.Drops["LeatherScraps"].Amount = new Range(1, 2);
			EvilBunny.Drops["LeatherScraps"].DropChance = 10f;

			Creature BrownEvilBunny = new("gsd", "BrownEvilBunny")              //add creature
			{
				Biome = Heightmap.Biome.Meadows,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 600,
				RequiredWeather = new List<Weather> { Weather.ClearSkies },
				Maximum = 2
			};
			BrownEvilBunny.Drops["YummyBone"].Amount = new Range(1, 2);
			BrownEvilBunny.Drops["YummyBone"].DropChance = 100f;
			BrownEvilBunny.Drops["LeatherScraps"].Amount = new Range(1, 2);
			BrownEvilBunny.Drops["LeatherScraps"].DropChance = 10f;


			Creature BestestDog = new("gsd", "BestestDog")            //add creature
			{
				Biome = Heightmap.Biome.BlackForest,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 300,
				RequiredWeather = new List<Weather> { Weather.Rain },
				Maximum = 1
			};
			BestestDog.Drops["BoneFragments"].Amount = new Range(1, 2);
			BestestDog.Drops["BoneFragments"].DropChance = 100f;

			Item BestestStick = new("gsd", "BestestStick");           //add item
			BestestStick.Crafting.Add(CraftingTable.Workbench, 1);
			BestestStick.RequiredItems.Add("Wood", 1);
			BestestStick.CraftAmount = 1;

			Item YummyBone = new("gsd", "YummyBone");                  //add item
			YummyBone.Crafting.Add(CraftingTable.Workbench, 1);
			YummyBone.RequiredItems.Add("BoneFragments", 2);
			YummyBone.CraftAmount = 1;

			ItemManager.PrefabManager.RegisterPrefab("gsd", "dead_rabbit");    //zsync enforced
			ItemManager.PrefabManager.RegisterPrefab("gsd", "Bestest_Pup");
			ItemManager.PrefabManager.RegisterPrefab("gsd", "dead_rabbit_brown");
			ItemManager.PrefabManager.RegisterPrefab("gsd", "GermanShepherd_Rag");

		}
	}
}
