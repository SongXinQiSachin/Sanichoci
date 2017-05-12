using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Manager
{
    public partial class CameraManager : IManager
    {
        private static CameraManager instance;

        public static CameraManager Instance
        {
            get
            {
                return instance;
            }
        }
        private CameraManager()
        {
        }
    }
}
