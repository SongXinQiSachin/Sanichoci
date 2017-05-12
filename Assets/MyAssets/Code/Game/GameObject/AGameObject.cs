using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Game
{
    public abstract class AGameObject : IAGameObject
    {
        public abstract GameObject Prefab { get; }
    }
}
