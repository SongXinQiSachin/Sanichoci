using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class PrefabManager : MonoBehaviour, IManager
    {
        public GameObject Dummy = null;
        public GameObject Terrain_512X512 = null;

        public GameObject DummyItem = null;

        private void Awake()
        {
        }

        private void Start()
        {
        }
    }
}
