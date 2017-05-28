using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class UIPrefabManager : MonoBehaviour, IManager
    {
        public GameObject AGOUnitShortInformation = null;
        public GameObject AGOItemShortInformation = null;
        public GameObject AGOTerrainShortInformation = null;

        private void Awake()
        {
        }

        private void Start()
        {
        }
    }
}
