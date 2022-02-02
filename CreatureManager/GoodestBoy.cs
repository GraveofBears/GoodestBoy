using System.Collections.Generic;
using BepInEx;
using ItemManager;
using CreatureManager;
using HarmonyLib;
using ServerSync;

namespace GoodestBoy
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class GoodestBoy : BaseUnityPlugin
	{
		private const string ModName = "GoodestBoy";
		private const string ModVersion = "0.1.2";
		private const string ModGUID = "org.bepinex.plugins.goodestboy";

		public void Awake()
		{

		Creature EvilBunny = new("gsd", "EvilBunny")              //add creature
			{
				Biome = Heightmap.Biome.Meadows,
			        SpawnChance = 30,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 600,
				SpecificSpawnTime = SpawnTime.Day,
			        RequiredWeather = Weather.ClearSkies,
				Maximum = 1
			};
			EvilBunny.Drops["LeatherScraps"].Amount = new Range(1, 2);
			EvilBunny.Drops["LeatherScraps"].DropChance = 10f;
			EvilBunny.Drops["Carrot"].Amount = new Range(1, 2);
			EvilBunny.Drops["Carrot"].DropChance = 10f;
			
			Creature BrownEvilBunny = new("gsd", "BrownEvilBunny")              //add creature
			{
				Biome = Heightmap.Biome.Meadows,
				SpawnChance = 30,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 600,
				SpecificSpawnTime = SpawnTime.Day,
				RequiredWeather = Weather.ClearSkies,
				Maximum = 1
			};
			BrownEvilBunny.Drops["LeatherScraps"].Amount = new Range(1, 2);
			BrownEvilBunny.Drops["LeatherScraps"].DropChance = 10f;
			BrownEvilBunny.Drops["Carrot"].Amount = new Range(1, 2);
			BrownEvilBunny.Drops["Carrot"].DropChance = 10f;


			Creature BestestDog = new("gsd", "BestestDog")            //add creature
			{
				Biome = Heightmap.Biome.BlackForest,
				SpawnChance = 10,
				GroupSize = new Range(1, 2),
				CheckSpawnInterval = 300,
				RequiredWeather = Weather.Rain,
				SpecificSpawnTime = SpawnTime.Night,
			        Maximum = 1
			};
			BestestDog.Drops["BoneFragments"].Amount = new Range(1, 2);
			BestestDog.Drops["BoneFragments"].DropChance = 15f;
			BestestDog.Drops["WolfMeat"].Amount = new Range(1, 2);
			BestestDog.Drops["WolfMeat"].DropChance = 50f;
			BestestDog.FoodItems = "BestestStick, YummyBone, RawMeat";
	

			Item BestestStick = new("gsd", "BestestStick");           //add item
			BestestStick.Crafting.Add(CraftingTable.Workbench, 1);
			BestestStick.RequiredItems.Add("Wood", 2);
			BestestStick.CraftAmount = 1;

			Item YummyBone = new("gsd", "YummyBone");                  //add item
			YummyBone.Crafting.Add(CraftingTable.Workbench, 1);
			YummyBone.RequiredItems.Add("BoneFragments", 4);
			YummyBone.CraftAmount = 1;

			ItemManager.PrefabManager.RegisterPrefab("gsd", "dead_rabbit");    //zsync enforced
			ItemManager.PrefabManager.RegisterPrefab("gsd", "Bestest_Pup");
			ItemManager.PrefabManager.RegisterPrefab("gsd", "dead_rabbit_brown");
			ItemManager.PrefabManager.RegisterPrefab("gsd", "GermanShepherd_Rag");

		}
	}
}
