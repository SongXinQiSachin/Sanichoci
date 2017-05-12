using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Manager
{
    public partial class GlobalUnitSelectedManager : IManager
    {
        private static GlobalUnitSelectedManager instance;

        public static GlobalUnitSelectedManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new GlobalUnitSelectedManager();
                }
                return instance;
            }
        }
    }
}
