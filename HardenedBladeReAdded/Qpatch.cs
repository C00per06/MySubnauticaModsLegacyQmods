using System;
using System.Collections.Generic;
using QModManager.API.ModLoading;
using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Utility;
using SMLHelper.V2.Interfaces;
using SMLHelper.V2.MonoBehaviours;
using SMLHelper.V2.Options;
using UnityEngine;

namespace DiamondBlade1
{
	[QModCore]
	public class Qpatch
	{
		[QModPatch]
		public static void Patch()
		{
			TechType techType = TechTypeHandler.AddTechType("DiamondBlade1", "Hardened Blade", "Diamond-hardened blade delivers higher damage.", SpriteManager.Get(TechType.DiamondBlade));
			TechType techType2 = TechTypeHandler.AddTechType("DiamondBlade2", "Hardened Blade", "Diamond-hardened blade delivers higher damage.", SpriteManager.Get(TechType.DiamondBlade));
			TechType techType3 = TechTypeHandler.AddTechType("DiamondBlade3", "Thermoblade", "Cooks and sterilizes small organisms for immediate consumption.", SpriteManager.Get(TechType.HeatBlade));
			TechData techData = new TechData();
			TechData techData2 = new TechData();
			TechData techData3 = new TechData();


			techData = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Silicone, 1),
					new Ingredient(TechType.Titanium, 1),
					new Ingredient(TechType.Diamond, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.DiamondBlade
				}
			};
			CraftDataHandler.SetTechData(techType, techData);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, techType, new string[]
			{
				"Personal",
				"Tools"
			});
			techData2 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.Knife, 1),
					new Ingredient(TechType.Diamond, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.DiamondBlade
				}
			};
			CraftDataHandler.SetTechData(techType2, techData2);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Workbench, techType2, new string[]
			{
				"KnifeMenu"
			});
			techData3 = new TechData
			{
				craftAmount = 0,
				Ingredients = new List<Ingredient>
				{
					new Ingredient(TechType.DiamondBlade, 1),
					new Ingredient(TechType.Battery, 1)
				},
				LinkedItems = new List<TechType>
				{
					TechType.HeatBlade
				}
			};
			CraftDataHandler.SetTechData(techType3, techData3);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Workbench, techType3, new string[]
			{
				"KnifeMenu"
			});
		}
	}
}
