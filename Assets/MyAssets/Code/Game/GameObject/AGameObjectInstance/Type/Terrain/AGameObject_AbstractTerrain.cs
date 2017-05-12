using Sanichoci.Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Game
{
    public abstract class AGameObject_AbstractTerrain :
        AbstractAGameObject,
        ITerrain
    {
        public override AGameObjectType Type
        {
            get
            {
                return AGameObjectType.Terrain;
            }
        }

        public abstract TerrainType TerrainType { get; }
    }
}
