using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Manager
{
    public partial class PointerEventManager : IManager
    {
        private static PointerEventManager instance;

        public static PointerEventManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new PointerEventManager();
                }
                return instance;
            }
        }
        private PointerEventManager()
        {
        }
    }
}
