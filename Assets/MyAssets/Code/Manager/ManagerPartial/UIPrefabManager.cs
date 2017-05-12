using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class UIPrefabManager : MonoBehaviour, IManager
    {
        private static UIPrefabManager instance;
        public static UIPrefabManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = GameObject.Find("UIPrefabManager").GetComponent<UIPrefabManager>();
                }
                return instance;
            }
        }
    }
}
