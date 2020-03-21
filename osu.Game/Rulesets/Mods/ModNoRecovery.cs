using System;
using System.Collections.Generic;
using System.Text;
using osu.Framework.Graphics.Sprites;
using osu.Game.Graphics;
using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Mods
{
    public abstract class ModNoRecovery : Mod, IApplicableToHealthProcessor
    {
        public override string Name => "No Recovery";
        public override string Acronym => "NR";
        public override IconUsage? Icon => OsuIcon.ModNoRecovery;
        public override ModType Type => ModType.DifficultyIncrease;
        public override string Description => "No recovery, no drain.";

        public double AdjustHealthIncrease(double healthIncrease) => healthIncrease > 0 ? 0 : healthIncrease;

        public virtual void ApplyToHealthProcessor(HealthProcessor healthProcessor)
        {
            throw new NotImplementedException();
        }
    }
}
