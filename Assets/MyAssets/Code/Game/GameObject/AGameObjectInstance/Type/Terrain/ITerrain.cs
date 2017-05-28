using Sanichoci.Game.Interface;
using Sanichoci.Game.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface ITerrain :
        IAGameObject,
        IDescribable,
        IType, ITerrainType
    {
        MapType MapType { get; }
    }
}
