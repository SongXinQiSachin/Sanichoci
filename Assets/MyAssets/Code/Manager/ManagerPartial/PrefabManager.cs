using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class PrefabManager : MonoBehaviour, IManager
    {
        private static PrefabManager instance;
        public static PrefabManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = GameObject.Find("PrefabManager").GetComponent<PrefabManager>();
                }
                return instance;
            }
        }
    }
}
