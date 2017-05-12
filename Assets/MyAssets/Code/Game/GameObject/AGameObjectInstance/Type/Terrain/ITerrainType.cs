using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface ITerrainType
    {
        TerrainType TerrainType { get; }
    }

    public enum TerrainType
    {
        Normal,
        Ice,
        Water,
        Grass
    }
}
