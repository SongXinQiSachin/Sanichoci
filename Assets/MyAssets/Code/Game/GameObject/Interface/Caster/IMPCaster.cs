using Sanichoci.Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IMPCaster : ICaster, IMP
    {
        bool HasEnoughMP(float cost);
        void CastMP();
    }
}
