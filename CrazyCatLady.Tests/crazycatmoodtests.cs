using System.Collections;
using DevTools.Testing;
using DevTools.Testing.Utils;
using RimWorld;
using Verse;

namespace CrazyCatLady.Tests;

[TestFixture(TestType.Playing)]
public class CrazycatmoodTests
{

	[SetUp]
	public void Setup()
	{
		
	}

	[Test]
	public IEnumerator Test1()
	{

		var pawn = PawnKindDefOf.Colonist
			.AsBuilder()
			.WithName("Millie")
			.WithModifer(x => x.story.traits.GainTrait(new Trait(TraitDef.Named("TD_CrazyCatLady"))))
			.Spawn();
		
		var catDef  = PawnKindDef.Named("Cat");
		var cats = catDef.AsBuilder().SpawnMany(50);
		
		bool hasMemory = pawn?.needs?.mood?.thoughts?.memories?.GetFirstMemoryOfDef(ThoughtDef.Named("TD_HappyCatLady")) != null;
		
		var thoughts = new List<Thought>();
		pawn?.needs?.mood?.thoughts?.GetMoodThoughtsFor(ThoughtDef.Named("TD_HappyCatLady"), thoughts);

		bool isActive = thoughts.Count > 0;
		
		yield return new WaitTicks(5000);
		
		
		}
	
	}
