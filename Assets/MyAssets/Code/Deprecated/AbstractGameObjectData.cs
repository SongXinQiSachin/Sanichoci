using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Deprecated
{
    public abstract class AbstractGameObjectData : IGameObjectData
    {
        public abstract GameObject Prefab { get; }
    }
}
