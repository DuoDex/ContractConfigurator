﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP;
using KSPAchievements;
using KSP.Localization;

namespace ContractConfigurator
{
    /// <summary>
    /// ContractRequirement to provide requirement for player having rendezvoued with a specific CelestialBody.
    /// </summary>
    public class RendezvousRequirement : ProgressCelestialBodyRequirement
    {
        protected override ProgressNode GetTypeSpecificProgressNode(CelestialBodySubtree celestialBodySubtree)
        {
            return celestialBodySubtree.rendezvous;
        }

        public override bool RequirementMet(ConfiguredContract contract)
        {
            return base.RequirementMet(contract) &&
                GetCelestialBodySubtree().IsComplete;
        }
    }
}
