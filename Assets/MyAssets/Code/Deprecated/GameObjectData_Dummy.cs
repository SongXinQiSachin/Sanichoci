using Sanichoci.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Deprecated
{
    public class GameObjectData_Dummy : AbstractGameObjectData
    {
        public override GameObject Prefab
        {
            get
            {
                //return PrefabManager.Instance.Dummy;
                return null;
            }
        }
    }
}
