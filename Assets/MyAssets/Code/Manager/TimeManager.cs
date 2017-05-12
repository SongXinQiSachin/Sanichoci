using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class TimeManager : IManager
    {
        public float DeltaTime()
        {
            return Time.deltaTime;
        }
    }
}
