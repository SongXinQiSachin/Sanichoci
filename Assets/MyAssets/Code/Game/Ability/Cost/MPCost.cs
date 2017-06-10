using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sanichoci.Game;
using Sanichoci.Game.Interface;
using Sanichoci.OGO.AGO;

namespace Sanichoci.Game.Cost
{
    public class MPCost : ICost
    {
        public MPCost(float mp)
        {
            mpCost = mp;
        }

        private float mpCost;

        public bool CanCost(ICaster caster)
        {
            IMPCaster mpCaster = caster as IMPCaster;

            if (null != mpCaster)
            {
                return mpCaster.HasEnoughMP(mpCost);
            }

            return false;
        }
    }
}
