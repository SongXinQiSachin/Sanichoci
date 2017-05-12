using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class PoolManager : IManager
    {
        private static PoolManager instance = null;
        public static PoolManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new PoolManager();
                }
                return instance;
            }
        }
        private PoolManager()
        {
        }
    }
}
