using System.Reflection;
using System.Linq;
using Verse;
using RimWorld;
using UnityEngine;
using HarmonyLib;

namespace Crazy_Cat_Lady
{
	[DefOf]
	public static class CatDefOf
	{
		public static ThingDef Cat;
		public static ThingDef Leather_Panthera;
		public static MentalStateDef TD_Wander_FollowCat;
		public static TraitDef TD_CrazyCatLady;
	}

	public class Mod : Verse.Mod
	{
		public Mod(ModContentPack content) : base(content)
		{

			Harmony harmony = new Harmony("Uuugggg.rimworld.Crazy_Cat_Lady.main");

			harmony.PatchAll();
		}
	}
}