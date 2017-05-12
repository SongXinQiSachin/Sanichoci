using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class TimeManager : IManager
    {
        private static TimeManager instance;

        public static TimeManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new TimeManager();
                }
                return instance;
            }
        }
        private TimeManager()
        {
        }
    }
}
