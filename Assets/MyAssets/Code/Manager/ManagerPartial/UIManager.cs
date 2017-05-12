using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class UIManager : MonoBehaviour, IManager
    {
        private static UIManager instance;

        public static UIManager Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
