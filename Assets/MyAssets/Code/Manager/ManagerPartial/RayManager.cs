using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Manager
{
    public partial class RayManager : IManager
    {
        private static RayManager instance;
        public static RayManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new RayManager();
                }
                return instance;
            }
        }

        private OnHit onHitDegelate;

        private RayManager()
        {
            onHitDegelate += (obj, hit) => { };
        }
    }
}
