using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class PrefabManager : MonoBehaviour, IManager
    {
        public GameObject GetPrefabFromName(string name)
        {
            FieldInfo fieldInfo = GetType().GetField(name);
            GameObject prefab = null;
            try
            {
                prefab = (GameObject)fieldInfo.GetValue(this);
            }
            catch (Exception e)
            {
                Debug.Log(e);
            }

            return prefab;
        }
    }
}
