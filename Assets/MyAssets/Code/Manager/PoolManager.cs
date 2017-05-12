using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class PoolManager : IManager
    {
        public GameObject Spawn(GameObject prefab)
        {
            return MonoBehaviour.Instantiate(prefab);
        }

        public void Despawn(GameObject obj)
        {
            MonoBehaviour.Destroy(obj);
        }
    }
}
