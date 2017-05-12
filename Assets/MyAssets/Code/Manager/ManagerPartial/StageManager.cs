using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class StageManager : MonoBehaviour, IManager
    {
        private static StageManager instance;

        public static StageManager Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
