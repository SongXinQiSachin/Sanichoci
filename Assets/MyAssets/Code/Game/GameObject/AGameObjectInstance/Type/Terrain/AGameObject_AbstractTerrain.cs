﻿using Sanichoci.Game.Interface;
using Sanichoci.Game.Map;
using Sanichoci.Kits;
using Sanichoci.Manager;
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
        protected override void Awake()
        {
            base.Awake();
        }
        protected override void Start()
        {
            base.Start();

            TerrainType = SanichociTypeNameParseKits.ParseTerrainType(this);
            MapType = SanichociTypeNameParseKits.ParseMapTypeFromTerrain(this);
        }

        public sealed override AGameObjectType Type
        {
            get
            {
                return AGameObjectType.Terrain;
            }
        }

        public virtual TerrainType TerrainType { get; set; }
        public virtual MapType MapType { get; set; }
    }
}
