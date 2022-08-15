using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace AndroidSpawner
{
    public class RankOneAndroidSpawner : Building
    {
        public override void Tick()
        {
            PawnKindDef r1 = PawnKindDefOf.OKA_RankOneAndroid;
            PawnGenerationRequest request = new PawnGenerationRequest(r1, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, false, 20f, false, true, true, false, false, false, false);
            Pawn pawn = PawnGenerator.GeneratePawn(request);
            System.Random r = new System.Random();
            int rAge = r.Next(70000000, 140000000); // Age 19 through 38, roughly
            pawn.ageTracker.AgeBiologicalTicks = rAge;
            GenSpawn.Spawn(pawn, Position, Map);
            base.Destroy();
        }
    }
    public class RankTwoAndroidSpawner : Building
    {
        public override void Tick()
        {
            PawnKindDef r2 = PawnKindDefOf.OKA_RankTwoAndroid;
            PawnGenerationRequest request = new PawnGenerationRequest(r2, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, false, 20f, false, true, true, false, false, false, false);
            Pawn pawn = PawnGenerator.GeneratePawn(request);
            System.Random r = new System.Random();
            int rAge = r.Next(70000000, 140000000); // Age 19 through 38, roughly
            pawn.ageTracker.AgeBiologicalTicks = rAge;
            GenSpawn.Spawn(pawn, Position, Map);
            base.Destroy();
        }
    }
    public class RankThreeAndroidSpawner : Building
    {
        public override void Tick()
        {
            PawnKindDef r3 = PawnKindDefOf.OKA_RankThreeAndroid;
            PawnGenerationRequest request = new PawnGenerationRequest(r3, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, false, 20f, false, true, true, false, false, false, false);
            Pawn pawn = PawnGenerator.GeneratePawn(request);
            System.Random r = new System.Random();
            int rAge = r.Next(70000000, 140000000); // Age 19 through 38, roughly
            pawn.ageTracker.AgeBiologicalTicks = rAge;
            GenSpawn.Spawn(pawn, Position, Map);
            base.Destroy();
        }
    }
    public class RankFourAndroidSpawner : Building
    {
        public override void Tick()
        {
            PawnKindDef r4 = PawnKindDefOf.OKA_RankFourAndroid;
            PawnGenerationRequest request = new PawnGenerationRequest(r4, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, false, 20f, false, true, true, false, false, false, false);
            Pawn pawn = PawnGenerator.GeneratePawn(request);
            System.Random r = new System.Random();
            int rAge = r.Next(70000000, 140000000); // Age 19 through 38, roughly
            pawn.ageTracker.AgeBiologicalTicks = rAge;
            GenSpawn.Spawn(pawn, Position, Map);
            base.Destroy();
        }
    }
}
