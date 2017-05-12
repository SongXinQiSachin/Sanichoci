using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class BehaviourManager : MonoBehaviour, IManager
    {
        public void Init()
        {
        }
        private static BehaviourManager instance;
        public static BehaviourManager Instance
        {
            get
            {
                return instance;
            }
        }

        private BehaviourManager()
        {
        }

        public delegate void BehaviourProxy();
        private BehaviourProxy[] behaviourProxies;
    }
}
