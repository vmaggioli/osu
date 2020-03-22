// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Mods
{
    public interface IApplicableToHealthProcessor : IApplicableMod
    {
        /// <summary>
        /// Provide a <see cref="HealthProcessor"/> to a mod. Called once on initialisation of a play instance.
        /// </summary>
        void ApplyToHealthProcessor(HealthProcessor healthProcessor);

        /// <summary>
        /// Called every time health is requested to change. Allows mods to adjust health regeneration rate.
        /// <param name="healthIncrease">Amount of health increase prior to current mod adjustment (can be negative)</param>
        /// </summary>
        double AdjustHealthIncrease(double healthIncrease);
    }
}
