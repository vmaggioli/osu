// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Text;
using osu.Framework.Graphics.Sprites;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Mods
{
    public abstract class ModNoRecovery : Mod, IApplicableToHealthProcessor, IApplicableToDifficulty
    {
        public override string Name => "No Recovery";
        public override string Acronym => "NR";
        public override ModType Type => ModType.DifficultyIncrease;
        public override string Description => "No recovery, no drain.";
        public override double ScoreMultiplier => 1.2;

        public virtual void ApplyToHealthProcessor(HealthProcessor healthProcessor) { }

        public double AdjustHealthIncrease(double healthIncrease) => healthIncrease > 0 ? -healthIncrease : 0;

        public void ReadFromDifficulty(BeatmapDifficulty difficulty) { }

        public void ApplyToDifficulty(BeatmapDifficulty difficulty) => difficulty.DrainRate = 0;
    }
}
