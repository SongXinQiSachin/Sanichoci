using Sanichoci.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Game.AGameObjectInstance
{
    public class AGameObject_Terrain_512X512 : AGameObject_AbstractTerrain
    {
        public override GameObject Prefab
        {
            get
            {
                return PrefabManager.Instance.Terrain_512X512;
            }
        }

        public override string Name
        {
            get
            {
                return "Terrain_512X512";
            }
        }

        public override string Description
        {
            get
            {
                return "This is default terrain for develop";
            }
        }

        public override TerrainType TerrainType
        {
            get
            {
                return TerrainType.Normal;
            }
        }
    }
}
