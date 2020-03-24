// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using NUnit.Framework;
using osu.Game.Rulesets.Osu.Mods;
using osu.Game.Tests.Visual;

namespace osu.Game.Rulesets.Osu.Tests.Mods
{
    public class TestSceneOsuModNoRecovery : ModTestScene
    {
        public TestSceneOsuModNoRecovery() : base(new OsuRuleset())
        {
        }

        [Test]
        public void TestDrainIsZero() => CreateModTest(new ModTestData
        {
            Mod = new OsuModNoRecovery(),
            Autoplay = false,
            PassCondition = () => checkDrainRateZero(),
        });

        [Test]
        public void TestNoHealthGainOnHitNote() => CreateModTest(new ModTestData
        {
            Mod = new OsuModNoRecovery(),
            Autoplay = true,
            PassCondition = () => checkNoHealthGain(),
        });

        private bool checkDrainRateZero() => Beatmap.Value.BeatmapInfo.BaseDifficulty.DrainRate == 0;

        private bool checkNoHealthGain() => Player.ScoreProcessor.JudgedHits >= 2 && Player.HealthProcessor.Health.Value < 1;
    }
}
